﻿using System;
using System.Collections.Generic;
using System.Text;
using Queues;
using Structures;

namespace Lab_2_2
{
    class Model
    {
        private SystemClock clock;
        //времено public для теста
        /*private*/ public Resource cpu;
        /*private*/ public Resource device;
        private Memory ram;
        private IdGenerator idGen;
        //времено public для теста 
        /*private*/ public IQueueable<Process> readyQueue;
        /*private*/ public IQueueable<Process> deviceQueue;
        private CPUScheduler cpuScheduler;
        private MemoryManager memoryManager;
        private DeviceScheduler deviceScheduler;
        private Random processRand;
        private Settings modelSettings;
        private Random rand = new Random();

        public Model()
        {
            clock = new SystemClock();
            cpu = new Resource();
            device = new Resource();
            ram = new Memory();
            idGen = new IdGenerator();
            readyQueue = new PriorityQueue<Process, BinaryHeap<Process>>(new BinaryHeap<Process>());
            deviceQueue = new FIFOQueue<Process, QueueableList<Process>>(new QueueableList<Process>());
            cpuScheduler = new CPUScheduler(cpu, readyQueue);
            memoryManager = new MemoryManager();
            deviceScheduler = new DeviceScheduler(device, deviceQueue);
            processRand = new Random();
            modelSettings = new Settings();
        }

        public Settings ModelSet
        {
            get { return modelSettings; }
            set { modelSettings = value; }
        }

        private void Subscrive(Resource resource) 
        {
        
        }

        private void Unsubscribe(Resource resource) 
        {
        
        }

        public void SaveSettings()
        {
            ram.Save(modelSettings.ValueOfRAMSize);
            //memoryManager.Save(ram.Size);
            memoryManager.Save(ram);
        }

        public void WorkingCycle()
        {
            clock.WorkingCycle();
            if (processRand.NextDouble() <= modelSettings.Intensity)
            {
                Process proc = new Process(idGen.Id,
                    processRand.Next(modelSettings.MinValueOfAddrSpace, modelSettings.MaxValueOfAddrSpace + 1));
                if (memoryManager.Allocate(proc) != null)
                {
                    proc.BurstTime = processRand.Next(modelSettings.MinValueOfBurstTime,
                        modelSettings.MaxValueOfBurstTime + 1);
                    readyQueue.Put(proc);
                    if (cpu.IsFree())
                    {
                        cpuScheduler.Session();
                    }
                }
            }
            cpu.WorkingCycle();
            device.WorkingCycle();
        }

        public void Clear()
        {
            cpu.Clear();
            device.Clear();
            ram.Clear();
            readyQueue.Clear();
            deviceQueue.Clear();
        }

        private void FreeingAResourceEventHandler(object sender, EventArgs e)
        {
            Process p = sender as Process;

            if (p.Status == ProcessStatus.waiting)//процес покидает внешнее устройство
            {
                p.Status = ProcessStatus.ready;
                device.Clear();
                p.BurstTime = processRand.Next(modelSettings.MinValueOfBurstTime,
                       modelSettings.MaxValueOfBurstTime + 1);
                p.ResetWorkTime();
                readyQueue = readyQueue.Put(p);
                if (cpu.IsFree())
                {
                    cpuScheduler.Session();
                }
                if (deviceQueue.Count != 0)
                {
                    deviceQueue = deviceScheduler.Session();
                }
            }

            else //процесс покидает процессор
            {
                cpu.Clear();
                p.Status = rand.Next(0, 2) == 0 ? ProcessStatus.terminated :
                    ProcessStatus.waiting;
                if (p.Status == ProcessStatus.waiting)
                {
                    p.BurstTime = processRand.Next(modelSettings.MinValueOfBurstTime,
                       modelSettings.MaxValueOfBurstTime + 1);
                    p.ResetWorkTime();
                    deviceQueue = deviceQueue.Put(p);
                    if (device.IsFree())
                    {
                        deviceScheduler.Session();
                    }
                    if (readyQueue.Count != 0)
                    {
                        cpuScheduler.Session();
                    }
                }
                else
                {
                    memoryManager.Free(p);
                    Unsubscribe(p);
                }
                //readyQueue = cpuScheduler.Session();
            }
        }
        private void Subscribe(/*Resource resource*/Process p)
        {
            if (p != null)
            {
                p.FreeingAResource += FreeingAResourceEventHandler;
            }
        }
        private void Unsubscribe(/*Resource resource*/Process p)
        {
            if (p != null)
            {
                p.FreeingAResource -= FreeingAResourceEventHandler;
            }
        }
    }
}
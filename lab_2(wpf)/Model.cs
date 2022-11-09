using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;
using Queues;
using Structures;

namespace Lab_2_2
{
    class Model : INotifyPropertyChanged
    {
        /*private*/ public SystemClock clock;
        //времено public для теста
        /*private*/ public Resource cpu;
        /*private*/ public Resource device;
        public Memory ram;
        private IdGenerator idGen;
        //времено public для теста 
        /*private*/
        public IQueueable<Process> readyQueue; 
        public IQueueable<Process> ReadyQueue 
        {
            get { return readyQueue; }
            set { readyQueue = value; OnPropertyChanged(); }
        }
        /*private*/ public IQueueable<Process> deviceQueue;
        public IQueueable<Process> DeviceQueue
        {
            get { return deviceQueue; }
            set { deviceQueue = value; OnPropertyChanged(); }
        }
        private CPUScheduler cpuScheduler;
        private MemoryManager memoryManager;
        private DeviceScheduler deviceScheduler;
        private Random processRand;
        public Settings modelSettings;
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
                    Subscribe(proc);
                    ReadyQueue = readyQueue.Put(proc);
                    if (cpu.IsFree())
                    {
                        ReadyQueue = cpuScheduler.Session();
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
            ReadyQueue = readyQueue.Clear();
            DeviceQueue = deviceQueue.Clear();
        }

        private void FreeingAResourceEventHandler(object sender, EventArgs e)
        {
            Process resourceFreeingProcess = sender as Process;

            switch (resourceFreeingProcess.Status)//p.Status) 
            {
                case ProcessStatus.terminated:
                    Unsubscribe(resourceFreeingProcess);
                    cpu.Clear();
                    memoryManager.Free(resourceFreeingProcess);
                    if (readyQueue.Count != 0) 
                    {
                        putProcessOnResource(cpu);
                    }
                    break;
                case ProcessStatus.waiting:
                    //Unsubscribe(resourceFreeingProcess);
                    cpu.Clear();
                    if (readyQueue.Count != 0)
                    {
                        putProcessOnResource(cpu);
                    }
                    resourceFreeingProcess.ResetWorkTime();
                    resourceFreeingProcess.BurstTime = processRand.Next(modelSettings.MinValueOfBurstTime, modelSettings.MaxValueOfBurstTime + 1);
                    DeviceQueue = DeviceQueue.Put(resourceFreeingProcess);
                    if (device.IsFree()) 
                    {
                        putProcessOnResource(device);
                    }
                    break;
                case ProcessStatus.ready:
                    //Unsubscribe(resourceFreeingProcess);
                    device.Clear();
                    if (deviceQueue.Count != 0) 
                    {
                        putProcessOnResource(device);
                    }
                    resourceFreeingProcess.ResetWorkTime();
                    resourceFreeingProcess.BurstTime = processRand.Next(modelSettings.MinValueOfBurstTime, modelSettings.MaxValueOfBurstTime + 1);
                    ReadyQueue = readyQueue.Put(resourceFreeingProcess);
                    if (cpu.IsFree()) 
                    {
                        putProcessOnResource(cpu);
                    }
                    break;
                default:
                    throw new Exception("Unknown process status.");
            }
        }
        private void putProcessOnResource(Resource resource)
        {
            if (resource == cpu)
            {
                ReadyQueue = cpuScheduler.Session();
            }
            else 
            {
                DeviceQueue = deviceScheduler.Session();
            }
        }
        private void Subscribe(Process p)
        {
            if (p != null)
            {
                p.FreeingAResource += FreeingAResourceEventHandler;
            }
        }
        private void Unsubscribe(Process p)
        {
            if (p != null)
            {
                p.FreeingAResource -= FreeingAResourceEventHandler;
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        private void OnPropertyChanged([CallerMemberName] string propertyName = null) 
        {
            if (PropertyChanged != null) 
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
        

    }
}
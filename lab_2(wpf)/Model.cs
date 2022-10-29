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
        private SystemClock clock;
        //времено public для теста
        /*private*/ public Resource cpu;
        /*private*/ public Resource device;
        private Memory ram;
        private IdGenerator idGen;
        //времено public для теста 
        /*private*/
        public IQueueable<Process> readyQueue; 
        public IQueueable<Process> ReadyQueue 
        {
            get { return readyQueue; }
            set { readyQueue = value; }
        }
        /*private*/ public IQueueable<Process> deviceQueue;
        public IQueueable<Process> DeviceQueue
        {
            get { return deviceQueue; }
            set { deviceQueue = value; }
        }
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
                    //Subscribe(proc);
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
            Process resourceFreeingProcess = sender as Process;

            switch (resourceFreeingProcess.Status)//p.Status) 
            {
                case ProcessStatus.terminated:
                    Unsubscribe(cpu);
                    cpu.Clear();
                    memoryManager.Free(resourceFreeingProcess);
                    if (readyQueue.Count != 0) 
                    {
                        putProcessOnResource(cpu);
                    }
                    break;
                case ProcessStatus.waiting:
                    Unsubscribe(cpu);
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
                    Unsubscribe(device);
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

                    /*case ProcessStatus.ready:
                        Unsubscribe(device);
                        device.Clear();
                        p.BurstTime = processRand.Next(modelSettings.MinValueOfBurstTime
                            , modelSettings.MaxValueOfAddrSpace + 1);
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
                        break;
                    case ProcessStatus.terminated:
                        cpu.Clear();
                        memoryManager.Free(p);
                        Unsubscribe(cpu);
                        break;
                    case ProcessStatus.waiting:
                        cpu.Clear();
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
                        break;
                    default:
                        break;*/
            }
            


            //#1
            /*if  (p.Status == ProcessStatus.waiting)//процес покидает внешнее устройство
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
            }*/
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
        private void Subscribe(Resource resource /*Process p*/)
        {
            if (resource.ActiveProcess != null)
            {
                resource.ActiveProcess.FreeingAResource += FreeingAResourceEventHandler;
            }
        }
        private void Unsubscribe(Resource resource /*Process p*/)
        {
            if (resource.ActiveProcess != null)
            {
                resource.ActiveProcess.FreeingAResource -= FreeingAResourceEventHandler;
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
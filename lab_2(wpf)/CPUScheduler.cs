using System;
using System.Collections.Generic;
using System.Text;
using Queues;

namespace Lab_2_2
{
    class CPUScheduler
    {
        private Resource resource;
        private IQueueable<Process> queue;

        public CPUScheduler(Resource resource, IQueueable<Process> queue)
        {
            this.resource = resource;
            this.queue = queue;
        }
        public IQueueable<Process> Session()
        {
            // только для епустой очереди
            Process newActiveProcess = queue.Item();
            newActiveProcess.Status = ProcessStatus.running;
            queue.Remove();
            resource.ActiveProcess = newActiveProcess;
            return queue;
        }
    }
}
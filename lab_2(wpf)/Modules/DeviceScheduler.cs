using System;
using System.Collections.Generic;
using System.Text;
using Queues;

namespace Lab_2_2
{
    class DeviceScheduler
    {
        private Resource resource;
        private IQueueable<Process> queue;

        public DeviceScheduler(Resource resource, IQueueable<Process> queue)
        {
            this.resource = resource;
            this.queue = queue;
        }
        public IQueueable<Process> Session()
        {
            Process newActiveProcess = queue.Item();
            queue.Remove();
            resource.ActiveProcess = newActiveProcess;
            return queue;
        }
    }
}

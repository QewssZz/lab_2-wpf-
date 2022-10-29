
using Queues;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Lab_2_2
{
    class ViewDetailed : View
    {
        private Form1 frm;
        public ViewDetailed(Model model, Controller controller, Form1 frm) :
        base(model, controller)
        {
            this.frm = frm;
        }

        public override void DataBind()
        {
            Binding binding = new Binding("Text", model.cpu, "ActiveProcess");
            frm.listBox1.DataBindings.Add(binding);
        }
        public override void DataUnbind() { }

        // подписчик
        private void Subscribe() { }
        private void Unsubscribe() { }
        private void PropertyChangedHandler(object sender, PropertyChangedEventArgs e)
        { }

        private void updateListBox(IQueueable<Process> queue, ListBox lb)
        { }
    }
}

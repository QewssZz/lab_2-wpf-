
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

            Binding intensityBinding = new Binding("Value", model.modelSettings, "Intensity");
            intensityBinding.ControlUpdateMode = ControlUpdateMode.Never;
            frm.numericUpDown1.DataBindings.Add(intensityBinding);

            Binding burstMinBinding = new Binding("Value", model.modelSettings, "MinValueOfBurstTime");
            intensityBinding.ControlUpdateMode = ControlUpdateMode.Never;
            frm.numericUpDown2.DataBindings.Add(burstMinBinding);

            Binding burstMaxBinding = new Binding("Value", model.modelSettings, "MaxValueOfBurstTime");
            intensityBinding.ControlUpdateMode = ControlUpdateMode.Never;
            frm.numericUpDown3.DataBindings.Add(burstMaxBinding);

            Binding addrSpaceMinBinding = new Binding("Value", model.modelSettings, "MinValueOfAddrSpace");
            addrSpaceMinBinding.ControlUpdateMode = ControlUpdateMode.Never;
            frm.numericUpDown4.DataBindings.Add(addrSpaceMinBinding);

            Binding addrSpaceMaxBinding = new Binding("Value", model.modelSettings, "MaxValueOfAddrSpace");
            addrSpaceMaxBinding.ControlUpdateMode = ControlUpdateMode.Never;
            frm.numericUpDown5.DataBindings.Add(addrSpaceMaxBinding);

            Binding ramSizeBinding = new Binding("SelectedItem", model.modelSettings, "ValueOfRAMSize", true);
            ramSizeBinding.ControlUpdateMode = ControlUpdateMode.Never;
            frm.comboBox1.DataBindings.Add(ramSizeBinding);


            //frm.listBox1.DataBindings.Add(new Binding("DataSource", model, "ReadyQueue"));
            //frm.listBox2.DataBindings.Add(new Binding("DataSource", model, "DeviceQueue"));

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

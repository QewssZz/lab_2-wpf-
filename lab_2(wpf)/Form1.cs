using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_2_2
{
    public partial class Form1 : Form
    {
        private ViewDetailed viewDetailed;
        public Form1()
        {
            InitializeComponent();
            Model model = new Model();
            cbRamSize.SelectedItem = cbRamSize.Items[0];
            viewDetailed = new ViewDetailed(new Model(), new Controller(), this);
            viewDetailed.DataBind();
        }
        public Label LblTime
        {
            get { return lblTime; }
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            sessionPreparation();
            viewDetailed.ReactToUserActions(
                ModelOperations.SaveSettings);
        }


        private void btnWork_Click(object sender, EventArgs e)
        {
            viewDetailed.ReactToUserActions(
                ModelOperations.WorkingCycle);

        }

        private void btnSessionEnd_Click(object sender, EventArgs e)
        {
            viewDetailed.ReactToUserActions(
                ModelOperations.EndOfSession);
            endOfSession();
            UpdateSettings();
            
        }


        private void sessionPreparation()
        {
            btnSave.Enabled = false;
            btnEnd.Enabled = true;
            if (rbAuto.Checked) 
            {
                timer1.Start();
                btnWork.Enabled = false;
                timer1.Tick += btnWork_Click;
            }
            btnWork.Enabled = rbManual.Checked;
            panel1.Enabled = false;
            panel2.Enabled = false;
            panel3.Enabled = false;
            panel4.Enabled = false;
            panel5.Enabled = false;
            panel6.Enabled = false;

        }

        private void endOfSession()
        {
            btnEnd.Enabled = false;
            btnSave.Enabled = true;
            btnWork.Enabled = false;
            if (rbAuto.Checked) 
            {
                timer1.Stop();
            }
            
            panel1.Enabled = true;
            panel2.Enabled = true;
            panel3.Enabled = true;
            panel4.Enabled = true;
            panel5.Enabled = true;
            panel6.Enabled = true;
        }

        private void UpdateSettings()
        {
            nudIntensity.Value = 0.5m;
            nudBurstMin.Value = nudBurstMin.Minimum;
            nudBurstMax.Value = nudBurstMax.Minimum;
            nudAddrSpaceMin.Value = nudAddrSpaceMin.Minimum;
            nudAddrSpaceMax.Value = nudAddrSpaceMax.Minimum;
            cbRamSize.SelectedItem = cbRamSize.Items[0];
        }




        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void numericUpDown3_ValueChanged(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (rbAuto.Checked) 
            {
                btnWork_Click(sender, e);
            }
            //viewDetailed.ReactToUserActions(ModelOperations.WorkingCycle);
        }
        private void rbAutomatic_CheckedChanged(object sender, EventArgs e) 
        {
            RadioButton rb = sender as RadioButton;
            //if (rb.Checked)
            //{
            //    timer1.Start();
            //    btnWork.Enabled = false;
            //    timer1.Tick += btnWork_Click;
            //}
            if(rb.Checked == false)
            {
                timer1.Stop();
                btnWork.Enabled = true;
                timer1.Tick -= btnWork_Click;
            }
        }
    }
}
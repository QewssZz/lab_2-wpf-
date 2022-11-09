
using System;
using System.Windows.Forms;

namespace Lab_2_2
{
   
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.nudIntensity = new System.Windows.Forms.NumericUpDown();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.process1 = new System.Diagnostics.Process();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.nudBurstMin = new System.Windows.Forms.NumericUpDown();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.nudBurstMax = new System.Windows.Forms.NumericUpDown();
            this.cbRamSize = new System.Windows.Forms.ComboBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.nudAddrSpaceMin = new System.Windows.Forms.NumericUpDown();
            this.panel6 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.nudAddrSpaceMax = new System.Windows.Forms.NumericUpDown();
            this.panel7 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.panel8 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.panel9 = new System.Windows.Forms.Panel();
            this.OccupiedSize = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.FreeSize = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.panel10 = new System.Windows.Forms.Panel();
            this.label17 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.label14 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.panel11 = new System.Windows.Forms.Panel();
            this.rbManual = new System.Windows.Forms.RadioButton();
            this.label15 = new System.Windows.Forms.Label();
            this.rbAuto = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnWork = new System.Windows.Forms.Button();
            this.btnEnd = new System.Windows.Forms.Button();
            this.btnStats = new System.Windows.Forms.Button();
            this.lblTime = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.nudIntensity)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudBurstMin)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudBurstMax)).BeginInit();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudAddrSpaceMin)).BeginInit();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudAddrSpaceMax)).BeginInit();
            this.panel7.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel9.SuspendLayout();
            this.panel10.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.panel11.SuspendLayout();
            this.SuspendLayout();
            // 
            // nudIntensity
            // 
            this.nudIntensity.DecimalPlaces = 1;
            this.nudIntensity.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.nudIntensity.Location = new System.Drawing.Point(5, 70);
            this.nudIntensity.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudIntensity.Name = "nudIntensity";
            this.nudIntensity.Size = new System.Drawing.Size(141, 22);
            this.nudIntensity.TabIndex = 1;
            this.nudIntensity.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            // 
            // process1
            // 
            this.process1.StartInfo.Domain = "";
            this.process1.StartInfo.LoadUserProfile = false;
            this.process1.StartInfo.Password = null;
            this.process1.StartInfo.StandardErrorEncoding = null;
            this.process1.StartInfo.StandardOutputEncoding = null;
            this.process1.StartInfo.UserName = "";
            this.process1.SynchronizingObject = this;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.nudIntensity);
            this.panel1.Location = new System.Drawing.Point(12, 15);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(149, 95);
            this.panel1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, -3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 51);
            this.label1.TabIndex = 2;
            this.label1.Text = "Интенсивность\r\nпоступления \r\nпроцессов\r\n";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.nudBurstMin);
            this.panel2.Location = new System.Drawing.Point(242, 15);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(149, 95);
            this.panel2.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 68);
            this.label2.TabIndex = 5;
            this.label2.Text = "Минимальное \r\nзначение\r\nпромежутка\r\nработы на ЦП\r\n";
            // 
            // nudBurstMin
            // 
            this.nudBurstMin.Location = new System.Drawing.Point(6, 70);
            this.nudBurstMin.Name = "nudBurstMin";
            this.nudBurstMin.Size = new System.Drawing.Size(140, 22);
            this.nudBurstMin.TabIndex = 4;
            this.nudBurstMin.ValueChanged += new System.EventHandler(this.numericUpDown2_ValueChanged);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.nudBurstMax);
            this.panel3.Location = new System.Drawing.Point(470, 15);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(149, 95);
            this.panel3.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, -3);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 68);
            this.label3.TabIndex = 1;
            this.label3.Text = "Максимальное \r\nзначение\r\nпромежутка\r\nработы на ЦП";
            // 
            // nudBurstMax
            // 
            this.nudBurstMax.Location = new System.Drawing.Point(3, 70);
            this.nudBurstMax.Name = "nudBurstMax";
            this.nudBurstMax.Size = new System.Drawing.Size(143, 22);
            this.nudBurstMax.TabIndex = 0;
            this.nudBurstMax.ValueChanged += new System.EventHandler(this.numericUpDown3_ValueChanged);
            // 
            // cbRamSize
            // 
            this.cbRamSize.FormattingEnabled = true;
            this.cbRamSize.Items.AddRange(new object[] {
            "1000",
            "2000",
            "4000",
            "8000",
            "16000",
            "32000"});
            this.cbRamSize.Location = new System.Drawing.Point(3, 68);
            this.cbRamSize.Name = "cbRamSize";
            this.cbRamSize.Size = new System.Drawing.Size(143, 24);
            this.cbRamSize.TabIndex = 5;
            this.cbRamSize.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.label4);
            this.panel4.Controls.Add(this.cbRamSize);
            this.panel4.Location = new System.Drawing.Point(710, 15);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(149, 95);
            this.panel4.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, -3);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 51);
            this.label4.TabIndex = 6;
            this.label4.Text = "Размер\r\nоперативной \r\nпамяти";
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.label5);
            this.panel5.Controls.Add(this.nudAddrSpaceMin);
            this.panel5.Location = new System.Drawing.Point(995, 15);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(149, 95);
            this.panel5.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, -3);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(128, 68);
            this.label5.TabIndex = 1;
            this.label5.Text = "Минимальный \r\nразмер адресного\r\nпространства\r\nпроцесса";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // nudAddrSpaceMin
            // 
            this.nudAddrSpaceMin.Location = new System.Drawing.Point(3, 69);
            this.nudAddrSpaceMin.Name = "nudAddrSpaceMin";
            this.nudAddrSpaceMin.Size = new System.Drawing.Size(143, 22);
            this.nudAddrSpaceMin.TabIndex = 0;
            this.nudAddrSpaceMin.ValueChanged += new System.EventHandler(this.numericUpDown4_ValueChanged);
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.label6);
            this.panel6.Controls.Add(this.nudAddrSpaceMax);
            this.panel6.Location = new System.Drawing.Point(1252, 15);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(149, 95);
            this.panel6.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(128, 68);
            this.label6.TabIndex = 1;
            this.label6.Text = "Максимальный \r\nразмер адресного\r\nпространства\r\nпроцесса";
            // 
            // nudAddrSpaceMax
            // 
            this.nudAddrSpaceMax.Location = new System.Drawing.Point(3, 68);
            this.nudAddrSpaceMax.Name = "nudAddrSpaceMax";
            this.nudAddrSpaceMax.Size = new System.Drawing.Size(143, 22);
            this.nudAddrSpaceMax.TabIndex = 0;
            this.nudAddrSpaceMax.ValueChanged += new System.EventHandler(this.numericUpDown5_ValueChanged);
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.label7);
            this.panel7.Controls.Add(this.listBox1);
            this.panel7.Location = new System.Drawing.Point(12, 173);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(692, 270);
            this.panel7.TabIndex = 9;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 3);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(256, 17);
            this.label7.TabIndex = 11;
            this.label7.Text = "Очередь к центральному процессору";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(3, 23);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(686, 244);
            this.listBox1.TabIndex = 0;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.label8);
            this.panel8.Controls.Add(this.listBox2);
            this.panel8.Location = new System.Drawing.Point(710, 173);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(703, 270);
            this.panel8.TabIndex = 10;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(3, 3);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(224, 17);
            this.label8.TabIndex = 1;
            this.label8.Text = "Очередь к внешнему устройству";
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.ItemHeight = 16;
            this.listBox2.Location = new System.Drawing.Point(3, 20);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(706, 244);
            this.listBox2.TabIndex = 0;
            // 
            // panel9
            // 
            this.panel9.Controls.Add(this.OccupiedSize);
            this.panel9.Controls.Add(this.label11);
            this.panel9.Controls.Add(this.FreeSize);
            this.panel9.Controls.Add(this.label9);
            this.panel9.Location = new System.Drawing.Point(215, 452);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(929, 57);
            this.panel9.TabIndex = 11;
            // 
            // OccupiedSize
            // 
            this.OccupiedSize.AutoSize = true;
            this.OccupiedSize.Location = new System.Drawing.Point(753, 26);
            this.OccupiedSize.Name = "OccupiedSize";
            this.OccupiedSize.Size = new System.Drawing.Size(16, 17);
            this.OccupiedSize.TabIndex = 3;
            this.OccupiedSize.Text = "0";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(462, 26);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(262, 17);
            this.label11.TabIndex = 2;
            this.label11.Text = "Размер памяти, занятой процессами: ";
            // 
            // FreeSize
            // 
            this.FreeSize.AutoSize = true;
            this.FreeSize.Location = new System.Drawing.Point(228, 26);
            this.FreeSize.Name = "FreeSize";
            this.FreeSize.Size = new System.Drawing.Size(16, 17);
            this.FreeSize.TabIndex = 1;
            this.FreeSize.Text = "0";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(3, 9);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(187, 34);
            this.label9.TabIndex = 0;
            this.label9.Text = "Оперативная память\r\nРазмер свободной памяти:";
            this.label9.Click += new System.EventHandler(this.label9_Click_1);
            // 
            // panel10
            // 
            this.panel10.Controls.Add(this.label17);
            this.panel10.Controls.Add(this.label13);
            this.panel10.Location = new System.Drawing.Point(12, 113);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(692, 47);
            this.panel10.TabIndex = 12;
            this.panel10.Paint += new System.Windows.Forms.PaintEventHandler(this.panel10_Paint);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(3, 17);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(0, 17);
            this.label17.TabIndex = 1;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(-3, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(173, 17);
            this.label13.TabIndex = 0;
            this.label13.Text = "Центральный процессор";
            this.label13.Click += new System.EventHandler(this.label13_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.label14);
            this.flowLayoutPanel1.Controls.Add(this.label18);
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(710, 113);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(697, 47);
            this.flowLayoutPanel1.TabIndex = 13;
            this.flowLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.flowLayoutPanel1_Paint);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(3, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(146, 17);
            this.label14.TabIndex = 0;
            this.label14.Text = "Внешнее устройство";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(3, 17);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(0, 17);
            this.label18.TabIndex = 1;
            // 
            // panel11
            // 
            this.panel11.Controls.Add(this.rbManual);
            this.panel11.Controls.Add(this.label15);
            this.panel11.Controls.Add(this.rbAuto);
            this.panel11.Controls.Add(this.radioButton1);
            this.panel11.Location = new System.Drawing.Point(309, 526);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(353, 67);
            this.panel11.TabIndex = 14;
            // 
            // rbManual
            // 
            this.rbManual.AutoSize = true;
            this.rbManual.Checked = true;
            this.rbManual.Location = new System.Drawing.Point(10, 23);
            this.rbManual.Name = "rbManual";
            this.rbManual.Size = new System.Drawing.Size(77, 21);
            this.rbManual.TabIndex = 3;
            this.rbManual.TabStop = true;
            this.rbManual.Text = "Ручной";
            this.rbManual.UseVisualStyleBackColor = true;
            this.rbManual.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            // 
            // label15
            // 
            this.label15.Location = new System.Drawing.Point(0, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(100, 23);
            this.label15.TabIndex = 0;
            this.label15.Text = "Режим роботы";
            // 
            // rbAuto
            // 
            this.rbAuto.AutoSize = true;
            this.rbAuto.Location = new System.Drawing.Point(126, 23);
            this.rbAuto.Name = "rbAuto";
            this.rbAuto.Size = new System.Drawing.Size(138, 21);
            this.rbAuto.TabIndex = 1;
            this.rbAuto.Text = "Автоматический";
            this.rbAuto.UseVisualStyleBackColor = true;
            this.rbAuto.Click += new System.EventHandler(this.rbAutomatic_CheckedChanged);
            // 
            // radioButton1
            // 
            this.radioButton1.Location = new System.Drawing.Point(0, 0);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(104, 24);
            this.radioButton1.TabIndex = 2;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(698, 526);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(110, 67);
            this.btnSave.TabIndex = 15;
            this.btnSave.Text = "Сохранение \r\nнастроек";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnWork
            // 
            this.btnWork.Location = new System.Drawing.Point(814, 526);
            this.btnWork.Name = "btnWork";
            this.btnWork.Size = new System.Drawing.Size(106, 67);
            this.btnWork.TabIndex = 16;
            this.btnWork.Text = "Рабочий такт";
            this.btnWork.UseVisualStyleBackColor = true;
            this.btnWork.Click += new System.EventHandler(this.btnWork_Click);
            // 
            // btnEnd
            // 
            this.btnEnd.Location = new System.Drawing.Point(926, 526);
            this.btnEnd.Name = "btnEnd";
            this.btnEnd.Size = new System.Drawing.Size(104, 67);
            this.btnEnd.TabIndex = 17;
            this.btnEnd.Text = "Завершение \r\nсеанса";
            this.btnEnd.UseVisualStyleBackColor = true;
            this.btnEnd.Click += new System.EventHandler(this.btnSessionEnd_Click);
            // 
            // btnStats
            // 
            this.btnStats.Location = new System.Drawing.Point(1036, 526);
            this.btnStats.Name = "btnStats";
            this.btnStats.Size = new System.Drawing.Size(108, 67);
            this.btnStats.TabIndex = 18;
            this.btnStats.Text = "Статистика";
            this.btnStats.UseVisualStyleBackColor = true;
            this.btnStats.Click += new System.EventHandler(this.button4_Click);
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Location = new System.Drawing.Point(239, 549);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(16, 17);
            this.lblTime.TabIndex = 19;
            this.lblTime.Text = "0";
            // 
            // timer1
            // 
            this.timer1.Interval = 1500;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1413, 601);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.btnStats);
            this.Controls.Add(this.btnEnd);
            this.Controls.Add(this.btnWork);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.panel11);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.panel10);
            this.Controls.Add(this.panel9);
            this.Controls.Add(this.panel8);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.nudIntensity)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudBurstMin)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudBurstMax)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudAddrSpaceMin)).EndInit();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudAddrSpaceMax)).EndInit();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.panel9.ResumeLayout(false);
            this.panel9.PerformLayout();
            this.panel10.ResumeLayout(false);
            this.panel10.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.panel11.ResumeLayout(false);
            this.panel11.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void label7_Click(object sender, EventArgs e)
        {
            //throw new NotImplementedException();
        }

        private void numericUpDown5_ValueChanged(object sender, EventArgs e)
        {
            //throw new NotImplementedException();
        }

        private void numericUpDown4_ValueChanged(object sender, EventArgs e)
        {
           // throw new NotImplementedException();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            //throw new NotImplementedException();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //throw new NotImplementedException();
        }

        private void label9_Click_1(object sender, EventArgs e)
        {
           // throw new NotImplementedException();
        }

        private void panel10_Paint(object sender, PaintEventArgs e)
        {
            //throw new NotImplementedException();
        }

        private void label13_Click(object sender, EventArgs e)
        {
            //throw new NotImplementedException();
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            //throw new NotImplementedException();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //throw new NotImplementedException();
        }

        #endregion
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Diagnostics.Process process1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Panel panel7;
        public System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnStats;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.RadioButton rbAuto;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.RadioButton rbManual;
        public NumericUpDown nudIntensity;
        public NumericUpDown nudBurstMin;
        public NumericUpDown nudBurstMax;
        public NumericUpDown nudAddrSpaceMax;
        public NumericUpDown nudAddrSpaceMin;
        public ComboBox cbRamSize;
        public ListBox listBox2;
        public Label OccupiedSize;
        public Label FreeSize;
        public Label label17;
        public Label label18;
        public Label lblTime;
        public Button btnWork;
        public Button btnEnd;
        public Button btnSave;
        public Timer timer1;
    }

}


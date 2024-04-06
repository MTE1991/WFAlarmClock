namespace WFAlarmClock
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.clkLabel = new System.Windows.Forms.Label();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.monthCalendar = new System.Windows.Forms.MonthCalendar();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.txtHour = new System.Windows.Forms.TextBox();
            this.txtMinute = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnSetAlarm = new System.Windows.Forms.Button();
            this.comboBoxAMPM = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.listBoxAlarms = new System.Windows.Forms.ListBox();
            this.label5 = new System.Windows.Forms.Label();
            this.buttonClrQueue = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // clkLabel
            // 
            this.clkLabel.AutoSize = true;
            this.clkLabel.Font = new System.Drawing.Font("AcadEref", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clkLabel.Location = new System.Drawing.Point(455, 67);
            this.clkLabel.Name = "clkLabel";
            this.clkLabel.Size = new System.Drawing.Size(203, 100);
            this.clkLabel.TabIndex = 0;
            this.clkLabel.Text = "Time";
            // 
            // timer
            // 
            this.timer.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // monthCalendar
            // 
            this.monthCalendar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.monthCalendar.Location = new System.Drawing.Point(30, 18);
            this.monthCalendar.Name = "monthCalendar";
            this.monthCalendar.TabIndex = 1;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton1.Location = new System.Drawing.Point(459, 18);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(183, 36);
            this.radioButton1.TabIndex = 2;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "12hr format";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton2.Location = new System.Drawing.Point(735, 18);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(183, 36);
            this.radioButton2.TabIndex = 3;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "24hr format";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // txtHour
            // 
            this.txtHour.Location = new System.Drawing.Point(60, 84);
            this.txtHour.Name = "txtHour";
            this.txtHour.Size = new System.Drawing.Size(100, 26);
            this.txtHour.TabIndex = 4;
            // 
            // txtMinute
            // 
            this.txtMinute.Location = new System.Drawing.Point(220, 84);
            this.txtMinute.Name = "txtMinute";
            this.txtMinute.Size = new System.Drawing.Size(100, 26);
            this.txtMinute.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(20, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(347, 29);
            this.label1.TabIndex = 6;
            this.label1.Text = "Set Alarm (Enter in 12hr format)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(16, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 29);
            this.label2.TabIndex = 7;
            this.label2.Text = "hr:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(166, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 29);
            this.label3.TabIndex = 8;
            this.label3.Text = "min:";
            // 
            // btnSetAlarm
            // 
            this.btnSetAlarm.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSetAlarm.Location = new System.Drawing.Point(153, 144);
            this.btnSetAlarm.Name = "btnSetAlarm";
            this.btnSetAlarm.Size = new System.Drawing.Size(186, 53);
            this.btnSetAlarm.TabIndex = 9;
            this.btnSetAlarm.Text = "Set Alarm";
            this.btnSetAlarm.UseVisualStyleBackColor = true;
            this.btnSetAlarm.Click += new System.EventHandler(this.btnSetAlarm_Click);
            // 
            // comboBoxAMPM
            // 
            this.comboBoxAMPM.FormattingEnabled = true;
            this.comboBoxAMPM.Items.AddRange(new object[] {
            "AM",
            "PM"});
            this.comboBoxAMPM.Location = new System.Drawing.Point(424, 82);
            this.comboBoxAMPM.Name = "comboBoxAMPM";
            this.comboBoxAMPM.Size = new System.Drawing.Size(85, 28);
            this.comboBoxAMPM.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(326, 83);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 29);
            this.label4.TabIndex = 11;
            this.label4.Text = "AM/PM:";
            // 
            // listBoxAlarms
            // 
            this.listBoxAlarms.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxAlarms.FormattingEnabled = true;
            this.listBoxAlarms.ItemHeight = 25;
            this.listBoxAlarms.Location = new System.Drawing.Point(30, 360);
            this.listBoxAlarms.Name = "listBoxAlarms";
            this.listBoxAlarms.Size = new System.Drawing.Size(328, 129);
            this.listBoxAlarms.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(25, 331);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(256, 26);
            this.label5.TabIndex = 13;
            this.label5.Text = "Currently queued alarms:";
            // 
            // buttonClrQueue
            // 
            this.buttonClrQueue.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonClrQueue.Location = new System.Drawing.Point(154, 202);
            this.buttonClrQueue.Name = "buttonClrQueue";
            this.buttonClrQueue.Size = new System.Drawing.Size(185, 52);
            this.buttonClrQueue.TabIndex = 14;
            this.buttonClrQueue.Text = "Clear Queue";
            this.buttonClrQueue.UseVisualStyleBackColor = true;
            this.buttonClrQueue.Click += new System.EventHandler(this.buttonClrQueue_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel1.Controls.Add(this.btnSetAlarm);
            this.panel1.Controls.Add(this.buttonClrQueue);
            this.panel1.Controls.Add(this.txtHour);
            this.panel1.Controls.Add(this.txtMinute);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.comboBoxAMPM);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(434, 234);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(524, 270);
            this.panel1.TabIndex = 15;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(985, 539);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.listBoxAlarms);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.monthCalendar);
            this.Controls.Add(this.clkLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Alarm Clock";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label clkLabel;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.MonthCalendar monthCalendar;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.TextBox txtHour;
        private System.Windows.Forms.TextBox txtMinute;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnSetAlarm;
        private System.Windows.Forms.ComboBox comboBoxAMPM;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox listBoxAlarms;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button buttonClrQueue;
        private System.Windows.Forms.Panel panel1;
    }
}


namespace ctlClockLib
{
    public partial class ctlAlarmClock
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblAlarm = new Label();
            btnAlarmOff = new Button();
            SuspendLayout();
            // 
            // lblAlarm
            // 
            lblAlarm.AutoSize = true;
            lblAlarm.Location = new Point(187, 10);
            lblAlarm.Name = "lblAlarm";
            lblAlarm.Size = new Size(65, 20);
            lblAlarm.TabIndex = 1;
            lblAlarm.Text = "!Alarma!";
            lblAlarm.TextAlign = ContentAlignment.MiddleCenter;
            lblAlarm.Visible = false;
            // 
            // btnAlarmOff
            // 
            btnAlarmOff.Location = new Point(12, 50);
            btnAlarmOff.Name = "btnAlarmOff";
            btnAlarmOff.Size = new Size(192, 29);
            btnAlarmOff.TabIndex = 2;
            btnAlarmOff.Text = "Deshabilitar alarma";
            btnAlarmOff.UseVisualStyleBackColor = true;
            btnAlarmOff.Click += btnAlarmOff_Click;
            // 
            // ctlAlarmClock
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(btnAlarmOff);
            Controls.Add(lblAlarm);
            Name = "ctlAlarmClock";
            Controls.SetChildIndex(lblAlarm, 0);
            Controls.SetChildIndex(btnAlarmOff, 0);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblAlarm;
        private Button btnAlarmOff;
    }
}

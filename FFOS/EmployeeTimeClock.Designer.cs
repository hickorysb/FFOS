namespace FFOS
{
    partial class EmployeeTimeClock
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
            this.job_list = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.rop = new System.Windows.Forms.Label();
            this.jobcode = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // job_list
            // 
            this.job_list.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.job_list.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.job_list.FormattingEnabled = true;
            this.job_list.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.job_list.Location = new System.Drawing.Point(12, 12);
            this.job_list.Name = "job_list";
            this.job_list.Size = new System.Drawing.Size(298, 37);
            this.job_list.TabIndex = 0;
            this.job_list.SelectedIndexChanged += new System.EventHandler(this.job_list_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 227);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(298, 42);
            this.button1.TabIndex = 1;
            this.button1.Text = "Cancel";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(12, 179);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(298, 42);
            this.button2.TabIndex = 2;
            this.button2.Text = "Clock In";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // rop
            // 
            this.rop.AutoSize = true;
            this.rop.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rop.Location = new System.Drawing.Point(8, 52);
            this.rop.Name = "rop";
            this.rop.Size = new System.Drawing.Size(114, 24);
            this.rop.TabIndex = 3;
            this.rop.Text = "Rate of Pay: ";
            // 
            // jobcode
            // 
            this.jobcode.AutoSize = true;
            this.jobcode.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.jobcode.Location = new System.Drawing.Point(8, 76);
            this.jobcode.Name = "jobcode";
            this.jobcode.Size = new System.Drawing.Size(97, 24);
            this.jobcode.TabIndex = 5;
            this.jobcode.Text = "Job Code:";
            // 
            // EmployeeTimeClock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(322, 281);
            this.Controls.Add(this.jobcode);
            this.Controls.Add(this.rop);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.job_list);
            this.Name = "EmployeeTimeClock";
            this.Text = "TimeClock";
            this.TopMost = true;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox job_list;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label rop;
        private System.Windows.Forms.Label jobcode;
    }
}
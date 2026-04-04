namespace KalendarFiser
{
    partial class UdalostForm
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
            this.txtBoxHodiny = new System.Windows.Forms.TextBox();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBoxMinuty = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtBoxHodiny
            // 
            this.txtBoxHodiny.BackColor = System.Drawing.SystemColors.Control;
            this.txtBoxHodiny.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBoxHodiny.Font = new System.Drawing.Font("Segoe UI", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtBoxHodiny.Location = new System.Drawing.Point(58, 215);
            this.txtBoxHodiny.Multiline = true;
            this.txtBoxHodiny.Name = "txtBoxHodiny";
            this.txtBoxHodiny.Size = new System.Drawing.Size(92, 96);
            this.txtBoxHodiny.TabIndex = 1;
            this.txtBoxHodiny.Text = "99";
            this.txtBoxHodiny.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.CalendarFont = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.dateTimePicker.Font = new System.Drawing.Font("Segoe UI", 15.75F);
            this.dateTimePicker.Location = new System.Drawing.Point(58, 170);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(366, 35);
            this.dateTimePicker.TabIndex = 3;
            this.dateTimePicker.Value = new System.DateTime(2026, 1, 1, 0, 0, 0, 0);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(58, 60);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(183, 42);
            this.textBox1.TabIndex = 4;
            this.textBox1.Text = "Grilovačka";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 44F);
            this.label1.Location = new System.Drawing.Point(136, 215);
            this.label1.Margin = new System.Windows.Forms.Padding(0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 78);
            this.label1.TabIndex = 5;
            this.label1.Text = ":";
            // 
            // txtBoxMinuty
            // 
            this.txtBoxMinuty.BackColor = System.Drawing.SystemColors.Control;
            this.txtBoxMinuty.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBoxMinuty.Font = new System.Drawing.Font("Segoe UI", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtBoxMinuty.Location = new System.Drawing.Point(161, 215);
            this.txtBoxMinuty.Multiline = true;
            this.txtBoxMinuty.Name = "txtBoxMinuty";
            this.txtBoxMinuty.Size = new System.Drawing.Size(92, 96);
            this.txtBoxMinuty.TabIndex = 6;
            this.txtBoxMinuty.Text = "99";
            this.txtBoxMinuty.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // UdalostForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtBoxMinuty);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.dateTimePicker);
            this.Controls.Add(this.txtBoxHodiny);
            this.Controls.Add(this.label1);
            this.Name = "UdalostForm";
            this.Text = "UdalostForm";
            this.Load += new System.EventHandler(this.UdalostForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtBoxHodiny;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBoxMinuty;
    }
}
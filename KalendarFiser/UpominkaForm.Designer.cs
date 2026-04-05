namespace KalendarFiser
{
    partial class UpominkaForm
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
            this.txtBoxNazev = new System.Windows.Forms.TextBox();
            this.btnUloz = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBoxMinuty = new System.Windows.Forms.TextBox();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.txtBoxHodiny = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.checkBoxUpominka = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // txtBoxNazev
            // 
            this.txtBoxNazev.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBoxNazev.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxNazev.Location = new System.Drawing.Point(12, 39);
            this.txtBoxNazev.Multiline = true;
            this.txtBoxNazev.Name = "txtBoxNazev";
            this.txtBoxNazev.Size = new System.Drawing.Size(393, 37);
            this.txtBoxNazev.TabIndex = 1;
            // 
            // btnUloz
            // 
            this.btnUloz.BackColor = System.Drawing.Color.SeaGreen;
            this.btnUloz.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnUloz.FlatAppearance.BorderSize = 3;
            this.btnUloz.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Green;
            this.btnUloz.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnUloz.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUloz.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnUloz.ForeColor = System.Drawing.Color.White;
            this.btnUloz.Location = new System.Drawing.Point(12, 313);
            this.btnUloz.Name = "btnUloz";
            this.btnUloz.Size = new System.Drawing.Size(393, 53);
            this.btnUloz.TabIndex = 8;
            this.btnUloz.Text = "Uložit upomínku";
            this.btnUloz.UseVisualStyleBackColor = false;
            this.btnUloz.Click += new System.EventHandler(this.BtnUloz_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(12, 129);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(130, 25);
            this.label3.TabIndex = 3;
            this.label3.Text = "Čas upomínky";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(12, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(136, 25);
            this.label2.TabIndex = 0;
            this.label2.Text = "Název události";
            // 
            // txtBoxMinuty
            // 
            this.txtBoxMinuty.BackColor = System.Drawing.Color.White;
            this.txtBoxMinuty.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBoxMinuty.Font = new System.Drawing.Font("Segoe UI", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtBoxMinuty.Location = new System.Drawing.Point(147, 198);
            this.txtBoxMinuty.MaxLength = 2;
            this.txtBoxMinuty.Multiline = true;
            this.txtBoxMinuty.Name = "txtBoxMinuty";
            this.txtBoxMinuty.Size = new System.Drawing.Size(92, 96);
            this.txtBoxMinuty.TabIndex = 7;
            this.txtBoxMinuty.Text = "30";
            this.txtBoxMinuty.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.CalendarFont = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.dateTimePicker.Font = new System.Drawing.Font("Segoe UI", 15.75F);
            this.dateTimePicker.Location = new System.Drawing.Point(12, 157);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(393, 35);
            this.dateTimePicker.TabIndex = 4;
            this.dateTimePicker.Value = new System.DateTime(2026, 1, 1, 0, 0, 0, 0);
            // 
            // txtBoxHodiny
            // 
            this.txtBoxHodiny.BackColor = System.Drawing.Color.White;
            this.txtBoxHodiny.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBoxHodiny.Font = new System.Drawing.Font("Segoe UI", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtBoxHodiny.Location = new System.Drawing.Point(12, 198);
            this.txtBoxHodiny.MaxLength = 2;
            this.txtBoxHodiny.Multiline = true;
            this.txtBoxHodiny.Name = "txtBoxHodiny";
            this.txtBoxHodiny.Size = new System.Drawing.Size(92, 96);
            this.txtBoxHodiny.TabIndex = 5;
            this.txtBoxHodiny.Text = "13";
            this.txtBoxHodiny.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 44F);
            this.label1.Location = new System.Drawing.Point(107, 198);
            this.label1.Margin = new System.Windows.Forms.Padding(0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 78);
            this.label1.TabIndex = 6;
            this.label1.Text = ":";
            // 
            // checkBoxUpominka
            // 
            this.checkBoxUpominka.AutoSize = true;
            this.checkBoxUpominka.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.checkBoxUpominka.Location = new System.Drawing.Point(130, 82);
            this.checkBoxUpominka.Name = "checkBoxUpominka";
            this.checkBoxUpominka.Size = new System.Drawing.Size(168, 34);
            this.checkBoxUpominka.TabIndex = 2;
            this.checkBoxUpominka.Text = "Bez upomínky";
            this.checkBoxUpominka.UseVisualStyleBackColor = true;
            this.checkBoxUpominka.CheckedChanged += new System.EventHandler(this.CheckBoxUpominka_CheckedChanged);
            // 
            // UpominkaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(417, 378);
            this.Controls.Add(this.checkBoxUpominka);
            this.Controls.Add(this.txtBoxNazev);
            this.Controls.Add(this.btnUloz);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtBoxMinuty);
            this.Controls.Add(this.dateTimePicker);
            this.Controls.Add(this.txtBoxHodiny);
            this.Controls.Add(this.label1);
            this.Name = "UpominkaForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Upomínka";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBoxNazev;
        private System.Windows.Forms.Button btnUloz;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBoxMinuty;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.TextBox txtBoxHodiny;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox checkBoxUpominka;
    }
}
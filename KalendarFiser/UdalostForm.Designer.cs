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
            this.txtBoxPopis = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBoxMinuty = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnUloz = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtBoxNazev = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtBoxHodiny
            // 
            this.txtBoxHodiny.BackColor = System.Drawing.Color.White;
            this.txtBoxHodiny.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBoxHodiny.Font = new System.Drawing.Font("Segoe UI", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtBoxHodiny.Location = new System.Drawing.Point(12, 283);
            this.txtBoxHodiny.MaxLength = 2;
            this.txtBoxHodiny.Multiline = true;
            this.txtBoxHodiny.Name = "txtBoxHodiny";
            this.txtBoxHodiny.Size = new System.Drawing.Size(92, 96);
            this.txtBoxHodiny.TabIndex = 6;
            this.txtBoxHodiny.Text = "13";
            this.txtBoxHodiny.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.CalendarFont = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.dateTimePicker.Font = new System.Drawing.Font("Segoe UI", 15.75F);
            this.dateTimePicker.Location = new System.Drawing.Point(12, 242);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(388, 35);
            this.dateTimePicker.TabIndex = 5;
            this.dateTimePicker.Value = new System.DateTime(2026, 1, 1, 0, 0, 0, 0);
            // 
            // txtBoxPopis
            // 
            this.txtBoxPopis.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBoxPopis.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxPopis.Location = new System.Drawing.Point(12, 119);
            this.txtBoxPopis.Multiline = true;
            this.txtBoxPopis.Name = "txtBoxPopis";
            this.txtBoxPopis.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtBoxPopis.Size = new System.Drawing.Size(388, 71);
            this.txtBoxPopis.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 44F);
            this.label1.Location = new System.Drawing.Point(107, 283);
            this.label1.Margin = new System.Windows.Forms.Padding(0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 78);
            this.label1.TabIndex = 7;
            this.label1.Text = ":";
            // 
            // txtBoxMinuty
            // 
            this.txtBoxMinuty.BackColor = System.Drawing.Color.White;
            this.txtBoxMinuty.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBoxMinuty.Font = new System.Drawing.Font("Segoe UI", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtBoxMinuty.Location = new System.Drawing.Point(147, 283);
            this.txtBoxMinuty.MaxLength = 2;
            this.txtBoxMinuty.Multiline = true;
            this.txtBoxMinuty.Name = "txtBoxMinuty";
            this.txtBoxMinuty.Size = new System.Drawing.Size(92, 96);
            this.txtBoxMinuty.TabIndex = 8;
            this.txtBoxMinuty.Text = "30";
            this.txtBoxMinuty.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(136, 25);
            this.label2.TabIndex = 0;
            this.label2.Text = "Název události";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(12, 214);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "Čas události";
            // 
            // btnUloz
            // 
            this.btnUloz.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnUloz.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnUloz.FlatAppearance.BorderSize = 3;
            this.btnUloz.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SteelBlue;
            this.btnUloz.FlatAppearance.MouseOverBackColor = System.Drawing.Color.RoyalBlue;
            this.btnUloz.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUloz.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnUloz.ForeColor = System.Drawing.Color.White;
            this.btnUloz.Location = new System.Drawing.Point(12, 401);
            this.btnUloz.Name = "btnUloz";
            this.btnUloz.Size = new System.Drawing.Size(388, 53);
            this.btnUloz.TabIndex = 9;
            this.btnUloz.Text = "Uložit událost";
            this.btnUloz.UseVisualStyleBackColor = false;
            this.btnUloz.Click += new System.EventHandler(this.BtnUloz_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(12, 91);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(129, 25);
            this.label4.TabIndex = 2;
            this.label4.Text = "Popis události";
            // 
            // txtBoxNazev
            // 
            this.txtBoxNazev.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBoxNazev.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxNazev.Location = new System.Drawing.Point(12, 37);
            this.txtBoxNazev.Multiline = true;
            this.txtBoxNazev.Name = "txtBoxNazev";
            this.txtBoxNazev.Size = new System.Drawing.Size(388, 37);
            this.txtBoxNazev.TabIndex = 1;
            // 
            // UdalostForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(417, 466);
            this.Controls.Add(this.txtBoxNazev);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnUloz);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtBoxMinuty);
            this.Controls.Add(this.txtBoxPopis);
            this.Controls.Add(this.dateTimePicker);
            this.Controls.Add(this.txtBoxHodiny);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "UdalostForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Událost: ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtBoxHodiny;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.TextBox txtBoxPopis;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBoxMinuty;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnUloz;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtBoxNazev;
    }
}
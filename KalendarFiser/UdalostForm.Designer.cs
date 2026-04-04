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
            this.txtBoxNazev = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBoxMinuty = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnUloz = new System.Windows.Forms.Button();
            this.btnSmazat = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtBoxHodiny
            // 
            this.txtBoxHodiny.BackColor = System.Drawing.Color.White;
            this.txtBoxHodiny.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBoxHodiny.Font = new System.Drawing.Font("Segoe UI", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtBoxHodiny.Location = new System.Drawing.Point(17, 200);
            this.txtBoxHodiny.MaxLength = 2;
            this.txtBoxHodiny.Multiline = true;
            this.txtBoxHodiny.Name = "txtBoxHodiny";
            this.txtBoxHodiny.Size = new System.Drawing.Size(92, 96);
            this.txtBoxHodiny.TabIndex = 4;
            this.txtBoxHodiny.Text = "99";
            this.txtBoxHodiny.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtBoxHodiny.TextChanged += new System.EventHandler(this.KontrolaTxtBoxHodinyMinuty);
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.CalendarFont = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.dateTimePicker.Font = new System.Drawing.Font("Segoe UI", 15.75F);
            this.dateTimePicker.Location = new System.Drawing.Point(17, 159);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(388, 35);
            this.dateTimePicker.TabIndex = 1;
            this.dateTimePicker.Value = new System.DateTime(2026, 1, 1, 0, 0, 0, 0);
            // 
            // txtBoxNazev
            // 
            this.txtBoxNazev.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBoxNazev.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxNazev.Location = new System.Drawing.Point(17, 37);
            this.txtBoxNazev.Multiline = true;
            this.txtBoxNazev.Name = "txtBoxNazev";
            this.txtBoxNazev.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtBoxNazev.Size = new System.Drawing.Size(388, 71);
            this.txtBoxNazev.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 44F);
            this.label1.Location = new System.Drawing.Point(112, 200);
            this.label1.Margin = new System.Windows.Forms.Padding(0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 78);
            this.label1.TabIndex = 6;
            this.label1.Text = ":";
            // 
            // txtBoxMinuty
            // 
            this.txtBoxMinuty.BackColor = System.Drawing.Color.White;
            this.txtBoxMinuty.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBoxMinuty.Font = new System.Drawing.Font("Segoe UI", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtBoxMinuty.Location = new System.Drawing.Point(152, 200);
            this.txtBoxMinuty.MaxLength = 2;
            this.txtBoxMinuty.Multiline = true;
            this.txtBoxMinuty.Name = "txtBoxMinuty";
            this.txtBoxMinuty.Size = new System.Drawing.Size(92, 96);
            this.txtBoxMinuty.TabIndex = 5;
            this.txtBoxMinuty.Text = "99";
            this.txtBoxMinuty.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtBoxMinuty.TextChanged += new System.EventHandler(this.KontrolaTxtBoxHodinyMinuty);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(136, 25);
            this.label2.TabIndex = 7;
            this.label2.Text = "Název události";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(12, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(130, 25);
            this.label3.TabIndex = 8;
            this.label3.Text = "Čas upomínky";
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
            this.btnUloz.Location = new System.Drawing.Point(17, 307);
            this.btnUloz.Name = "btnUloz";
            this.btnUloz.Size = new System.Drawing.Size(264, 53);
            this.btnUloz.TabIndex = 9;
            this.btnUloz.Text = "Uložit událost";
            this.btnUloz.UseVisualStyleBackColor = false;
            this.btnUloz.Click += new System.EventHandler(this.BtnUloz_Click);
            // 
            // btnSmazat
            // 
            this.btnSmazat.BackColor = System.Drawing.Color.Brown;
            this.btnSmazat.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnSmazat.FlatAppearance.BorderSize = 3;
            this.btnSmazat.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Firebrick;
            this.btnSmazat.FlatAppearance.MouseOverBackColor = System.Drawing.Color.IndianRed;
            this.btnSmazat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSmazat.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnSmazat.ForeColor = System.Drawing.Color.White;
            this.btnSmazat.Location = new System.Drawing.Point(287, 307);
            this.btnSmazat.Name = "btnSmazat";
            this.btnSmazat.Size = new System.Drawing.Size(118, 53);
            this.btnSmazat.TabIndex = 10;
            this.btnSmazat.Text = "Smazat";
            this.btnSmazat.UseVisualStyleBackColor = false;
            this.btnSmazat.Click += new System.EventHandler(this.BtnSmazat_Click);
            // 
            // UdalostForm
            // 
            this.AcceptButton = this.btnUloz;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(417, 372);
            this.Controls.Add(this.btnSmazat);
            this.Controls.Add(this.btnUloz);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtBoxMinuty);
            this.Controls.Add(this.txtBoxNazev);
            this.Controls.Add(this.dateTimePicker);
            this.Controls.Add(this.txtBoxHodiny);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "UdalostForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Událost: ";
            this.Load += new System.EventHandler(this.UdalostForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtBoxHodiny;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.TextBox txtBoxNazev;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBoxMinuty;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnUloz;
        private System.Windows.Forms.Button btnSmazat;
    }
}
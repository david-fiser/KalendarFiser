namespace KalendarFiser
{
    partial class DetailDneForm
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
            this.listBoxUdalosti = new System.Windows.Forms.ListBox();
            this.lblUdalostDne = new System.Windows.Forms.Label();
            this.btnSmazat = new System.Windows.Forms.Button();
            this.btnUpravitUdalost = new System.Windows.Forms.Button();
            this.btnUpravitUpominku = new System.Windows.Forms.Button();
            this.btnPridatUdalost = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBoxPoznamkaDne = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnUlozitPoznamkuDne = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBoxUdalosti
            // 
            this.listBoxUdalosti.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.listBoxUdalosti.FormattingEnabled = true;
            this.listBoxUdalosti.ItemHeight = 30;
            this.listBoxUdalosti.Location = new System.Drawing.Point(12, 37);
            this.listBoxUdalosti.Name = "listBoxUdalosti";
            this.listBoxUdalosti.Size = new System.Drawing.Size(272, 304);
            this.listBoxUdalosti.TabIndex = 2;
            // 
            // lblUdalostDne
            // 
            this.lblUdalostDne.AutoSize = true;
            this.lblUdalostDne.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblUdalostDne.Location = new System.Drawing.Point(12, 9);
            this.lblUdalostDne.Name = "lblUdalostDne";
            this.lblUdalostDne.Size = new System.Drawing.Size(123, 25);
            this.lblUdalostDne.TabIndex = 1;
            this.lblUdalostDne.Text = "Události dne ";
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
            this.btnSmazat.Location = new System.Drawing.Point(305, 288);
            this.btnSmazat.Name = "btnSmazat";
            this.btnSmazat.Size = new System.Drawing.Size(264, 53);
            this.btnSmazat.TabIndex = 6;
            this.btnSmazat.Text = "Smazat";
            this.btnSmazat.UseVisualStyleBackColor = false;
            this.btnSmazat.Click += new System.EventHandler(this.BtnSmazat_Click);
            // 
            // btnUpravitUdalost
            // 
            this.btnUpravitUdalost.BackColor = System.Drawing.Color.Peru;
            this.btnUpravitUdalost.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnUpravitUdalost.FlatAppearance.BorderSize = 3;
            this.btnUpravitUdalost.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Chocolate;
            this.btnUpravitUdalost.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkOrange;
            this.btnUpravitUdalost.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpravitUdalost.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnUpravitUdalost.ForeColor = System.Drawing.Color.White;
            this.btnUpravitUdalost.Location = new System.Drawing.Point(305, 229);
            this.btnUpravitUdalost.Name = "btnUpravitUdalost";
            this.btnUpravitUdalost.Size = new System.Drawing.Size(264, 53);
            this.btnUpravitUdalost.TabIndex = 5;
            this.btnUpravitUdalost.Text = "Upravit událost";
            this.btnUpravitUdalost.UseVisualStyleBackColor = false;
            this.btnUpravitUdalost.Click += new System.EventHandler(this.BtnUpravitUdalost_Click);
            // 
            // btnUpravitUpominku
            // 
            this.btnUpravitUpominku.BackColor = System.Drawing.Color.SeaGreen;
            this.btnUpravitUpominku.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnUpravitUpominku.FlatAppearance.BorderSize = 3;
            this.btnUpravitUpominku.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Green;
            this.btnUpravitUpominku.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnUpravitUpominku.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpravitUpominku.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnUpravitUpominku.ForeColor = System.Drawing.Color.White;
            this.btnUpravitUpominku.Location = new System.Drawing.Point(305, 170);
            this.btnUpravitUpominku.Name = "btnUpravitUpominku";
            this.btnUpravitUpominku.Size = new System.Drawing.Size(264, 53);
            this.btnUpravitUpominku.TabIndex = 4;
            this.btnUpravitUpominku.Text = "Upravit upomínku";
            this.btnUpravitUpominku.UseVisualStyleBackColor = false;
            this.btnUpravitUpominku.Click += new System.EventHandler(this.BtnUpravitUpominku_Click);
            // 
            // btnPridatUdalost
            // 
            this.btnPridatUdalost.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnPridatUdalost.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnPridatUdalost.FlatAppearance.BorderSize = 3;
            this.btnPridatUdalost.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SteelBlue;
            this.btnPridatUdalost.FlatAppearance.MouseOverBackColor = System.Drawing.Color.RoyalBlue;
            this.btnPridatUdalost.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPridatUdalost.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnPridatUdalost.ForeColor = System.Drawing.Color.White;
            this.btnPridatUdalost.Location = new System.Drawing.Point(305, 37);
            this.btnPridatUdalost.Name = "btnPridatUdalost";
            this.btnPridatUdalost.Size = new System.Drawing.Size(264, 66);
            this.btnPridatUdalost.TabIndex = 0;
            this.btnPridatUdalost.Text = "Přidat událost";
            this.btnPridatUdalost.UseVisualStyleBackColor = false;
            this.btnPridatUdalost.Click += new System.EventHandler(this.BtnPridatUdalost_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(302, 150);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(247, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Vyberte událost ze seznamu a zvlote akci";
            // 
            // txtBoxPoznamkaDne
            // 
            this.txtBoxPoznamkaDne.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBoxPoznamkaDne.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtBoxPoznamkaDne.Location = new System.Drawing.Point(12, 372);
            this.txtBoxPoznamkaDne.Multiline = true;
            this.txtBoxPoznamkaDne.Name = "txtBoxPoznamkaDne";
            this.txtBoxPoznamkaDne.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtBoxPoznamkaDne.Size = new System.Drawing.Size(422, 53);
            this.txtBoxPoznamkaDne.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(12, 352);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 17);
            this.label2.TabIndex = 8;
            this.label2.Text = "Poznámka dne";
            // 
            // btnUlozitPoznamkuDne
            // 
            this.btnUlozitPoznamkuDne.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnUlozitPoznamkuDne.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnUlozitPoznamkuDne.FlatAppearance.BorderSize = 3;
            this.btnUlozitPoznamkuDne.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SteelBlue;
            this.btnUlozitPoznamkuDne.FlatAppearance.MouseOverBackColor = System.Drawing.Color.RoyalBlue;
            this.btnUlozitPoznamkuDne.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUlozitPoznamkuDne.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnUlozitPoznamkuDne.ForeColor = System.Drawing.Color.White;
            this.btnUlozitPoznamkuDne.Location = new System.Drawing.Point(440, 372);
            this.btnUlozitPoznamkuDne.Name = "btnUlozitPoznamkuDne";
            this.btnUlozitPoznamkuDne.Size = new System.Drawing.Size(129, 53);
            this.btnUlozitPoznamkuDne.TabIndex = 9;
            this.btnUlozitPoznamkuDne.Text = "Uložit poznámku";
            this.btnUlozitPoznamkuDne.UseVisualStyleBackColor = false;
            this.btnUlozitPoznamkuDne.Click += new System.EventHandler(this.BtnUlozitPoznamkuDne_Click);
            // 
            // DetailDneForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(581, 437);
            this.Controls.Add(this.btnUlozitPoznamkuDne);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtBoxPoznamkaDne);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnPridatUdalost);
            this.Controls.Add(this.btnUpravitUpominku);
            this.Controls.Add(this.btnSmazat);
            this.Controls.Add(this.btnUpravitUdalost);
            this.Controls.Add(this.lblUdalostDne);
            this.Controls.Add(this.listBoxUdalosti);
            this.Name = "DetailDneForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Podrobnosti pro den ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxUdalosti;
        private System.Windows.Forms.Label lblUdalostDne;
        private System.Windows.Forms.Button btnSmazat;
        private System.Windows.Forms.Button btnUpravitUdalost;
        private System.Windows.Forms.Button btnUpravitUpominku;
        private System.Windows.Forms.Button btnPridatUdalost;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBoxPoznamkaDne;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnUlozitPoznamkuDne;
    }
}
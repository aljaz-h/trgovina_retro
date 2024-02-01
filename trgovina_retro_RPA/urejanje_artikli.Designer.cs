namespace trgovina_retro_RPA
{
    partial class urejanje_artikli
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
            this.btn_nazaj = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_shrani_A = new System.Windows.Forms.Button();
            this.comBox_kategorije_A = new System.Windows.Forms.ComboBox();
            this.lbl_kategorije_A = new System.Windows.Forms.Label();
            this.txtBox_zaloga_A = new System.Windows.Forms.TextBox();
            this.txtBox_cena_A = new System.Windows.Forms.TextBox();
            this.txtBox_ime_A = new System.Windows.Forms.TextBox();
            this.lbl_zaloga_A = new System.Windows.Forms.Label();
            this.lbl_cena_A = new System.Windows.Forms.Label();
            this.lbl_ime_A = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_nazaj
            // 
            this.btn_nazaj.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.142858F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_nazaj.Location = new System.Drawing.Point(22, 394);
            this.btn_nazaj.Name = "btn_nazaj";
            this.btn_nazaj.Size = new System.Drawing.Size(100, 50);
            this.btn_nazaj.TabIndex = 22;
            this.btn_nazaj.Text = "NAZAJ";
            this.btn_nazaj.UseVisualStyleBackColor = true;
            this.btn_nazaj.Click += new System.EventHandler(this.btn_nazaj_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.14286F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(28, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(364, 39);
            this.label1.TabIndex = 21;
            this.label1.Text = "UREJANJE ARTIKLA";
            // 
            // btn_shrani_A
            // 
            this.btn_shrani_A.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.142858F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_shrani_A.Location = new System.Drawing.Point(306, 394);
            this.btn_shrani_A.Name = "btn_shrani_A";
            this.btn_shrani_A.Size = new System.Drawing.Size(100, 50);
            this.btn_shrani_A.TabIndex = 20;
            this.btn_shrani_A.Text = "SHRANI";
            this.btn_shrani_A.UseVisualStyleBackColor = true;
            this.btn_shrani_A.Click += new System.EventHandler(this.btn_shrani_A_Click);
            // 
            // comBox_kategorije_A
            // 
            this.comBox_kategorije_A.FormattingEnabled = true;
            this.comBox_kategorije_A.Items.AddRange(new object[] {
            "igra",
            "konzola",
            "kontroler",
            "ostalo"});
            this.comBox_kategorije_A.Location = new System.Drawing.Point(190, 295);
            this.comBox_kategorije_A.Name = "comBox_kategorije_A";
            this.comBox_kategorije_A.Size = new System.Drawing.Size(150, 32);
            this.comBox_kategorije_A.TabIndex = 19;
            // 
            // lbl_kategorije_A
            // 
            this.lbl_kategorije_A.AutoSize = true;
            this.lbl_kategorije_A.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_kategorije_A.Location = new System.Drawing.Point(20, 297);
            this.lbl_kategorije_A.Name = "lbl_kategorije_A";
            this.lbl_kategorije_A.Size = new System.Drawing.Size(152, 32);
            this.lbl_kategorije_A.TabIndex = 18;
            this.lbl_kategorije_A.Text = "Kategorije:";
            // 
            // txtBox_zaloga_A
            // 
            this.txtBox_zaloga_A.Location = new System.Drawing.Point(143, 255);
            this.txtBox_zaloga_A.Name = "txtBox_zaloga_A";
            this.txtBox_zaloga_A.Size = new System.Drawing.Size(83, 29);
            this.txtBox_zaloga_A.TabIndex = 17;
            // 
            // txtBox_cena_A
            // 
            this.txtBox_cena_A.Location = new System.Drawing.Point(121, 208);
            this.txtBox_cena_A.Name = "txtBox_cena_A";
            this.txtBox_cena_A.Size = new System.Drawing.Size(80, 29);
            this.txtBox_cena_A.TabIndex = 16;
            // 
            // txtBox_ime_A
            // 
            this.txtBox_ime_A.Location = new System.Drawing.Point(98, 159);
            this.txtBox_ime_A.Name = "txtBox_ime_A";
            this.txtBox_ime_A.Size = new System.Drawing.Size(173, 29);
            this.txtBox_ime_A.TabIndex = 15;
            // 
            // lbl_zaloga_A
            // 
            this.lbl_zaloga_A.AutoSize = true;
            this.lbl_zaloga_A.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_zaloga_A.Location = new System.Drawing.Point(20, 252);
            this.lbl_zaloga_A.Name = "lbl_zaloga_A";
            this.lbl_zaloga_A.Size = new System.Drawing.Size(110, 32);
            this.lbl_zaloga_A.TabIndex = 14;
            this.lbl_zaloga_A.Text = "Zaloga:";
            // 
            // lbl_cena_A
            // 
            this.lbl_cena_A.AutoSize = true;
            this.lbl_cena_A.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_cena_A.Location = new System.Drawing.Point(20, 204);
            this.lbl_cena_A.Name = "lbl_cena_A";
            this.lbl_cena_A.Size = new System.Drawing.Size(90, 32);
            this.lbl_cena_A.TabIndex = 13;
            this.lbl_cena_A.Text = "Cena:";
            // 
            // lbl_ime_A
            // 
            this.lbl_ime_A.AutoSize = true;
            this.lbl_ime_A.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ime_A.Location = new System.Drawing.Point(20, 156);
            this.lbl_ime_A.Name = "lbl_ime_A";
            this.lbl_ime_A.Size = new System.Drawing.Size(68, 32);
            this.lbl_ime_A.TabIndex = 12;
            this.lbl_ime_A.Text = "Ime:";
            // 
            // urejanje_artikli
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(421, 462);
            this.Controls.Add(this.btn_nazaj);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_shrani_A);
            this.Controls.Add(this.comBox_kategorije_A);
            this.Controls.Add(this.lbl_kategorije_A);
            this.Controls.Add(this.txtBox_zaloga_A);
            this.Controls.Add(this.txtBox_cena_A);
            this.Controls.Add(this.txtBox_ime_A);
            this.Controls.Add(this.lbl_zaloga_A);
            this.Controls.Add(this.lbl_cena_A);
            this.Controls.Add(this.lbl_ime_A);
            this.Name = "urejanje_artikli";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "urejanje_artikli";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_nazaj;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_shrani_A;
        private System.Windows.Forms.ComboBox comBox_kategorije_A;
        private System.Windows.Forms.Label lbl_kategorije_A;
        private System.Windows.Forms.TextBox txtBox_zaloga_A;
        private System.Windows.Forms.TextBox txtBox_cena_A;
        private System.Windows.Forms.TextBox txtBox_ime_A;
        private System.Windows.Forms.Label lbl_zaloga_A;
        private System.Windows.Forms.Label lbl_cena_A;
        private System.Windows.Forms.Label lbl_ime_A;
    }
}
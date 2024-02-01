namespace trgovina_retro_RPA
{
    partial class prijava
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtBox_geslo = new System.Windows.Forms.TextBox();
            this.txtBox_upime = new System.Windows.Forms.TextBox();
            this.lbl_cena_A = new System.Windows.Forms.Label();
            this.lbl_upime = new System.Windows.Forms.Label();
            this.btn_nazaj = new System.Windows.Forms.Button();
            this.btn_prijavi = new System.Windows.Forms.Button();
            this.btn_registracija = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.14286F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(128, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(168, 39);
            this.label1.TabIndex = 12;
            this.label1.Text = "PRIJAVA";
            // 
            // txtBox_geslo
            // 
            this.txtBox_geslo.Location = new System.Drawing.Point(253, 165);
            this.txtBox_geslo.Name = "txtBox_geslo";
            this.txtBox_geslo.PasswordChar = '*';
            this.txtBox_geslo.Size = new System.Drawing.Size(173, 29);
            this.txtBox_geslo.TabIndex = 16;
            // 
            // txtBox_upime
            // 
            this.txtBox_upime.Location = new System.Drawing.Point(253, 118);
            this.txtBox_upime.Name = "txtBox_upime";
            this.txtBox_upime.Size = new System.Drawing.Size(173, 29);
            this.txtBox_upime.TabIndex = 15;
            // 
            // lbl_cena_A
            // 
            this.lbl_cena_A.AutoSize = true;
            this.lbl_cena_A.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_cena_A.Location = new System.Drawing.Point(150, 165);
            this.lbl_cena_A.Name = "lbl_cena_A";
            this.lbl_cena_A.Size = new System.Drawing.Size(97, 32);
            this.lbl_cena_A.TabIndex = 14;
            this.lbl_cena_A.Text = "Geslo:";
            // 
            // lbl_upime
            // 
            this.lbl_upime.AutoSize = true;
            this.lbl_upime.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_upime.Location = new System.Drawing.Point(12, 114);
            this.lbl_upime.Name = "lbl_upime";
            this.lbl_upime.Size = new System.Drawing.Size(235, 32);
            this.lbl_upime.TabIndex = 13;
            this.lbl_upime.Text = "Uporabniško ime:";
            // 
            // btn_nazaj
            // 
            this.btn_nazaj.Location = new System.Drawing.Point(117, 378);
            this.btn_nazaj.Name = "btn_nazaj";
            this.btn_nazaj.Size = new System.Drawing.Size(200, 60);
            this.btn_nazaj.TabIndex = 17;
            this.btn_nazaj.Text = "ZAPRI";
            this.btn_nazaj.UseVisualStyleBackColor = true;
            this.btn_nazaj.Click += new System.EventHandler(this.btn_nazaj_Click);
            // 
            // btn_prijavi
            // 
            this.btn_prijavi.Location = new System.Drawing.Point(117, 246);
            this.btn_prijavi.Name = "btn_prijavi";
            this.btn_prijavi.Size = new System.Drawing.Size(200, 60);
            this.btn_prijavi.TabIndex = 18;
            this.btn_prijavi.Text = "PRIJAVI";
            this.btn_prijavi.UseVisualStyleBackColor = true;
            this.btn_prijavi.Click += new System.EventHandler(this.btn_prijavi_Click);
            // 
            // btn_registracija
            // 
            this.btn_registracija.Location = new System.Drawing.Point(117, 312);
            this.btn_registracija.Name = "btn_registracija";
            this.btn_registracija.Size = new System.Drawing.Size(200, 60);
            this.btn_registracija.TabIndex = 19;
            this.btn_registracija.Text = "REGISTRACIJA";
            this.btn_registracija.UseVisualStyleBackColor = true;
            this.btn_registracija.Click += new System.EventHandler(this.btn_registracija_Click);
            // 
            // prijava
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(447, 450);
            this.Controls.Add(this.btn_registracija);
            this.Controls.Add(this.btn_prijavi);
            this.Controls.Add(this.btn_nazaj);
            this.Controls.Add(this.txtBox_geslo);
            this.Controls.Add(this.txtBox_upime);
            this.Controls.Add(this.lbl_cena_A);
            this.Controls.Add(this.lbl_upime);
            this.Controls.Add(this.label1);
            this.Name = "prijava";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "prijava";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBox_geslo;
        private System.Windows.Forms.TextBox txtBox_upime;
        private System.Windows.Forms.Label lbl_cena_A;
        private System.Windows.Forms.Label lbl_upime;
        private System.Windows.Forms.Button btn_nazaj;
        private System.Windows.Forms.Button btn_prijavi;
        private System.Windows.Forms.Button btn_registracija;
    }
}
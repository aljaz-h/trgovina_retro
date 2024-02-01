namespace trgovina_retro_RPA
{
    partial class artikli
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
            this.btn_home = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.btn_izbrisi = new System.Windows.Forms.Button();
            this.btn_pdf = new System.Windows.Forms.Button();
            this.btn_uredi = new System.Windows.Forms.Button();
            this.btn_dodaj = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.14286F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 39);
            this.label1.TabIndex = 11;
            this.label1.Text = "ARTIKLI";
            // 
            // btn_home
            // 
            this.btn_home.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.142858F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_home.Location = new System.Drawing.Point(12, 388);
            this.btn_home.Name = "btn_home";
            this.btn_home.Size = new System.Drawing.Size(100, 50);
            this.btn_home.TabIndex = 13;
            this.btn_home.Text = "DOMOV";
            this.btn_home.UseVisualStyleBackColor = true;
            this.btn_home.Click += new System.EventHandler(this.btn_home_Click);
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(12, 101);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(628, 260);
            this.listView1.TabIndex = 14;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // btn_izbrisi
            // 
            this.btn_izbrisi.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.142858F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_izbrisi.Location = new System.Drawing.Point(328, 388);
            this.btn_izbrisi.Name = "btn_izbrisi";
            this.btn_izbrisi.Size = new System.Drawing.Size(100, 50);
            this.btn_izbrisi.TabIndex = 17;
            this.btn_izbrisi.Text = "IZBRISI";
            this.btn_izbrisi.UseVisualStyleBackColor = true;
            this.btn_izbrisi.Click += new System.EventHandler(this.btn_izbrisi_Click);
            // 
            // btn_pdf
            // 
            this.btn_pdf.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.142858F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_pdf.Location = new System.Drawing.Point(118, 388);
            this.btn_pdf.Name = "btn_pdf";
            this.btn_pdf.Size = new System.Drawing.Size(100, 50);
            this.btn_pdf.TabIndex = 16;
            this.btn_pdf.Text = "CSV";
            this.btn_pdf.UseVisualStyleBackColor = true;
            this.btn_pdf.Click += new System.EventHandler(this.btn_pdf_Click);
            // 
            // btn_uredi
            // 
            this.btn_uredi.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.142858F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_uredi.Location = new System.Drawing.Point(434, 388);
            this.btn_uredi.Name = "btn_uredi";
            this.btn_uredi.Size = new System.Drawing.Size(100, 50);
            this.btn_uredi.TabIndex = 15;
            this.btn_uredi.Text = "UREDI";
            this.btn_uredi.UseVisualStyleBackColor = true;
            this.btn_uredi.Click += new System.EventHandler(this.btn_uredi_Click);
            // 
            // btn_dodaj
            // 
            this.btn_dodaj.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.142858F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_dodaj.Location = new System.Drawing.Point(540, 388);
            this.btn_dodaj.Name = "btn_dodaj";
            this.btn_dodaj.Size = new System.Drawing.Size(100, 50);
            this.btn_dodaj.TabIndex = 12;
            this.btn_dodaj.Text = "DODAJ";
            this.btn_dodaj.UseVisualStyleBackColor = true;
            this.btn_dodaj.Click += new System.EventHandler(this.btn_dodaj_Click);
            // 
            // artikli
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(652, 450);
            this.Controls.Add(this.btn_izbrisi);
            this.Controls.Add(this.btn_pdf);
            this.Controls.Add(this.btn_uredi);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.btn_home);
            this.Controls.Add(this.btn_dodaj);
            this.Controls.Add(this.label1);
            this.Name = "artikli";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "artikli";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_dodaj;
        private System.Windows.Forms.Button btn_home;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Button btn_uredi;
        private System.Windows.Forms.Button btn_pdf;
        private System.Windows.Forms.Button btn_izbrisi;
    }
}
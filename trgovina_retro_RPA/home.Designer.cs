namespace trgovina_retro_RPA
{
    partial class home
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
            this.btn_artikli = new System.Windows.Forms.Button();
            this.btn_zapri = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_artikli
            // 
            this.btn_artikli.Location = new System.Drawing.Point(56, 137);
            this.btn_artikli.Name = "btn_artikli";
            this.btn_artikli.Size = new System.Drawing.Size(200, 60);
            this.btn_artikli.TabIndex = 0;
            this.btn_artikli.Text = "ARTIKLI";
            this.btn_artikli.UseVisualStyleBackColor = true;
            this.btn_artikli.Click += new System.EventHandler(this.btn_artikli_Click);
            // 
            // btn_zapri
            // 
            this.btn_zapri.Location = new System.Drawing.Point(56, 283);
            this.btn_zapri.Name = "btn_zapri";
            this.btn_zapri.Size = new System.Drawing.Size(200, 60);
            this.btn_zapri.TabIndex = 3;
            this.btn_zapri.Text = "ZAPRI";
            this.btn_zapri.UseVisualStyleBackColor = true;
            this.btn_zapri.Click += new System.EventHandler(this.btn_zapri_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.14286F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(52, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(204, 39);
            this.label1.TabIndex = 11;
            this.label1.Text = "TRGOVINA";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.14286F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(79, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(142, 39);
            this.label2.TabIndex = 12;
            this.label2.Text = "RETRO";
            // 
            // home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(311, 355);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_zapri);
            this.Controls.Add(this.btn_artikli);
            this.Name = "home";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Home";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_artikli;
        private System.Windows.Forms.Button btn_zapri;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}
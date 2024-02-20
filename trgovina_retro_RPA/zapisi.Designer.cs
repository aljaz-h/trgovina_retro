namespace trgovina_retro_RPA
{
    partial class zapisi
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
            this.listViewZapisi = new System.Windows.Forms.ListView();
            this.btn_nazaj = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listViewZapisi
            // 
            this.listViewZapisi.HideSelection = false;
            this.listViewZapisi.Location = new System.Drawing.Point(12, 59);
            this.listViewZapisi.Name = "listViewZapisi";
            this.listViewZapisi.Size = new System.Drawing.Size(588, 259);
            this.listViewZapisi.TabIndex = 0;
            this.listViewZapisi.UseCompatibleStateImageBehavior = false;
            // 
            // btn_nazaj
            // 
            this.btn_nazaj.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.142858F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_nazaj.Location = new System.Drawing.Point(500, 324);
            this.btn_nazaj.Name = "btn_nazaj";
            this.btn_nazaj.Size = new System.Drawing.Size(100, 50);
            this.btn_nazaj.TabIndex = 13;
            this.btn_nazaj.Text = "NAZAJ";
            this.btn_nazaj.UseVisualStyleBackColor = true;
            this.btn_nazaj.Click += new System.EventHandler(this.btn_nazaj_Click);
            // 
            // zapisi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(613, 386);
            this.Controls.Add(this.btn_nazaj);
            this.Controls.Add(this.listViewZapisi);
            this.Name = "zapisi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Zapisi";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listViewZapisi;
        private System.Windows.Forms.Button btn_nazaj;
    }
}
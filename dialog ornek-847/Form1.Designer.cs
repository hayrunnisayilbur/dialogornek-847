namespace dialog_ornek_847
{
    partial class Form1
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
            this.btnResim = new System.Windows.Forms.Button();
            this.btnRenk = new System.Windows.Forms.Button();
            this.pbResim = new System.Windows.Forms.PictureBox();
            this.rtbMesaj = new System.Windows.Forms.RichTextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            ((System.ComponentModel.ISupportInitialize)(this.pbResim)).BeginInit();
            this.SuspendLayout();
            // 
            // btnResim
            // 
            this.btnResim.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnResim.Location = new System.Drawing.Point(27, 148);
            this.btnResim.Name = "btnResim";
            this.btnResim.Size = new System.Drawing.Size(123, 37);
            this.btnResim.TabIndex = 0;
            this.btnResim.Text = "resim seç";
            this.btnResim.UseVisualStyleBackColor = true;
            this.btnResim.Click += new System.EventHandler(this.btnResim_Click);
            // 
            // btnRenk
            // 
            this.btnRenk.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnRenk.Location = new System.Drawing.Point(453, 149);
            this.btnRenk.Name = "btnRenk";
            this.btnRenk.Size = new System.Drawing.Size(128, 36);
            this.btnRenk.TabIndex = 1;
            this.btnRenk.Text = "renk değiştir";
            this.btnRenk.UseVisualStyleBackColor = true;
            this.btnRenk.Click += new System.EventHandler(this.btnRenk_Click);
            // 
            // pbResim
            // 
            this.pbResim.Location = new System.Drawing.Point(27, 210);
            this.pbResim.Name = "pbResim";
            this.pbResim.Size = new System.Drawing.Size(307, 207);
            this.pbResim.TabIndex = 2;
            this.pbResim.TabStop = false;
            // 
            // rtbMesaj
            // 
            this.rtbMesaj.Location = new System.Drawing.Point(453, 210);
            this.rtbMesaj.Name = "rtbMesaj";
            this.rtbMesaj.Size = new System.Drawing.Size(290, 199);
            this.rtbMesaj.TabIndex = 3;
            this.rtbMesaj.Text = "nisa\neymen\nefe\nkübra\nömer";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.rtbMesaj);
            this.Controls.Add(this.pbResim);
            this.Controls.Add(this.btnRenk);
            this.Controls.Add(this.btnResim);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pbResim)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnResim;
        private System.Windows.Forms.Button btnRenk;
        private System.Windows.Forms.PictureBox pbResim;
        private System.Windows.Forms.RichTextBox rtbMesaj;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ColorDialog colorDialog1;
    }
}


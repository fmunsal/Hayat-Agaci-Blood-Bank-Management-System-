
namespace hayatagaci
{
    partial class FrmKanMerAdmin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmKanMerAdmin));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnKanDetaylar = new System.Windows.Forms.Button();
            this.btnKanKanEkle = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtagaci = new System.Windows.Forms.Label();
            this.txtHayat = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnKapatma = new System.Windows.Forms.Button();
            this.mainpanel = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.btnKanDetaylar);
            this.panel1.Controls.Add(this.btnKanKanEkle);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.txtagaci);
            this.panel1.Controls.Add(this.txtHayat);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(309, 679);
            this.panel1.TabIndex = 9;
            // 
            // btnKanDetaylar
            // 
            this.btnKanDetaylar.FlatAppearance.BorderSize = 0;
            this.btnKanDetaylar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKanDetaylar.Font = new System.Drawing.Font("Constantia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKanDetaylar.ForeColor = System.Drawing.Color.White;
            this.btnKanDetaylar.Location = new System.Drawing.Point(0, 187);
            this.btnKanDetaylar.Margin = new System.Windows.Forms.Padding(4);
            this.btnKanDetaylar.Name = "btnKanDetaylar";
            this.btnKanDetaylar.Size = new System.Drawing.Size(309, 55);
            this.btnKanDetaylar.TabIndex = 8;
            this.btnKanDetaylar.Text = "PersonelEkle";
            this.btnKanDetaylar.UseVisualStyleBackColor = true;
            this.btnKanDetaylar.Click += new System.EventHandler(this.btnKanDetaylar_Click);
            // 
            // btnKanKanEkle
            // 
            this.btnKanKanEkle.FlatAppearance.BorderSize = 0;
            this.btnKanKanEkle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKanKanEkle.Font = new System.Drawing.Font("Constantia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKanKanEkle.ForeColor = System.Drawing.Color.White;
            this.btnKanKanEkle.Location = new System.Drawing.Point(0, 128);
            this.btnKanKanEkle.Margin = new System.Windows.Forms.Padding(4);
            this.btnKanKanEkle.Name = "btnKanKanEkle";
            this.btnKanKanEkle.Size = new System.Drawing.Size(309, 55);
            this.btnKanKanEkle.TabIndex = 8;
            this.btnKanKanEkle.Text = "Personeller";
            this.btnKanKanEkle.UseVisualStyleBackColor = true;
            this.btnKanKanEkle.Click += new System.EventHandler(this.btnKanKanEkle_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(241)))), ((int)(((byte)(242)))));
            this.panel2.Location = new System.Drawing.Point(16, 117);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(285, 6);
            this.panel2.TabIndex = 7;
            // 
            // txtagaci
            // 
            this.txtagaci.AutoSize = true;
            this.txtagaci.Font = new System.Drawing.Font("Century", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtagaci.ForeColor = System.Drawing.Color.White;
            this.txtagaci.Location = new System.Drawing.Point(157, 73);
            this.txtagaci.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txtagaci.Name = "txtagaci";
            this.txtagaci.Size = new System.Drawing.Size(132, 40);
            this.txtagaci.TabIndex = 6;
            this.txtagaci.Text = "AĞACI";
            // 
            // txtHayat
            // 
            this.txtHayat.AutoSize = true;
            this.txtHayat.Font = new System.Drawing.Font("Century", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtHayat.ForeColor = System.Drawing.Color.White;
            this.txtHayat.Location = new System.Drawing.Point(157, 34);
            this.txtHayat.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txtHayat.Name = "txtHayat";
            this.txtHayat.Size = new System.Drawing.Size(142, 40);
            this.txtHayat.TabIndex = 6;
            this.txtHayat.Text = "HAYAT";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::hayatagaci.Properties.Resources._34257;
            this.pictureBox1.Location = new System.Drawing.Point(31, 12);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(123, 97);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // btnKapatma
            // 
            this.btnKapatma.BackColor = System.Drawing.SystemColors.Control;
            this.btnKapatma.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnKapatma.FlatAppearance.BorderSize = 0;
            this.btnKapatma.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKapatma.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKapatma.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(37)))), ((int)(((byte)(58)))));
            this.btnKapatma.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnKapatma.Location = new System.Drawing.Point(1255, -10);
            this.btnKapatma.Margin = new System.Windows.Forms.Padding(0);
            this.btnKapatma.Name = "btnKapatma";
            this.btnKapatma.Size = new System.Drawing.Size(40, 37);
            this.btnKapatma.TabIndex = 10;
            this.btnKapatma.Text = "x";
            this.btnKapatma.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnKapatma.UseVisualStyleBackColor = false;
            this.btnKapatma.Click += new System.EventHandler(this.btnKapatma_Click);
            // 
            // mainpanel
            // 
            this.mainpanel.Location = new System.Drawing.Point(308, 0);
            this.mainpanel.Margin = new System.Windows.Forms.Padding(4);
            this.mainpanel.Name = "mainpanel";
            this.mainpanel.Size = new System.Drawing.Size(987, 676);
            this.mainpanel.TabIndex = 11;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(261, 634);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(45, 31);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 12;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // FrmKanMerAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1293, 677);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnKapatma);
            this.Controls.Add(this.mainpanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmKanMerAdmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmKanMerAdmin";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnKanDetaylar;
        private System.Windows.Forms.Button btnKanKanEkle;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label txtagaci;
        private System.Windows.Forms.Label txtHayat;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnKapatma;
        private System.Windows.Forms.Panel mainpanel;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}
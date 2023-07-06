
namespace hayatagaci
{
    partial class FrmKanIstek
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
            this.btnKanIste = new System.Windows.Forms.Button();
            this.cbIller = new System.Windows.Forms.ComboBox();
            this.cbIlceler = new System.Windows.Forms.ComboBox();
            this.lblAd = new System.Windows.Forms.Label();
            this.lblsoyad = new System.Windows.Forms.Label();
            this.lblkang = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.HastaId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.TC = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Isim = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Soyisim = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.KanG = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Cinsiyet = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Tel = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.DogumT = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.YatisT = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Hastalik = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.DogumY = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Boy = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Kilo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lblBekle = new System.Windows.Forms.Label();
            this.lblyer = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Sehir = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnKanIste
            // 
            this.btnKanIste.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(37)))), ((int)(((byte)(58)))));
            this.btnKanIste.FlatAppearance.BorderSize = 0;
            this.btnKanIste.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKanIste.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKanIste.ForeColor = System.Drawing.Color.White;
            this.btnKanIste.Location = new System.Drawing.Point(619, 553);
            this.btnKanIste.Margin = new System.Windows.Forms.Padding(4);
            this.btnKanIste.Name = "btnKanIste";
            this.btnKanIste.Size = new System.Drawing.Size(348, 79);
            this.btnKanIste.TabIndex = 1;
            this.btnKanIste.Text = "KAN ISTE";
            this.btnKanIste.UseVisualStyleBackColor = false;
            this.btnKanIste.Click += new System.EventHandler(this.btnKanIste_Click);
            // 
            // cbIller
            // 
            this.cbIller.FormattingEnabled = true;
            this.cbIller.Items.AddRange(new object[] {
            "Ankara",
            "Izmir",
            "Istanbul"});
            this.cbIller.Location = new System.Drawing.Point(404, 553);
            this.cbIller.Margin = new System.Windows.Forms.Padding(4);
            this.cbIller.Name = "cbIller";
            this.cbIller.Size = new System.Drawing.Size(191, 24);
            this.cbIller.TabIndex = 3;
            this.cbIller.SelectedIndexChanged += new System.EventHandler(this.cbIller_SelectedIndexChanged);
            this.cbIller.MouseClick += new System.Windows.Forms.MouseEventHandler(this.cbIller_MouseClick);
            // 
            // cbIlceler
            // 
            this.cbIlceler.Enabled = false;
            this.cbIlceler.FormattingEnabled = true;
            this.cbIlceler.Location = new System.Drawing.Point(404, 606);
            this.cbIlceler.Margin = new System.Windows.Forms.Padding(4);
            this.cbIlceler.Name = "cbIlceler";
            this.cbIlceler.Size = new System.Drawing.Size(191, 24);
            this.cbIlceler.TabIndex = 4;
            this.cbIlceler.SelectedIndexChanged += new System.EventHandler(this.cbIlceler_SelectedIndexChanged);
            // 
            // lblAd
            // 
            this.lblAd.AutoSize = true;
            this.lblAd.Location = new System.Drawing.Point(57, 0);
            this.lblAd.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAd.Name = "lblAd";
            this.lblAd.Size = new System.Drawing.Size(24, 17);
            this.lblAd.TabIndex = 5;
            this.lblAd.Text = "ad";
            this.lblAd.Visible = false;
            // 
            // lblsoyad
            // 
            this.lblsoyad.AutoSize = true;
            this.lblsoyad.Location = new System.Drawing.Point(57, 16);
            this.lblsoyad.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblsoyad.Name = "lblsoyad";
            this.lblsoyad.Size = new System.Drawing.Size(46, 17);
            this.lblsoyad.TabIndex = 5;
            this.lblsoyad.Text = "soyad";
            this.lblsoyad.Visible = false;
            // 
            // lblkang
            // 
            this.lblkang.AutoSize = true;
            this.lblkang.Location = new System.Drawing.Point(57, 46);
            this.lblkang.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblkang.Name = "lblkang";
            this.lblkang.Size = new System.Drawing.Size(68, 17);
            this.lblkang.TabIndex = 5;
            this.lblkang.Text = "kangrubu";
            this.lblkang.Visible = false;
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.HastaId,
            this.TC,
            this.Isim,
            this.Soyisim,
            this.KanG,
            this.Cinsiyet,
            this.Tel,
            this.DogumT,
            this.YatisT,
            this.Hastalik,
            this.DogumY,
            this.Boy,
            this.Kilo});
            this.listView1.ForeColor = System.Drawing.Color.Black;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(16, 36);
            this.listView1.Margin = new System.Windows.Forms.Padding(4);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(949, 484);
            this.listView1.TabIndex = 33;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            this.listView1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.listView1_MouseClick);
            // 
            // HastaId
            // 
            this.HastaId.Text = "HastaId";
            // 
            // TC
            // 
            this.TC.Text = "TC";
            this.TC.Width = 91;
            // 
            // Isim
            // 
            this.Isim.Text = "Isim";
            this.Isim.Width = 69;
            // 
            // Soyisim
            // 
            this.Soyisim.Text = "Soyisim";
            // 
            // KanG
            // 
            this.KanG.Text = "KanG";
            // 
            // Cinsiyet
            // 
            this.Cinsiyet.Text = "Cinsiyet";
            // 
            // Tel
            // 
            this.Tel.Text = "Tel.";
            // 
            // DogumT
            // 
            this.DogumT.Text = "DogumT";
            // 
            // YatisT
            // 
            this.YatisT.Text = "YatisT";
            // 
            // Hastalik
            // 
            this.Hastalik.Text = "Hastalik";
            // 
            // DogumY
            // 
            this.DogumY.Text = "DogumY";
            // 
            // Boy
            // 
            this.Boy.Text = "Boy";
            // 
            // Kilo
            // 
            this.Kilo.Text = "Kilo";
            // 
            // lblBekle
            // 
            this.lblBekle.AutoSize = true;
            this.lblBekle.Location = new System.Drawing.Point(53, 81);
            this.lblBekle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBekle.Name = "lblBekle";
            this.lblBekle.Size = new System.Drawing.Size(82, 17);
            this.lblBekle.TabIndex = 34;
            this.lblBekle.Text = "Bekleniyor..";
            this.lblBekle.Visible = false;
            // 
            // lblyer
            // 
            this.lblyer.AutoSize = true;
            this.lblyer.Location = new System.Drawing.Point(186, 63);
            this.lblyer.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblyer.Name = "lblyer";
            this.lblyer.Size = new System.Drawing.Size(42, 17);
            this.lblyer.TabIndex = 35;
            this.lblyer.Text = "lblyer";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.lblAd);
            this.panel1.Controls.Add(this.lblyer);
            this.panel1.Controls.Add(this.lblsoyad);
            this.panel1.Controls.Add(this.lblBekle);
            this.panel1.Controls.Add(this.lblkang);
            this.panel1.Location = new System.Drawing.Point(964, 660);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(10, 10);
            this.panel1.TabIndex = 36;
            // 
            // Sehir
            // 
            this.Sehir.AutoSize = true;
            this.Sehir.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Sehir.Location = new System.Drawing.Point(335, 556);
            this.Sehir.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Sehir.Name = "Sehir";
            this.Sehir.Size = new System.Drawing.Size(59, 24);
            this.Sehir.TabIndex = 37;
            this.Sehir.Text = "Sehir:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(269, 609);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 24);
            this.label1.TabIndex = 38;
            this.label1.Text = "Kan Merkezi:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::hayatagaci.Properties.Resources._34257;
            this.pictureBox1.Location = new System.Drawing.Point(-24, 577);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(311, 244);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 39;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(148, 127);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 17);
            this.label2.TabIndex = 40;
            this.label2.Text = "label2";
            // 
            // FrmKanIstek
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(987, 683);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Sehir);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.cbIlceler);
            this.Controls.Add(this.cbIller);
            this.Controls.Add(this.btnKanIste);
            this.Controls.Add(this.pictureBox1);
            this.ForeColor = System.Drawing.Color.Maroon;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmKanIstek";
            this.Text = "FrmKanIstek";
            this.Load += new System.EventHandler(this.FrmKanIstek_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnKanIste;
        private System.Windows.Forms.ComboBox cbIller;
        private System.Windows.Forms.ComboBox cbIlceler;
        private System.Windows.Forms.Label lblAd;
        private System.Windows.Forms.Label lblsoyad;
        private System.Windows.Forms.Label lblkang;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader HastaId;
        private System.Windows.Forms.ColumnHeader TC;
        private System.Windows.Forms.ColumnHeader Isim;
        private System.Windows.Forms.ColumnHeader Soyisim;
        private System.Windows.Forms.ColumnHeader KanG;
        private System.Windows.Forms.ColumnHeader Cinsiyet;
        private System.Windows.Forms.ColumnHeader Tel;
        private System.Windows.Forms.ColumnHeader DogumT;
        private System.Windows.Forms.ColumnHeader YatisT;
        private System.Windows.Forms.ColumnHeader Hastalik;
        private System.Windows.Forms.ColumnHeader DogumY;
        private System.Windows.Forms.ColumnHeader Boy;
        private System.Windows.Forms.ColumnHeader Kilo;
        private System.Windows.Forms.Label lblBekle;
        private System.Windows.Forms.Label lblyer;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label Sehir;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
    }
}
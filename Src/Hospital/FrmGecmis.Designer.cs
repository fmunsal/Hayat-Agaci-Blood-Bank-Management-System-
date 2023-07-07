
namespace hayatagaci
{
    partial class FrmGecmis
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
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblkanmerkez = new System.Windows.Forms.Label();
            this.lbliptal = new System.Windows.Forms.Label();
            this.lblHastane = new System.Windows.Forms.Label();
            this.lblDurum = new System.Windows.Forms.Label();
            this.lblTarih = new System.Windows.Forms.Label();
            this.lblKan = new System.Windows.Forms.Label();
            this.lblSoyisim = new System.Windows.Forms.Label();
            this.lblIsim = new System.Windows.Forms.Label();
            this.lblHastaId = new System.Windows.Forms.Label();
            this.lblId = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8,
            this.columnHeader9});
            this.listView1.Font = new System.Drawing.Font("Century", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(37, 89);
            this.listView1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(888, 426);
            this.listView1.TabIndex = 2;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            this.listView1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.listView1_MouseClick);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "ID";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Hasta ID";
            this.columnHeader2.Width = 92;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Isim";
            this.columnHeader5.Width = 106;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Soyisim";
            this.columnHeader6.Width = 106;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Istenilen Kan";
            this.columnHeader7.Width = 102;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Islem Tarihi";
            this.columnHeader8.Width = 103;
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "Istek Durumu";
            this.columnHeader9.Width = 128;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblkanmerkez);
            this.panel1.Controls.Add(this.lbliptal);
            this.panel1.Controls.Add(this.lblHastane);
            this.panel1.Controls.Add(this.lblDurum);
            this.panel1.Controls.Add(this.lblTarih);
            this.panel1.Controls.Add(this.lblKan);
            this.panel1.Controls.Add(this.lblSoyisim);
            this.panel1.Controls.Add(this.lblIsim);
            this.panel1.Controls.Add(this.lblHastaId);
            this.panel1.Controls.Add(this.lblId);
            this.panel1.Location = new System.Drawing.Point(16, 33);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(13, 12);
            this.panel1.TabIndex = 3;
            this.panel1.Visible = false;
            // 
            // lblkanmerkez
            // 
            this.lblkanmerkez.AutoSize = true;
            this.lblkanmerkez.Location = new System.Drawing.Point(412, 36);
            this.lblkanmerkez.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblkanmerkez.Name = "lblkanmerkez";
            this.lblkanmerkez.Size = new System.Drawing.Size(91, 17);
            this.lblkanmerkez.TabIndex = 9;
            this.lblkanmerkez.Text = "lblkanmerkez";
            // 
            // lbliptal
            // 
            this.lbliptal.AutoSize = true;
            this.lbliptal.Location = new System.Drawing.Point(319, 36);
            this.lbliptal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbliptal.Name = "lbliptal";
            this.lbliptal.Size = new System.Drawing.Size(84, 17);
            this.lbliptal.TabIndex = 8;
            this.lbliptal.Text = "Iptal Edildi...";
            // 
            // lblHastane
            // 
            this.lblHastane.AutoSize = true;
            this.lblHastane.Location = new System.Drawing.Point(193, 36);
            this.lblHastane.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblHastane.Name = "lblHastane";
            this.lblHastane.Size = new System.Drawing.Size(46, 17);
            this.lblHastane.TabIndex = 7;
            this.lblHastane.Text = "label9";
            // 
            // lblDurum
            // 
            this.lblDurum.AutoSize = true;
            this.lblDurum.Location = new System.Drawing.Point(193, 0);
            this.lblDurum.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDurum.Name = "lblDurum";
            this.lblDurum.Size = new System.Drawing.Size(46, 17);
            this.lblDurum.TabIndex = 6;
            this.lblDurum.Text = "label8";
            // 
            // lblTarih
            // 
            this.lblTarih.AutoSize = true;
            this.lblTarih.Location = new System.Drawing.Point(113, 74);
            this.lblTarih.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTarih.Name = "lblTarih";
            this.lblTarih.Size = new System.Drawing.Size(46, 17);
            this.lblTarih.TabIndex = 5;
            this.lblTarih.Text = "label7";
            // 
            // lblKan
            // 
            this.lblKan.AutoSize = true;
            this.lblKan.Location = new System.Drawing.Point(113, 36);
            this.lblKan.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblKan.Name = "lblKan";
            this.lblKan.Size = new System.Drawing.Size(46, 17);
            this.lblKan.TabIndex = 4;
            this.lblKan.Text = "label6";
            // 
            // lblSoyisim
            // 
            this.lblSoyisim.AutoSize = true;
            this.lblSoyisim.Location = new System.Drawing.Point(113, 0);
            this.lblSoyisim.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSoyisim.Name = "lblSoyisim";
            this.lblSoyisim.Size = new System.Drawing.Size(46, 17);
            this.lblSoyisim.TabIndex = 3;
            this.lblSoyisim.Text = "label5";
            // 
            // lblIsim
            // 
            this.lblIsim.AutoSize = true;
            this.lblIsim.Location = new System.Drawing.Point(17, 74);
            this.lblIsim.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblIsim.Name = "lblIsim";
            this.lblIsim.Size = new System.Drawing.Size(46, 17);
            this.lblIsim.TabIndex = 2;
            this.lblIsim.Text = "label4";
            // 
            // lblHastaId
            // 
            this.lblHastaId.AutoSize = true;
            this.lblHastaId.Location = new System.Drawing.Point(17, 36);
            this.lblHastaId.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblHastaId.Name = "lblHastaId";
            this.lblHastaId.Size = new System.Drawing.Size(46, 17);
            this.lblHastaId.TabIndex = 1;
            this.lblHastaId.Text = "label3";
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(17, 0);
            this.lblId.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(46, 17);
            this.lblId.TabIndex = 0;
            this.lblId.Text = "label2";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(37)))), ((int)(((byte)(58)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button1.Location = new System.Drawing.Point(695, 539);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(232, 73);
            this.button1.TabIndex = 4;
            this.button1.Text = "IptalEt";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Visible = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::hayatagaci.Properties.Resources._34257;
            this.pictureBox1.Location = new System.Drawing.Point(16, 496);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(955, 498);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(76, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "label1";
            // 
            // FrmGecmis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(987, 683);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FrmGecmis";
            this.Text = "FrmGecmis";
            this.Load += new System.EventHandler(this.FrmGecmis_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblkanmerkez;
        private System.Windows.Forms.Label lbliptal;
        private System.Windows.Forms.Label lblHastane;
        private System.Windows.Forms.Label lblDurum;
        private System.Windows.Forms.Label lblTarih;
        private System.Windows.Forms.Label lblKan;
        private System.Windows.Forms.Label lblSoyisim;
        private System.Windows.Forms.Label lblIsim;
        private System.Windows.Forms.Label lblHastaId;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
    }
}
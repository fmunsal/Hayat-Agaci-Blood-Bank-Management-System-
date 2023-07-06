
namespace hayatagaci
{
    partial class FrmKanBHastaneIstek
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
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader11 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblkanmerkez = new System.Windows.Forms.Label();
            this.lblgon = new System.Windows.Forms.Label();
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
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.label1.Location = new System.Drawing.Point(11, 23);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(315, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Hastane Istek Durumu";
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
            this.columnHeader9,
            this.columnHeader11});
            this.listView1.Font = new System.Drawing.Font("Century", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(15, 64);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(708, 370);
            this.listView1.TabIndex = 1;
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
            this.columnHeader5.Width = 84;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Soyisim";
            this.columnHeader6.Width = 89;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Istenilen Kan";
            this.columnHeader7.Width = 104;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Islem Tarihi";
            this.columnHeader8.Width = 103;
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "Istek Durumu";
            this.columnHeader9.Width = 97;
            // 
            // columnHeader11
            // 
            this.columnHeader11.Text = "Hastane";
            this.columnHeader11.Width = 101;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblkanmerkez);
            this.panel1.Controls.Add(this.lblgon);
            this.panel1.Controls.Add(this.lblHastane);
            this.panel1.Controls.Add(this.lblDurum);
            this.panel1.Controls.Add(this.lblTarih);
            this.panel1.Controls.Add(this.lblKan);
            this.panel1.Controls.Add(this.lblSoyisim);
            this.panel1.Controls.Add(this.lblIsim);
            this.panel1.Controls.Add(this.lblHastaId);
            this.panel1.Controls.Add(this.lblId);
            this.panel1.Location = new System.Drawing.Point(738, 533);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(10, 10);
            this.panel1.TabIndex = 2;
            this.panel1.Visible = false;
            // 
            // lblkanmerkez
            // 
            this.lblkanmerkez.AutoSize = true;
            this.lblkanmerkez.Location = new System.Drawing.Point(309, 29);
            this.lblkanmerkez.Name = "lblkanmerkez";
            this.lblkanmerkez.Size = new System.Drawing.Size(137, 23);
            this.lblkanmerkez.TabIndex = 9;
            this.lblkanmerkez.Text = "lblkanmerkez";
            // 
            // lblgon
            // 
            this.lblgon.AutoSize = true;
            this.lblgon.Location = new System.Drawing.Point(239, 29);
            this.lblgon.Name = "lblgon";
            this.lblgon.Size = new System.Drawing.Size(107, 23);
            this.lblgon.TabIndex = 8;
            this.lblgon.Text = "Gonderildi";
            // 
            // lblHastane
            // 
            this.lblHastane.AutoSize = true;
            this.lblHastane.Location = new System.Drawing.Point(145, 29);
            this.lblHastane.Name = "lblHastane";
            this.lblHastane.Size = new System.Drawing.Size(65, 23);
            this.lblHastane.TabIndex = 7;
            this.lblHastane.Text = "label9";
            // 
            // lblDurum
            // 
            this.lblDurum.AutoSize = true;
            this.lblDurum.Location = new System.Drawing.Point(145, 0);
            this.lblDurum.Name = "lblDurum";
            this.lblDurum.Size = new System.Drawing.Size(65, 23);
            this.lblDurum.TabIndex = 6;
            this.lblDurum.Text = "label8";
            // 
            // lblTarih
            // 
            this.lblTarih.AutoSize = true;
            this.lblTarih.Location = new System.Drawing.Point(85, 60);
            this.lblTarih.Name = "lblTarih";
            this.lblTarih.Size = new System.Drawing.Size(65, 23);
            this.lblTarih.TabIndex = 5;
            this.lblTarih.Text = "label7";
            // 
            // lblKan
            // 
            this.lblKan.AutoSize = true;
            this.lblKan.Location = new System.Drawing.Point(85, 29);
            this.lblKan.Name = "lblKan";
            this.lblKan.Size = new System.Drawing.Size(65, 23);
            this.lblKan.TabIndex = 4;
            this.lblKan.Text = "label6";
            // 
            // lblSoyisim
            // 
            this.lblSoyisim.AutoSize = true;
            this.lblSoyisim.Location = new System.Drawing.Point(85, 0);
            this.lblSoyisim.Name = "lblSoyisim";
            this.lblSoyisim.Size = new System.Drawing.Size(65, 23);
            this.lblSoyisim.TabIndex = 3;
            this.lblSoyisim.Text = "label5";
            // 
            // lblIsim
            // 
            this.lblIsim.AutoSize = true;
            this.lblIsim.Location = new System.Drawing.Point(13, 60);
            this.lblIsim.Name = "lblIsim";
            this.lblIsim.Size = new System.Drawing.Size(65, 23);
            this.lblIsim.TabIndex = 2;
            this.lblIsim.Text = "label4";
            // 
            // lblHastaId
            // 
            this.lblHastaId.AutoSize = true;
            this.lblHastaId.Location = new System.Drawing.Point(13, 29);
            this.lblHastaId.Name = "lblHastaId";
            this.lblHastaId.Size = new System.Drawing.Size(65, 23);
            this.lblHastaId.TabIndex = 1;
            this.lblHastaId.Text = "label3";
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(13, 0);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(65, 23);
            this.lblId.TabIndex = 0;
            this.lblId.Text = "label2";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(555, 440);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(168, 57);
            this.button1.TabIndex = 3;
            this.button1.Text = "GONDER";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Visible = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::hayatagaci.Properties.Resources._34257;
            this.pictureBox1.Location = new System.Drawing.Point(-8, 432);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(775, 373);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(432, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 23);
            this.label2.TabIndex = 5;
            this.label2.Text = "label2";
            this.label2.Visible = false;
            // 
            // FrmKanBHastaneIstek
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(760, 555);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "FrmKanBHastaneIstek";
            this.Text = "FrmKanKanIstek";
            this.Load += new System.EventHandler(this.FrmKanBHastaneIstek_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.ColumnHeader columnHeader11;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblHastane;
        private System.Windows.Forms.Label lblDurum;
        private System.Windows.Forms.Label lblTarih;
        private System.Windows.Forms.Label lblKan;
        private System.Windows.Forms.Label lblSoyisim;
        private System.Windows.Forms.Label lblIsim;
        private System.Windows.Forms.Label lblHastaId;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblgon;
        private System.Windows.Forms.Label lblkanmerkez;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
    }
}
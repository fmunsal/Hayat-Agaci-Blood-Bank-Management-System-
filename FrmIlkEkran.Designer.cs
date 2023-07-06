
namespace hayatagaci
{
    partial class FrmIlkEkran
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
            this.txtPersonel = new System.Windows.Forms.Label();
            this.btnKapatma = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pbPersonel = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPersonel)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Corbel", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(240, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(279, 54);
            this.label1.TabIndex = 0;
            this.label1.Text = "HAYAT AĞACI";
            // 
            // txtPersonel
            // 
            this.txtPersonel.AutoSize = true;
            this.txtPersonel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txtPersonel.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtPersonel.ForeColor = System.Drawing.SystemColors.Control;
            this.txtPersonel.Location = new System.Drawing.Point(325, 96);
            this.txtPersonel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txtPersonel.Name = "txtPersonel";
            this.txtPersonel.Size = new System.Drawing.Size(135, 32);
            this.txtPersonel.TabIndex = 2;
            this.txtPersonel.Text = "Personel";
            // 
            // btnKapatma
            // 
            this.btnKapatma.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(37)))), ((int)(((byte)(58)))));
            this.btnKapatma.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnKapatma.FlatAppearance.BorderSize = 0;
            this.btnKapatma.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKapatma.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKapatma.ForeColor = System.Drawing.Color.White;
            this.btnKapatma.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnKapatma.Location = new System.Drawing.Point(736, -11);
            this.btnKapatma.Margin = new System.Windows.Forms.Padding(0);
            this.btnKapatma.Name = "btnKapatma";
            this.btnKapatma.Size = new System.Drawing.Size(40, 37);
            this.btnKapatma.TabIndex = 3;
            this.btnKapatma.Text = "x";
            this.btnKapatma.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnKapatma.UseVisualStyleBackColor = false;
            this.btnKapatma.Click += new System.EventHandler(this.btnKapatma_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::hayatagaci.Properties.Resources._34257;
            this.pictureBox1.Location = new System.Drawing.Point(0, 284);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(773, 496);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // pbPersonel
            // 
            this.pbPersonel.BackColor = System.Drawing.Color.Transparent;
            this.pbPersonel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbPersonel.Image = global::hayatagaci.Properties.Resources.team;
            this.pbPersonel.Location = new System.Drawing.Point(303, 126);
            this.pbPersonel.Margin = new System.Windows.Forms.Padding(0);
            this.pbPersonel.Name = "pbPersonel";
            this.pbPersonel.Size = new System.Drawing.Size(187, 172);
            this.pbPersonel.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbPersonel.TabIndex = 1;
            this.pbPersonel.TabStop = false;
            this.pbPersonel.DoubleClick += new System.EventHandler(this.pbPersonel_DoubleClick);
            this.pbPersonel.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pbPersonel_MouseClick);
            // 
            // FrmIlkEkran
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(37)))), ((int)(((byte)(58)))));
            this.ClientSize = new System.Drawing.Size(771, 431);
            this.Controls.Add(this.btnKapatma);
            this.Controls.Add(this.txtPersonel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pbPersonel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmIlkEkran";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmIlkEkran";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPersonel)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pbPersonel;
        private System.Windows.Forms.Label txtPersonel;
        private System.Windows.Forms.Button btnKapatma;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
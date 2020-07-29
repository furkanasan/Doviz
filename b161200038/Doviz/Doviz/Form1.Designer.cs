namespace Doviz
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btn1 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblDolar = new System.Windows.Forms.Label();
            this.lblEur = new System.Windows.Forms.Label();
            this.lblYen = new System.Windows.Forms.Label();
            this.lblSterlin = new System.Windows.Forms.Label();
            this.lblEnflasyon = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.btn1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // btn1
            // 
            this.btn1.BackColor = System.Drawing.Color.Transparent;
            this.btn1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn1.BackgroundImage")));
            this.btn1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.btn1.Location = new System.Drawing.Point(12, 66);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(216, 64);
            this.btn1.TabIndex = 0;
            this.btn1.TabStop = false;
            this.btn1.Click += new System.EventHandler(this.btn1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(850, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(32, 32);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // lblDolar
            // 
            this.lblDolar.AutoSize = true;
            this.lblDolar.BackColor = System.Drawing.Color.Transparent;
            this.lblDolar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblDolar.Location = new System.Drawing.Point(135, 292);
            this.lblDolar.Name = "lblDolar";
            this.lblDolar.Size = new System.Drawing.Size(25, 13);
            this.lblDolar.TabIndex = 3;
            this.lblDolar.Text = "......";
            // 
            // lblEur
            // 
            this.lblEur.AutoSize = true;
            this.lblEur.BackColor = System.Drawing.Color.Transparent;
            this.lblEur.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblEur.Location = new System.Drawing.Point(135, 401);
            this.lblEur.Name = "lblEur";
            this.lblEur.Size = new System.Drawing.Size(25, 13);
            this.lblEur.TabIndex = 3;
            this.lblEur.Text = "......";
            // 
            // lblYen
            // 
            this.lblYen.AutoSize = true;
            this.lblYen.BackColor = System.Drawing.Color.Transparent;
            this.lblYen.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblYen.Location = new System.Drawing.Point(135, 506);
            this.lblYen.Name = "lblYen";
            this.lblYen.Size = new System.Drawing.Size(25, 13);
            this.lblYen.TabIndex = 3;
            this.lblYen.Text = "......";
            // 
            // lblSterlin
            // 
            this.lblSterlin.AutoSize = true;
            this.lblSterlin.BackColor = System.Drawing.Color.Transparent;
            this.lblSterlin.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblSterlin.Location = new System.Drawing.Point(135, 614);
            this.lblSterlin.Name = "lblSterlin";
            this.lblSterlin.Size = new System.Drawing.Size(25, 13);
            this.lblSterlin.TabIndex = 3;
            this.lblSterlin.Text = "......";
            // 
            // lblEnflasyon
            // 
            this.lblEnflasyon.AutoSize = true;
            this.lblEnflasyon.BackColor = System.Drawing.Color.Transparent;
            this.lblEnflasyon.Location = new System.Drawing.Point(135, 191);
            this.lblEnflasyon.Name = "lblEnflasyon";
            this.lblEnflasyon.Size = new System.Drawing.Size(22, 13);
            this.lblEnflasyon.TabIndex = 4;
            this.lblEnflasyon.Text = ".....";
            // 
            // dataGridView1
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(46)))), ((int)(((byte)(103)))));
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.Location = new System.Drawing.Point(476, 179);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(431, 475);
            this.dataGridView1.TabIndex = 6;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(234, 66);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(216, 64);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox2.TabIndex = 7;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(456, 66);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(216, 64);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox3.TabIndex = 8;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(907, 675);
            this.ControlBox = false;
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.lblEnflasyon);
            this.Controls.Add(this.lblSterlin);
            this.Controls.Add(this.lblYen);
            this.Controls.Add(this.lblEur);
            this.Controls.Add(this.lblDolar);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btn1);
            this.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.btn1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox btn1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblDolar;
        private System.Windows.Forms.Label lblEur;
        private System.Windows.Forms.Label lblYen;
        private System.Windows.Forms.Label lblSterlin;
        private System.Windows.Forms.Label lblEnflasyon;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
    }
}


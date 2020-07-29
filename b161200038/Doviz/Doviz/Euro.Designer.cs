namespace Doviz
{
    partial class Euro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Euro));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lbl2010 = new System.Windows.Forms.LinkLabel();
            this.lbl2000 = new System.Windows.Forms.LinkLabel();
            this.lbl1990 = new System.Windows.Forms.LinkLabel();
            this.lbl1980 = new System.Windows.Forms.LinkLabel();
            this.lbl1970 = new System.Windows.Forms.LinkLabel();
            this.lbl1960 = new System.Windows.Forms.LinkLabel();
            this.lbl1950 = new System.Windows.Forms.LinkLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(46)))), ((int)(((byte)(103)))));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(107, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(241, 393);
            this.dataGridView1.TabIndex = 9;
            // 
            // lbl2010
            // 
            this.lbl2010.Location = new System.Drawing.Point(0, 0);
            this.lbl2010.Name = "lbl2010";
            this.lbl2010.Size = new System.Drawing.Size(100, 23);
            this.lbl2010.TabIndex = 11;
            // 
            // lbl2000
            // 
            this.lbl2000.Location = new System.Drawing.Point(0, 0);
            this.lbl2000.Name = "lbl2000";
            this.lbl2000.Size = new System.Drawing.Size(100, 23);
            this.lbl2000.TabIndex = 12;
            // 
            // lbl1990
            // 
            this.lbl1990.Location = new System.Drawing.Point(0, 0);
            this.lbl1990.Name = "lbl1990";
            this.lbl1990.Size = new System.Drawing.Size(100, 23);
            this.lbl1990.TabIndex = 13;
            // 
            // lbl1980
            // 
            this.lbl1980.Location = new System.Drawing.Point(0, 0);
            this.lbl1980.Name = "lbl1980";
            this.lbl1980.Size = new System.Drawing.Size(100, 23);
            this.lbl1980.TabIndex = 14;
            // 
            // lbl1970
            // 
            this.lbl1970.Location = new System.Drawing.Point(0, 0);
            this.lbl1970.Name = "lbl1970";
            this.lbl1970.Size = new System.Drawing.Size(100, 23);
            this.lbl1970.TabIndex = 15;
            // 
            // lbl1960
            // 
            this.lbl1960.AutoSize = true;
            this.lbl1960.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl1960.LinkColor = System.Drawing.Color.Transparent;
            this.lbl1960.Location = new System.Drawing.Point(6, 92);
            this.lbl1960.Name = "lbl1960";
            this.lbl1960.Size = new System.Drawing.Size(95, 20);
            this.lbl1960.TabIndex = 7;
            this.lbl1960.TabStop = true;
            this.lbl1960.Text = "2010-2020";
            this.lbl1960.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lbl1960_LinkClicked);
            // 
            // lbl1950
            // 
            this.lbl1950.AutoSize = true;
            this.lbl1950.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl1950.LinkColor = System.Drawing.Color.Transparent;
            this.lbl1950.Location = new System.Drawing.Point(6, 61);
            this.lbl1950.Name = "lbl1950";
            this.lbl1950.Size = new System.Drawing.Size(95, 20);
            this.lbl1950.TabIndex = 8;
            this.lbl1950.TabStop = true;
            this.lbl1950.Text = "1999-2009";
            this.lbl1950.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lbl1950_LinkClicked);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(1, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(54, 58);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Euro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(46)))), ((int)(((byte)(103)))));
            this.ClientSize = new System.Drawing.Size(355, 417);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.lbl2010);
            this.Controls.Add(this.lbl2000);
            this.Controls.Add(this.lbl1990);
            this.Controls.Add(this.lbl1980);
            this.Controls.Add(this.lbl1970);
            this.Controls.Add(this.lbl1960);
            this.Controls.Add(this.lbl1950);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Euro";
            this.Text = "Euro";
            this.Load += new System.EventHandler(this.Euro_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.LinkLabel lbl2010;
        private System.Windows.Forms.LinkLabel lbl2000;
        private System.Windows.Forms.LinkLabel lbl1990;
        private System.Windows.Forms.LinkLabel lbl1980;
        private System.Windows.Forms.LinkLabel lbl1970;
        private System.Windows.Forms.LinkLabel lbl1960;
        private System.Windows.Forms.LinkLabel lbl1950;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
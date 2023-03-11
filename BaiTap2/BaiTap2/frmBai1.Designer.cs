namespace BaiTap2
{
    partial class frmBai1
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
            this.lbThongBao = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdThongTin = new System.Windows.Forms.RadioButton();
            this.rdThanhTien = new System.Windows.Forms.RadioButton();
            this.btChon = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(188, 188);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Thông báo:";
            // 
            // lbThongBao
            // 
            this.lbThongBao.AutoSize = true;
            this.lbThongBao.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbThongBao.Location = new System.Drawing.Point(305, 188);
            this.lbThongBao.Name = "lbThongBao";
            this.lbThongBao.Size = new System.Drawing.Size(14, 20);
            this.lbThongBao.TabIndex = 1;
            this.lbThongBao.Text = ".";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdThanhTien);
            this.groupBox1.Controls.Add(this.rdThongTin);
            this.groupBox1.Location = new System.Drawing.Point(192, 35);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 100);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Chọn phương thức";
            // 
            // rdThongTin
            // 
            this.rdThongTin.AutoSize = true;
            this.rdThongTin.Location = new System.Drawing.Point(7, 22);
            this.rdThongTin.Name = "rdThongTin";
            this.rdThongTin.Size = new System.Drawing.Size(83, 20);
            this.rdThongTin.TabIndex = 0;
            this.rdThongTin.TabStop = true;
            this.rdThongTin.Text = "Thông tin";
            this.rdThongTin.UseVisualStyleBackColor = true;
            this.rdThongTin.CheckedChanged += new System.EventHandler(this.rdThongTin_CheckedChanged);
            // 
            // rdThanhTien
            // 
            this.rdThanhTien.AutoSize = true;
            this.rdThanhTien.Location = new System.Drawing.Point(7, 48);
            this.rdThanhTien.Name = "rdThanhTien";
            this.rdThanhTien.Size = new System.Drawing.Size(90, 20);
            this.rdThanhTien.TabIndex = 1;
            this.rdThanhTien.TabStop = true;
            this.rdThanhTien.Text = "Thành tiền";
            this.rdThanhTien.UseVisualStyleBackColor = true;
            this.rdThanhTien.CheckedChanged += new System.EventHandler(this.rdThanhTien_CheckedChanged);
            // 
            // btChon
            // 
            this.btChon.Location = new System.Drawing.Point(244, 141);
            this.btChon.Name = "btChon";
            this.btChon.Size = new System.Drawing.Size(75, 23);
            this.btChon.TabIndex = 3;
            this.btChon.Text = "Chọn";
            this.btChon.UseVisualStyleBackColor = true;
            this.btChon.Click += new System.EventHandler(this.btChon_Click);
            // 
            // frmBai1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btChon);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lbThongBao);
            this.Controls.Add(this.label1);
            this.Name = "frmBai1";
            this.Text = "frmBai1";
            this.Load += new System.EventHandler(this.frmBai1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbThongBao;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdThanhTien;
        private System.Windows.Forms.RadioButton rdThongTin;
        private System.Windows.Forms.Button btChon;
    }
}
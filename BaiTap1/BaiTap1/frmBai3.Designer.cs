namespace BaiTap1
{
    partial class frmBai3
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnTinhToan = new System.Windows.Forms.Button();
            this.tbSoA = new System.Windows.Forms.TextBox();
            this.tbSoB = new System.Windows.Forms.TextBox();
            this.tbSoN = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdTong2So = new System.Windows.Forms.RadioButton();
            this.rdTongDaySo = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.lbKetQua = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(114, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Số a:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(114, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Số b:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(114, 308);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Kết quả: ";
            // 
            // btnTinhToan
            // 
            this.btnTinhToan.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTinhToan.Location = new System.Drawing.Point(215, 259);
            this.btnTinhToan.Name = "btnTinhToan";
            this.btnTinhToan.Size = new System.Drawing.Size(75, 23);
            this.btnTinhToan.TabIndex = 3;
            this.btnTinhToan.Text = "Tính";
            this.btnTinhToan.UseVisualStyleBackColor = true;
            this.btnTinhToan.Click += new System.EventHandler(this.btnTinhToan_Click);
            // 
            // tbSoA
            // 
            this.tbSoA.Location = new System.Drawing.Point(159, 39);
            this.tbSoA.Name = "tbSoA";
            this.tbSoA.Size = new System.Drawing.Size(131, 22);
            this.tbSoA.TabIndex = 4;
            this.tbSoA.Text = "0";
            // 
            // tbSoB
            // 
            this.tbSoB.Location = new System.Drawing.Point(159, 77);
            this.tbSoB.Name = "tbSoB";
            this.tbSoB.Size = new System.Drawing.Size(131, 22);
            this.tbSoB.TabIndex = 5;
            this.tbSoB.Text = "0";
            // 
            // tbSoN
            // 
            this.tbSoN.Location = new System.Drawing.Point(159, 111);
            this.tbSoN.Name = "tbSoN";
            this.tbSoN.Size = new System.Drawing.Size(131, 22);
            this.tbSoN.TabIndex = 6;
            this.tbSoN.Text = "0";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdTongDaySo);
            this.groupBox1.Controls.Add(this.rdTong2So);
            this.groupBox1.Location = new System.Drawing.Point(159, 153);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(219, 100);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Chọn phương thức";
            // 
            // rdTong2So
            // 
            this.rdTong2So.AutoSize = true;
            this.rdTong2So.Location = new System.Drawing.Point(7, 22);
            this.rdTong2So.Name = "rdTong2So";
            this.rdTong2So.Size = new System.Drawing.Size(105, 20);
            this.rdTong2So.TabIndex = 0;
            this.rdTong2So.TabStop = true;
            this.rdTong2So.Text = "Tính tổng a,b";
            this.rdTong2So.UseVisualStyleBackColor = true;
            // 
            // rdTongDaySo
            // 
            this.rdTongDaySo.AutoSize = true;
            this.rdTongDaySo.Location = new System.Drawing.Point(7, 48);
            this.rdTongDaySo.Name = "rdTongDaySo";
            this.rdTongDaySo.Size = new System.Drawing.Size(192, 20);
            this.rdTongDaySo.TabIndex = 1;
            this.rdTongDaySo.TabStop = true;
            this.rdTongDaySo.Text = "Tính Tổng dãy số từ 1 đến n";
            this.rdTongDaySo.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(114, 114);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 16);
            this.label4.TabIndex = 8;
            this.label4.Text = "Số n:";
            // 
            // lbKetQua
            // 
            this.lbKetQua.AutoSize = true;
            this.lbKetQua.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbKetQua.ForeColor = System.Drawing.Color.Red;
            this.lbKetQua.Location = new System.Drawing.Point(205, 308);
            this.lbKetQua.Name = "lbKetQua";
            this.lbKetQua.Size = new System.Drawing.Size(19, 20);
            this.lbKetQua.TabIndex = 9;
            this.lbKetQua.Text = "0";
            // 
            // frmBai3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(480, 450);
            this.Controls.Add(this.lbKetQua);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.tbSoN);
            this.Controls.Add(this.tbSoB);
            this.Controls.Add(this.tbSoA);
            this.Controls.Add(this.btnTinhToan);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmBai3";
            this.Text = "frmBai3";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnTinhToan;
        private System.Windows.Forms.TextBox tbSoA;
        private System.Windows.Forms.TextBox tbSoB;
        private System.Windows.Forms.TextBox tbSoN;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdTongDaySo;
        private System.Windows.Forms.RadioButton rdTong2So;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbKetQua;
    }
}
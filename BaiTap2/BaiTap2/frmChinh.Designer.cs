﻿namespace BaiTap2
{
    partial class frmChinh
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmChinh));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.bàiSố1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bàiSố2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bàiSố3ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripDropDownButton1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(800, 31);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripDropDownButton1
            // 
            this.toolStripDropDownButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripDropDownButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bàiSố1ToolStripMenuItem,
            this.bàiSố2ToolStripMenuItem,
            this.bàiSố3ToolStripMenuItem});
            this.toolStripDropDownButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton1.Image")));
            this.toolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            this.toolStripDropDownButton1.Size = new System.Drawing.Size(102, 28);
            this.toolStripDropDownButton1.Text = "Bài kiểm tra";
            // 
            // bàiSố1ToolStripMenuItem
            // 
            this.bàiSố1ToolStripMenuItem.Image = global::BaiTap2.Properties.Resources.th;
            this.bàiSố1ToolStripMenuItem.Name = "bàiSố1ToolStripMenuItem";
            this.bàiSố1ToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.bàiSố1ToolStripMenuItem.Text = "Bài số 1";
            this.bàiSố1ToolStripMenuItem.Click += new System.EventHandler(this.bàiSố1ToolStripMenuItem_Click);
            // 
            // bàiSố2ToolStripMenuItem
            // 
            this.bàiSố2ToolStripMenuItem.Image = global::BaiTap2.Properties.Resources.th;
            this.bàiSố2ToolStripMenuItem.Name = "bàiSố2ToolStripMenuItem";
            this.bàiSố2ToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.bàiSố2ToolStripMenuItem.Text = "Bài số 2";
            this.bàiSố2ToolStripMenuItem.Click += new System.EventHandler(this.bàiSố2ToolStripMenuItem_Click);
            // 
            // bàiSố3ToolStripMenuItem
            // 
            this.bàiSố3ToolStripMenuItem.Image = global::BaiTap2.Properties.Resources.th;
            this.bàiSố3ToolStripMenuItem.Name = "bàiSố3ToolStripMenuItem";
            this.bàiSố3ToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.bàiSố3ToolStripMenuItem.Text = "Bài số 3";
            this.bàiSố3ToolStripMenuItem.Click += new System.EventHandler(this.bàiSố3ToolStripMenuItem_Click);
            // 
            // frmChinh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.toolStrip1);
            this.Name = "frmChinh";
            this.Text = "Chương trình chính";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton1;
        private System.Windows.Forms.ToolStripMenuItem bàiSố1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bàiSố2ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bàiSố3ToolStripMenuItem;
    }
}


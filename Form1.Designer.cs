namespace Bai_6___Bai_tap_nang_cao___BT_1
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.cậpNhậtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuKetThuc = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuNhapHocVien = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuChuyenSangB = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuChuyenSangA = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuXoaHocVien = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lstLopA = new System.Windows.Forms.ListBox();
            this.lstLopB = new System.Windows.Forms.ListBox();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cậpNhậtToolStripMenuItem,
            this.mnuKetThuc});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(10, 3, 0, 3);
            this.menuStrip1.Size = new System.Drawing.Size(649, 25);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // cậpNhậtToolStripMenuItem
            // 
            this.cậpNhậtToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuNhapHocVien,
            this.mnuChuyenSangB,
            this.mnuChuyenSangA,
            this.mnuXoaHocVien});
            this.cậpNhậtToolStripMenuItem.Name = "cậpNhậtToolStripMenuItem";
            this.cậpNhậtToolStripMenuItem.Size = new System.Drawing.Size(67, 19);
            this.cậpNhậtToolStripMenuItem.Text = "&Cập nhật";
            // 
            // mnuKetThuc
            // 
            this.mnuKetThuc.Name = "mnuKetThuc";
            this.mnuKetThuc.Size = new System.Drawing.Size(63, 19);
            this.mnuKetThuc.Text = "&Kết thúc";
            this.mnuKetThuc.Click += new System.EventHandler(this.mnuKetThuc_Click);
            // 
            // mnuNhapHocVien
            // 
            this.mnuNhapHocVien.Name = "mnuNhapHocVien";
            this.mnuNhapHocVien.Size = new System.Drawing.Size(180, 22);
            this.mnuNhapHocVien.Text = "Nhập học viên mới";
            this.mnuNhapHocVien.Click += new System.EventHandler(this.mnuNhapHocVien_Click);
            // 
            // mnuChuyenSangB
            // 
            this.mnuChuyenSangB.Name = "mnuChuyenSangB";
            this.mnuChuyenSangB.Size = new System.Drawing.Size(180, 22);
            this.mnuChuyenSangB.Text = "Chuyển sang lớp B";
            this.mnuChuyenSangB.Click += new System.EventHandler(this.mnuChuyenSangB_Click);
            // 
            // mnuChuyenSangA
            // 
            this.mnuChuyenSangA.Name = "mnuChuyenSangA";
            this.mnuChuyenSangA.Size = new System.Drawing.Size(180, 22);
            this.mnuChuyenSangA.Text = "Chuyến sang lớp A";
            this.mnuChuyenSangA.Click += new System.EventHandler(this.mnuChuyenSangA_Click);
            // 
            // mnuXoaHocVien
            // 
            this.mnuXoaHocVien.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.mnuXoaHocVien.Name = "mnuXoaHocVien";
            this.mnuXoaHocVien.Size = new System.Drawing.Size(180, 22);
            this.mnuXoaHocVien.Text = "Xóa học viên";
            this.mnuXoaHocVien.Click += new System.EventHandler(this.mnuXoaHocVien_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lstLopA);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.groupBox1.Location = new System.Drawing.Point(52, 55);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.groupBox1.Size = new System.Drawing.Size(259, 403);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Lớp A";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lstLopB);
            this.groupBox2.Location = new System.Drawing.Point(332, 55);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.groupBox2.Size = new System.Drawing.Size(265, 403);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Lớp B";
            // 
            // lstLopA
            // 
            this.lstLopA.FormattingEnabled = true;
            this.lstLopA.ItemHeight = 20;
            this.lstLopA.Items.AddRange(new object[] {
            "Nguyễn Thị Minh Thắm",
            "Nguyễn Thành Trung",
            "Phẩm Quang Vinh",
            "Lưu Thiện Hạnh Trang"});
            this.lstLopA.Location = new System.Drawing.Point(19, 37);
            this.lstLopA.Name = "lstLopA";
            this.lstLopA.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.lstLopA.Size = new System.Drawing.Size(212, 344);
            this.lstLopA.TabIndex = 0;
            // 
            // lstLopB
            // 
            this.lstLopB.FormattingEnabled = true;
            this.lstLopB.ItemHeight = 20;
            this.lstLopB.Items.AddRange(new object[] {
            "Nguyễn Anh Tuấn",
            "Đoàn Minh Đức",
            "Vũ Anh Tú",
            "Nguyễn Quang Tuấn"});
            this.lstLopB.Location = new System.Drawing.Point(20, 37);
            this.lstLopB.Name = "lstLopB";
            this.lstLopB.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.lstLopB.Size = new System.Drawing.Size(219, 344);
            this.lstLopB.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(649, 495);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem cậpNhậtToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuNhapHocVien;
        private System.Windows.Forms.ToolStripMenuItem mnuChuyenSangB;
        private System.Windows.Forms.ToolStripMenuItem mnuChuyenSangA;
        private System.Windows.Forms.ToolStripMenuItem mnuXoaHocVien;
        private System.Windows.Forms.ToolStripMenuItem mnuKetThuc;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListBox lstLopA;
        private System.Windows.Forms.ListBox lstLopB;
    }
}


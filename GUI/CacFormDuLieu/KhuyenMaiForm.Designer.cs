﻿namespace GUI
{
    partial class KhuyenMaiForm
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            dgvKhuyenMai = new Guna.UI2.WinForms.Guna2DataGridView();
            Column2 = new DataGridViewTextBoxColumn();
            Column1 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            Column6 = new DataGridViewTextBoxColumn();
            Column7 = new DataGridViewTextBoxColumn();
            Column8 = new DataGridViewTextBoxColumn();
            Column9 = new DataGridViewImageColumn();
            Column10 = new DataGridViewImageColumn();
            Column11 = new DataGridViewImageColumn();
            panel3 = new Panel();
            panel1 = new Panel();
            panel2 = new Panel();
            cbbSapXep = new Guna.UI2.WinForms.Guna2ComboBox();
            btnNhapXuatExcel = new FontAwesome.Sharp.IconButton();
            btnThemMoi = new FontAwesome.Sharp.IconButton();
            tsDangTonTai = new Guna.UI2.WinForms.Guna2ToggleSwitch();
            label1 = new Label();
            iconButton2 = new FontAwesome.Sharp.IconButton();
            btnTimKiem = new FontAwesome.Sharp.IconButton();
            btnDeleteAll = new FontAwesome.Sharp.IconButton();
            timKiemTextBox = new Guna.UI2.WinForms.Guna2TextBox();
            ((System.ComponentModel.ISupportInitialize)dgvKhuyenMai).BeginInit();
            panel3.SuspendLayout();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // dgvKhuyenMai
            // 
            dgvKhuyenMai.AllowUserToAddRows = false;
            dataGridViewCellStyle1.BackColor = Color.White;
            dgvKhuyenMai.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgvKhuyenMai.BackgroundColor = Color.FromArgb(242, 245, 250);
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = Color.LightBlue;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = Color.FromArgb(30, 110, 142);
            dataGridViewCellStyle2.SelectionBackColor = Color.LightBlue;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvKhuyenMai.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvKhuyenMai.ColumnHeadersHeight = 40;
            dgvKhuyenMai.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dgvKhuyenMai.Columns.AddRange(new DataGridViewColumn[] { Column2, Column1, Column3, Column4, Column5, Column6, Column7, Column8, Column9, Column10, Column11 });
            dataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = Color.White;
            dataGridViewCellStyle7.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle7.ForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle7.SelectionBackColor = Color.FromArgb(227, 248, 251);
            dataGridViewCellStyle7.SelectionForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle7.WrapMode = DataGridViewTriState.False;
            dgvKhuyenMai.DefaultCellStyle = dataGridViewCellStyle7;
            dgvKhuyenMai.Dock = DockStyle.Fill;
            dgvKhuyenMai.GridColor = Color.FromArgb(242, 245, 250);
            dgvKhuyenMai.Location = new Point(0, 0);
            dgvKhuyenMai.Name = "dgvKhuyenMai";
            dgvKhuyenMai.ReadOnly = true;
            dataGridViewCellStyle8.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = Color.White;
            dataGridViewCellStyle8.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle8.ForeColor = Color.FromArgb(242, 245, 250);
            dataGridViewCellStyle8.SelectionBackColor = Color.White;
            dataGridViewCellStyle8.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = DataGridViewTriState.True;
            dgvKhuyenMai.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
            dgvKhuyenMai.RowHeadersVisible = false;
            dgvKhuyenMai.RowHeadersWidth = 51;
            dgvKhuyenMai.RowTemplate.DividerHeight = 3;
            dgvKhuyenMai.RowTemplate.Height = 50;
            dgvKhuyenMai.Size = new Size(1183, 751);
            dgvKhuyenMai.TabIndex = 35;
            dgvKhuyenMai.ThemeStyle.AlternatingRowsStyle.BackColor = Color.White;
            dgvKhuyenMai.ThemeStyle.AlternatingRowsStyle.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dgvKhuyenMai.ThemeStyle.AlternatingRowsStyle.ForeColor = SystemColors.ControlText;
            dgvKhuyenMai.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dgvKhuyenMai.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.FromArgb(71, 69, 94);
            dgvKhuyenMai.ThemeStyle.BackColor = Color.FromArgb(242, 245, 250);
            dgvKhuyenMai.ThemeStyle.GridColor = Color.FromArgb(242, 245, 250);
            dgvKhuyenMai.ThemeStyle.HeaderStyle.BackColor = Color.FromArgb(242, 245, 250);
            dgvKhuyenMai.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvKhuyenMai.ThemeStyle.HeaderStyle.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            dgvKhuyenMai.ThemeStyle.HeaderStyle.ForeColor = Color.DimGray;
            dgvKhuyenMai.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dgvKhuyenMai.ThemeStyle.HeaderStyle.Height = 40;
            dgvKhuyenMai.ThemeStyle.ReadOnly = true;
            dgvKhuyenMai.ThemeStyle.RowsStyle.BackColor = Color.White;
            dgvKhuyenMai.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvKhuyenMai.ThemeStyle.RowsStyle.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            dgvKhuyenMai.ThemeStyle.RowsStyle.ForeColor = Color.FromArgb(71, 69, 94);
            dgvKhuyenMai.ThemeStyle.RowsStyle.Height = 50;
            dgvKhuyenMai.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(0, 80, 112);
            dgvKhuyenMai.ThemeStyle.RowsStyle.SelectionForeColor = Color.White;
            dgvKhuyenMai.CellFormatting += sanPhamDataGridView_CellFormatting;
            dgvKhuyenMai.CellPainting += sanPhamDataGridView_CellPainting;
            // 
            // Column2
            // 
            Column2.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            Column2.DefaultCellStyle = dataGridViewCellStyle3;
            Column2.HeaderText = "#";
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            Column2.ReadOnly = true;
            Column2.Width = 46;
            // 
            // Column1
            // 
            Column1.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Column1.HeaderText = "Mã khuyến mãi";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            Column1.ReadOnly = true;
            Column1.Resizable = DataGridViewTriState.True;
            // 
            // Column3
            // 
            Column3.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Column3.HeaderText = "Mã quản lí";
            Column3.MinimumWidth = 6;
            Column3.Name = "Column3";
            Column3.ReadOnly = true;
            // 
            // Column4
            // 
            Column4.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Column4.FillWeight = 150F;
            Column4.HeaderText = "Tên khuyến mãi";
            Column4.MinimumWidth = 6;
            Column4.Name = "Column4";
            Column4.ReadOnly = true;
            // 
            // Column5
            // 
            Column5.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Column5.HeaderText = "Bắt đầu";
            Column5.MinimumWidth = 6;
            Column5.Name = "Column5";
            Column5.ReadOnly = true;
            // 
            // Column6
            // 
            Column6.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleCenter;
            Column6.DefaultCellStyle = dataGridViewCellStyle4;
            Column6.HeaderText = "Kết thúc";
            Column6.MinimumWidth = 6;
            Column6.Name = "Column6";
            Column6.ReadOnly = true;
            // 
            // Column7
            // 
            Column7.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleCenter;
            Column7.DefaultCellStyle = dataGridViewCellStyle5;
            Column7.HeaderText = "Loại giá trị";
            Column7.MinimumWidth = 6;
            Column7.Name = "Column7";
            Column7.ReadOnly = true;
            // 
            // Column8
            // 
            Column8.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleCenter;
            Column8.DefaultCellStyle = dataGridViewCellStyle6;
            Column8.HeaderText = "Giá trị áp dụng";
            Column8.MinimumWidth = 6;
            Column8.Name = "Column8";
            Column8.ReadOnly = true;
            // 
            // Column9
            // 
            Column9.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Column9.FillWeight = 30F;
            Column9.HeaderText = "";
            Column9.Image = Properties.Resources._003_info1;
            Column9.MinimumWidth = 6;
            Column9.Name = "Column9";
            Column9.ReadOnly = true;
            Column9.Width = 6;
            // 
            // Column10
            // 
            Column10.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Column10.FillWeight = 30F;
            Column10.HeaderText = "";
            Column10.Image = Properties.Resources._002_pencil1;
            Column10.MinimumWidth = 6;
            Column10.Name = "Column10";
            Column10.ReadOnly = true;
            Column10.Width = 6;
            // 
            // Column11
            // 
            Column11.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Column11.FillWeight = 30F;
            Column11.HeaderText = "";
            Column11.Image = Properties.Resources._001_bin;
            Column11.MinimumWidth = 6;
            Column11.Name = "Column11";
            Column11.ReadOnly = true;
            Column11.Width = 6;
            // 
            // panel3
            // 
            panel3.Controls.Add(dgvKhuyenMai);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(0, 80);
            panel3.Margin = new Padding(3, 2, 3, 2);
            panel3.Name = "panel3";
            panel3.Size = new Size(1183, 751);
            panel3.TabIndex = 37;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(223, 243, 252);
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(panel2);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1183, 831);
            panel1.TabIndex = 1;
            // 
            // panel2
            // 
            panel2.Controls.Add(timKiemTextBox);
            panel2.Controls.Add(btnDeleteAll);
            panel2.Controls.Add(btnTimKiem);
            panel2.Controls.Add(iconButton2);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(tsDangTonTai);
            panel2.Controls.Add(btnThemMoi);
            panel2.Controls.Add(btnNhapXuatExcel);
            panel2.Controls.Add(cbbSapXep);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Margin = new Padding(3, 2, 3, 2);
            panel2.Name = "panel2";
            panel2.Size = new Size(1183, 80);
            panel2.TabIndex = 36;
            // 
            // cbbSapXep
            // 
            cbbSapXep.BackColor = Color.Transparent;
            cbbSapXep.CustomizableEdges = customizableEdges5;
            cbbSapXep.DrawMode = DrawMode.OwnerDrawFixed;
            cbbSapXep.DropDownStyle = ComboBoxStyle.DropDownList;
            cbbSapXep.FocusedColor = Color.FromArgb(94, 148, 255);
            cbbSapXep.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            cbbSapXep.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            cbbSapXep.ForeColor = Color.FromArgb(68, 88, 112);
            cbbSapXep.ItemHeight = 30;
            cbbSapXep.Location = new Point(108, 32);
            cbbSapXep.Name = "cbbSapXep";
            cbbSapXep.ShadowDecoration.CustomizableEdges = customizableEdges6;
            cbbSapXep.Size = new Size(227, 36);
            cbbSapXep.TabIndex = 78;
            // 
            // btnNhapXuatExcel
            // 
            btnNhapXuatExcel.BackColor = Color.FromArgb(33, 31, 48);
            btnNhapXuatExcel.FlatAppearance.BorderSize = 0;
            btnNhapXuatExcel.FlatStyle = FlatStyle.Flat;
            btnNhapXuatExcel.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnNhapXuatExcel.ForeColor = Color.White;
            btnNhapXuatExcel.IconChar = FontAwesome.Sharp.IconChar.FileCirclePlus;
            btnNhapXuatExcel.IconColor = Color.White;
            btnNhapXuatExcel.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnNhapXuatExcel.IconSize = 20;
            btnNhapXuatExcel.ImageAlign = ContentAlignment.MiddleLeft;
            btnNhapXuatExcel.Location = new Point(816, 32);
            btnNhapXuatExcel.Name = "btnNhapXuatExcel";
            btnNhapXuatExcel.Size = new Size(115, 36);
            btnNhapXuatExcel.TabIndex = 80;
            btnNhapXuatExcel.Text = "Xuất excel";
            btnNhapXuatExcel.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnNhapXuatExcel.UseVisualStyleBackColor = false;
            // 
            // btnThemMoi
            // 
            btnThemMoi.BackColor = Color.FromArgb(226, 153, 48);
            btnThemMoi.FlatAppearance.BorderSize = 0;
            btnThemMoi.FlatStyle = FlatStyle.Flat;
            btnThemMoi.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnThemMoi.ForeColor = Color.White;
            btnThemMoi.IconChar = FontAwesome.Sharp.IconChar.HandHoldingMedical;
            btnThemMoi.IconColor = Color.White;
            btnThemMoi.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnThemMoi.IconSize = 20;
            btnThemMoi.ImageAlign = ContentAlignment.MiddleLeft;
            btnThemMoi.Location = new Point(937, 32);
            btnThemMoi.Name = "btnThemMoi";
            btnThemMoi.Size = new Size(115, 36);
            btnThemMoi.TabIndex = 79;
            btnThemMoi.Text = "Thêm mới";
            btnThemMoi.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnThemMoi.UseVisualStyleBackColor = false;
            // 
            // tsDangTonTai
            // 
            tsDangTonTai.Checked = true;
            tsDangTonTai.CheckedState.BorderColor = Color.FromArgb(94, 148, 255);
            tsDangTonTai.CheckedState.FillColor = Color.FromArgb(94, 148, 255);
            tsDangTonTai.CheckedState.InnerBorderColor = Color.White;
            tsDangTonTai.CheckedState.InnerColor = Color.White;
            tsDangTonTai.CustomizableEdges = customizableEdges3;
            tsDangTonTai.Location = new Point(28, 45);
            tsDangTonTai.Name = "tsDangTonTai";
            tsDangTonTai.ShadowDecoration.CustomizableEdges = customizableEdges4;
            tsDangTonTai.Size = new Size(44, 23);
            tsDangTonTai.TabIndex = 83;
            tsDangTonTai.UncheckedState.BorderColor = Color.FromArgb(125, 137, 149);
            tsDangTonTai.UncheckedState.FillColor = Color.FromArgb(125, 137, 149);
            tsDangTonTai.UncheckedState.InnerBorderColor = Color.White;
            tsDangTonTai.UncheckedState.InnerColor = Color.White;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.GrayText;
            label1.Location = new Point(10, 12);
            label1.Name = "label1";
            label1.Size = new Size(80, 20);
            label1.TabIndex = 82;
            label1.Text = "Trạng thái";
            // 
            // iconButton2
            // 
            iconButton2.BackColor = Color.FromArgb(33, 31, 48);
            iconButton2.FlatAppearance.BorderSize = 0;
            iconButton2.FlatStyle = FlatStyle.Flat;
            iconButton2.IconChar = FontAwesome.Sharp.IconChar.ArrowsRotate;
            iconButton2.IconColor = Color.White;
            iconButton2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton2.IconSize = 20;
            iconButton2.Location = new Point(767, 32);
            iconButton2.Name = "iconButton2";
            iconButton2.Size = new Size(43, 36);
            iconButton2.TabIndex = 84;
            iconButton2.UseVisualStyleBackColor = false;
            // 
            // btnTimKiem
            // 
            btnTimKiem.BackColor = Color.FromArgb(226, 153, 48);
            btnTimKiem.FlatAppearance.BorderSize = 0;
            btnTimKiem.FlatStyle = FlatStyle.Flat;
            btnTimKiem.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
            btnTimKiem.IconColor = Color.White;
            btnTimKiem.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnTimKiem.IconSize = 20;
            btnTimKiem.Location = new Point(718, 32);
            btnTimKiem.Name = "btnTimKiem";
            btnTimKiem.Size = new Size(43, 36);
            btnTimKiem.TabIndex = 81;
            btnTimKiem.UseVisualStyleBackColor = false;
            // 
            // btnDeleteAll
            // 
            btnDeleteAll.BackColor = Color.IndianRed;
            btnDeleteAll.FlatAppearance.BorderSize = 0;
            btnDeleteAll.FlatStyle = FlatStyle.Flat;
            btnDeleteAll.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnDeleteAll.ForeColor = Color.White;
            btnDeleteAll.IconChar = FontAwesome.Sharp.IconChar.HandHoldingMedical;
            btnDeleteAll.IconColor = Color.White;
            btnDeleteAll.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnDeleteAll.IconSize = 20;
            btnDeleteAll.ImageAlign = ContentAlignment.MiddleLeft;
            btnDeleteAll.Location = new Point(1058, 32);
            btnDeleteAll.Name = "btnDeleteAll";
            btnDeleteAll.Size = new Size(115, 36);
            btnDeleteAll.TabIndex = 85;
            btnDeleteAll.Text = "xoá tất cả ";
            btnDeleteAll.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnDeleteAll.UseVisualStyleBackColor = false;
            // 
            // timKiemTextBox
            // 
            timKiemTextBox.CustomizableEdges = customizableEdges1;
            timKiemTextBox.DefaultText = "";
            timKiemTextBox.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            timKiemTextBox.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            timKiemTextBox.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            timKiemTextBox.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            timKiemTextBox.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            timKiemTextBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            timKiemTextBox.ForeColor = Color.FromArgb(84, 155, 255);
            timKiemTextBox.HoverState.BorderColor = Color.FromArgb(0, 192, 192);
            timKiemTextBox.Location = new Point(343, 32);
            timKiemTextBox.Margin = new Padding(5);
            timKiemTextBox.Name = "timKiemTextBox";
            timKiemTextBox.PasswordChar = '\0';
            timKiemTextBox.PlaceholderForeColor = Color.FromArgb(186, 215, 255);
            timKiemTextBox.PlaceholderText = "Nhập tên để tìm kiếm";
            timKiemTextBox.SelectedText = "";
            timKiemTextBox.ShadowDecoration.CustomizableEdges = customizableEdges2;
            timKiemTextBox.Size = new Size(367, 36);
            timKiemTextBox.TabIndex = 86;
            // 
            // KhuyenMaiForm
            // 
            AutoScaleDimensions = new SizeF(11F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1183, 831);
            Controls.Add(panel1);
            Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(5);
            Name = "KhuyenMaiForm";
            Text = "QUẢN LÝ KHUYẾN MÃI";
            ((System.ComponentModel.ISupportInitialize)dgvKhuyenMai).EndInit();
            panel3.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Guna.UI2.WinForms.Guna2DataGridView dgvKhuyenMai;
        private Panel panel3;
        private Panel panel1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column6;
        private DataGridViewTextBoxColumn Column7;
        private DataGridViewTextBoxColumn Column8;
        private DataGridViewImageColumn Column9;
        private DataGridViewImageColumn Column10;
        private DataGridViewImageColumn Column11;
        private Panel panel2;
        private Guna.UI2.WinForms.Guna2TextBox timKiemTextBox;
        private FontAwesome.Sharp.IconButton btnDeleteAll;
        private FontAwesome.Sharp.IconButton btnTimKiem;
        private FontAwesome.Sharp.IconButton iconButton2;
        private Label label1;
        private Guna.UI2.WinForms.Guna2ToggleSwitch tsDangTonTai;
        private FontAwesome.Sharp.IconButton btnThemMoi;
        private FontAwesome.Sharp.IconButton btnNhapXuatExcel;
        private Guna.UI2.WinForms.Guna2ComboBox cbbSapXep;
    }
}
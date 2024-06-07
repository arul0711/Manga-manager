namespace manga
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tabcontrol1 = new TabControl();
            tabHome = new TabPage();
            panel1 = new Panel();
            label3 = new Label();
            label1 = new Label();
            txtTenSach = new TextBox();
            label2 = new Label();
            btnThem = new Button();
            btnXoa = new Button();
            btnSua = new Button();
            dataGridView1 = new DataGridView();
            cbTheLoai = new ComboBox();
            label4 = new Label();
            label5 = new Label();
            numSoLuong = new NumericUpDown();
            numGiaBan = new NumericUpDown();
            tabTheLoai = new TabPage();
            dataGridView2 = new DataGridView();
            panel2 = new Panel();
            label8 = new Label();
            btnThemTheLoai = new Button();
            btnXoaTheLoai = new Button();
            btnSuaTheLoai = new Button();
            cbTacGia = new ComboBox();
            txtTheLoai = new TextBox();
            tabPage2 = new TabPage();
            panel3 = new Panel();
            txtTacGia = new TextBox();
            label6 = new Label();
            btnThemTacGia = new Button();
            btnXoaTacGia = new Button();
            btnSuaTacGia = new Button();
            dataGridView3 = new DataGridView();
            tabcontrol1.SuspendLayout();
            tabHome.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numSoLuong).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numGiaBan).BeginInit();
            tabTheLoai.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            panel2.SuspendLayout();
            tabPage2.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView3).BeginInit();
            SuspendLayout();
            // 
            // tabcontrol1
            // 
            tabcontrol1.Controls.Add(tabHome);
            tabcontrol1.Controls.Add(tabTheLoai);
            tabcontrol1.Controls.Add(tabPage2);
            tabcontrol1.Location = new Point(12, 12);
            tabcontrol1.Name = "tabcontrol1";
            tabcontrol1.SelectedIndex = 0;
            tabcontrol1.Size = new Size(1259, 627);
            tabcontrol1.TabIndex = 0;
            // 
            // tabHome
            // 
            tabHome.Controls.Add(panel1);
            tabHome.Controls.Add(dataGridView1);
            tabHome.Location = new Point(4, 30);
            tabHome.Name = "tabHome";
            tabHome.Padding = new Padding(3);
            tabHome.Size = new Size(1251, 593);
            tabHome.TabIndex = 0;
            tabHome.Text = "Home";
            tabHome.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            panel1.Controls.Add(cbTacGia);
            panel1.Controls.Add(numGiaBan);
            panel1.Controls.Add(numSoLuong);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(cbTheLoai);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(txtTenSach);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(btnThem);
            panel1.Controls.Add(btnXoa);
            panel1.Controls.Add(btnSua);
            panel1.Location = new Point(6, 431);
            panel1.Name = "panel1";
            panel1.Size = new Size(1228, 146);
            panel1.TabIndex = 4;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Location = new Point(20, 102);
            label3.Margin = new Padding(0);
            label3.Name = "label3";
            label3.Padding = new Padding(3);
            label3.Size = new Size(76, 27);
            label3.TabIndex = 12;
            label3.Text = "Thể loại";
            label3.TextAlign = ContentAlignment.BottomCenter;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Location = new Point(20, 60);
            label1.Margin = new Padding(0);
            label1.Name = "label1";
            label1.Padding = new Padding(3);
            label1.Size = new Size(71, 27);
            label1.TabIndex = 10;
            label1.Text = "Tác giả";
            label1.TextAlign = ContentAlignment.BottomCenter;
            // 
            // txtTenSach
            // 
            txtTenSach.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtTenSach.BorderStyle = BorderStyle.FixedSingle;
            txtTenSach.Location = new Point(110, 17);
            txtTenSach.Name = "txtTenSach";
            txtTenSach.Size = new Size(231, 29);
            txtTenSach.TabIndex = 9;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Location = new Point(20, 17);
            label2.Margin = new Padding(0);
            label2.Name = "label2";
            label2.Padding = new Padding(3);
            label2.Size = new Size(84, 27);
            label2.TabIndex = 7;
            label2.Text = "Tên sách";
            label2.TextAlign = ContentAlignment.BottomCenter;

            // 
            // btnThem
            // 
            btnThem.Font = new Font("Times New Roman", 12F);
            btnThem.Location = new Point(1137, 14);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(75, 30);
            btnThem.TabIndex = 1;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            // 
            // btnXoa
            // 
            btnXoa.Font = new Font("Times New Roman", 12F);
            btnXoa.ForeColor = Color.Crimson;
            btnXoa.Location = new Point(1137, 101);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(75, 30);
            btnXoa.TabIndex = 3;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            // 
            // btnSua
            // 
            btnSua.Font = new Font("Times New Roman", 12F);
            btnSua.Location = new Point(1137, 58);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(75, 28);
            btnSua.TabIndex = 2;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(6, 6);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(1228, 403);
            dataGridView1.TabIndex = 0;
            // 
            // cbTheLoai
            // 
            cbTheLoai.FormattingEnabled = true;
            cbTheLoai.Location = new Point(110, 101);
            cbTheLoai.Name = "cbTheLoai";
            cbTheLoai.Size = new Size(231, 29);
            cbTheLoai.TabIndex = 13;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label4.AutoSize = true;
            label4.Location = new Point(599, 16);
            label4.Margin = new Padding(0);
            label4.Name = "label4";
            label4.Padding = new Padding(3);
            label4.Size = new Size(84, 27);
            label4.TabIndex = 14;
            label4.Text = "Số lượng";
            label4.TextAlign = ContentAlignment.BottomCenter;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label5.AutoSize = true;
            label5.Location = new Point(599, 101);
            label5.Margin = new Padding(0);
            label5.Name = "label5";
            label5.Padding = new Padding(3);
            label5.Size = new Size(74, 27);
            label5.TabIndex = 15;
            label5.Text = "Giá bán";
            label5.TextAlign = ContentAlignment.BottomCenter;
            // 
            // numSoLuong
            // 
            numSoLuong.Location = new Point(686, 14);
            numSoLuong.Name = "numSoLuong";
            numSoLuong.Size = new Size(120, 29);
            numSoLuong.TabIndex = 16;
            // 
            // numGiaBan
            // 
            numGiaBan.Location = new Point(686, 99);
            numGiaBan.Name = "numGiaBan";
            numGiaBan.Size = new Size(120, 29);
            numGiaBan.TabIndex = 17;
            // 
            // tabTheLoai
            // 
            tabTheLoai.Controls.Add(panel2);
            tabTheLoai.Controls.Add(dataGridView2);
            tabTheLoai.Location = new Point(4, 30);
            tabTheLoai.Name = "tabTheLoai";
            tabTheLoai.Padding = new Padding(3);
            tabTheLoai.Size = new Size(1251, 593);
            tabTheLoai.TabIndex = 1;
            tabTheLoai.Text = "Thể loại";
            tabTheLoai.UseVisualStyleBackColor = true;
            // 
            // dataGridView2
            // 
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(6, 6);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.Size = new Size(1228, 403);
            dataGridView2.TabIndex = 1;
            // 
            // panel2
            // 
            panel2.Controls.Add(txtTheLoai);
            panel2.Controls.Add(label8);
            panel2.Controls.Add(btnThemTheLoai);
            panel2.Controls.Add(btnXoaTheLoai);
            panel2.Controls.Add(btnSuaTheLoai);
            panel2.Location = new Point(6, 431);
            panel2.Name = "panel2";
            panel2.Size = new Size(1228, 146);
            panel2.TabIndex = 5;
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label8.AutoSize = true;
            label8.Location = new Point(19, 20);
            label8.Margin = new Padding(0);
            label8.Name = "label8";
            label8.Padding = new Padding(3);
            label8.Size = new Size(76, 27);
            label8.TabIndex = 12;
            label8.Text = "Thể loại";
            label8.TextAlign = ContentAlignment.BottomCenter;
            // 
            // btnThemTheLoai
            // 
            btnThemTheLoai.Font = new Font("Times New Roman", 12F);
            btnThemTheLoai.Location = new Point(876, 18);
            btnThemTheLoai.Name = "btnThemTheLoai";
            btnThemTheLoai.Size = new Size(75, 30);
            btnThemTheLoai.TabIndex = 1;
            btnThemTheLoai.Text = "Thêm";
            btnThemTheLoai.UseVisualStyleBackColor = true;
            // 
            // btnXoaTheLoai
            // 
            btnXoaTheLoai.Font = new Font("Times New Roman", 12F);
            btnXoaTheLoai.ForeColor = Color.Crimson;
            btnXoaTheLoai.Location = new Point(1141, 18);
            btnXoaTheLoai.Name = "btnXoaTheLoai";
            btnXoaTheLoai.Size = new Size(75, 30);
            btnXoaTheLoai.TabIndex = 3;
            btnXoaTheLoai.Text = "Xóa";
            btnXoaTheLoai.UseVisualStyleBackColor = true;
            // 
            // btnSuaTheLoai
            // 
            btnSuaTheLoai.Font = new Font("Times New Roman", 12F);
            btnSuaTheLoai.Location = new Point(1006, 18);
            btnSuaTheLoai.Name = "btnSuaTheLoai";
            btnSuaTheLoai.Size = new Size(75, 28);
            btnSuaTheLoai.TabIndex = 2;
            btnSuaTheLoai.Text = "Sửa";
            btnSuaTheLoai.UseVisualStyleBackColor = true;
            // 
            // cbTacGia
            // 
            cbTacGia.FormattingEnabled = true;
            cbTacGia.Location = new Point(110, 58);
            cbTacGia.Name = "cbTacGia";
            cbTacGia.Size = new Size(231, 29);
            cbTacGia.TabIndex = 18;
            // 
            // txtTheLoai
            // 
            txtTheLoai.BorderStyle = BorderStyle.FixedSingle;
            txtTheLoai.Location = new Point(98, 19);
            txtTheLoai.Name = "txtTheLoai";
            txtTheLoai.Size = new Size(339, 29);
            txtTheLoai.TabIndex = 13;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(panel3);
            tabPage2.Controls.Add(dataGridView3);
            tabPage2.Location = new Point(4, 30);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(1251, 593);
            tabPage2.TabIndex = 3;
            tabPage2.Text = "Tác giả";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            panel3.Controls.Add(txtTacGia);
            panel3.Controls.Add(label6);
            panel3.Controls.Add(btnThemTacGia);
            panel3.Controls.Add(btnXoaTacGia);
            panel3.Controls.Add(btnSuaTacGia);
            panel3.Location = new Point(6, 431);
            panel3.Name = "panel3";
            panel3.Size = new Size(1228, 146);
            panel3.TabIndex = 5;
            // 
            // txtTacGia
            // 
            txtTacGia.BorderStyle = BorderStyle.FixedSingle;
            txtTacGia.Location = new Point(98, 19);
            txtTacGia.Name = "txtTacGia";
            txtTacGia.Size = new Size(339, 29);
            txtTacGia.TabIndex = 13;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label6.AutoSize = true;
            label6.Location = new Point(19, 20);
            label6.Margin = new Padding(0);
            label6.Name = "label6";
            label6.Padding = new Padding(3);
            label6.Size = new Size(76, 27);
            label6.TabIndex = 12;
            label6.Text = "Thể loại";
            label6.TextAlign = ContentAlignment.BottomCenter;
            // 
            // btnThemTacGia
            // 
            btnThemTacGia.Font = new Font("Times New Roman", 12F);
            btnThemTacGia.Location = new Point(876, 18);
            btnThemTacGia.Name = "btnThemTacGia";
            btnThemTacGia.Size = new Size(75, 30);
            btnThemTacGia.TabIndex = 1;
            btnThemTacGia.Text = "Thêm";
            btnThemTacGia.UseVisualStyleBackColor = true;
            // 
            // btnXoaTacGia
            // 
            btnXoaTacGia.Font = new Font("Times New Roman", 12F);
            btnXoaTacGia.ForeColor = Color.Crimson;
            btnXoaTacGia.Location = new Point(1141, 18);
            btnXoaTacGia.Name = "btnXoaTacGia";
            btnXoaTacGia.Size = new Size(75, 30);
            btnXoaTacGia.TabIndex = 3;
            btnXoaTacGia.Text = "Xóa";
            btnXoaTacGia.UseVisualStyleBackColor = true;
            // 
            // btnSuaTacGia
            // 
            btnSuaTacGia.Font = new Font("Times New Roman", 12F);
            btnSuaTacGia.Location = new Point(1006, 18);
            btnSuaTacGia.Name = "btnSuaTacGia";
            btnSuaTacGia.Size = new Size(75, 28);
            btnSuaTacGia.TabIndex = 2;
            btnSuaTacGia.Text = "Sửa";
            btnSuaTacGia.UseVisualStyleBackColor = true;
            // 
            // dataGridView3
            // 
            dataGridView3.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView3.Location = new Point(6, 6);
            dataGridView3.Name = "dataGridView3";
            dataGridView3.Size = new Size(1228, 403);
            dataGridView3.TabIndex = 1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1283, 719);
            Controls.Add(tabcontrol1);
            Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Manga store manager";
            Load += Form1_Load;
            tabcontrol1.ResumeLayout(false);
            tabHome.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)numSoLuong).EndInit();
            ((System.ComponentModel.ISupportInitialize)numGiaBan).EndInit();
            tabTheLoai.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            tabPage2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView3).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabcontrol1;
        private TabPage tabHome;
        private Button btnXoa;
        private Button btnSua;
        private Button btnThem;
        private DataGridView dataGridView1;
        private Panel panel1;
        private TextBox txtTenSach;
        private Label label2;
        private Label label3;
        private Label label1;
        private NumericUpDown numSoLuong;
        private Label label5;
        private Label label4;
        private ComboBox cbTheLoai;
        private NumericUpDown numGiaBan;
        private TabPage tabTheLoai;
        private Panel panel2;
        private Label label8;
        private Button btnThemTheLoai;
        private Button btnXoaTheLoai;
        private Button btnSuaTheLoai;
        private DataGridView dataGridView2;
        private ComboBox cbTacGia;
        private TextBox txtTheLoai;
        private TabPage tabPage2;
        private Panel panel3;
        private TextBox txtTacGia;
        private Label label6;
        private Button btnThemTacGia;
        private Button btnXoaTacGia;
        private Button btnSuaTacGia;
        private DataGridView dataGridView3;
    }
}

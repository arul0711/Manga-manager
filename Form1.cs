using System;
using System.Collections.Generic;
using System.Windows.Forms;
using DBconnect; //khai báo namespace chứa database

namespace manga
{
    public partial class Form1 : Form
    {
        // Lệnh khởi tạo biến dbConnect để kết nối DBConnect - client
        private DBConnect dbConnect = new DBConnect();

        public Form1()
        {
            // Load giao diện từ file designer
            InitializeComponent();
            this.Text = "Manga Store Manager";
            Initialize();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string query = "SELECT title, tac_gia, year, the_loai, slot, created_date FROM books"; // Truy vấn để lấy dữ liệu từ bảng truyen
            var parameters = new Dictionary<string, object>();

            using (var reader = dbConnect.ExecuteSelectQuery(query, parameters))
            {
                while (reader.Read())
                {
                    // Lấy giá trị từ các cột
                    string title = reader["title"].ToString();
                    int tac_gia = reader.GetInt32(reader.GetOrdinal("tac_gia"));
                    int year = reader.GetInt32(reader.GetOrdinal("year"));
                    int the_loai = reader.GetInt32(reader.GetOrdinal("the_loai"));
                    int slot = reader.GetInt32(reader.GetOrdinal("slot"));
                    DateTime createdDate = reader.GetDateTime(reader.GetOrdinal("created_date"));

                    // Xử lý dữ liệu từ reader
                    Console.WriteLine($"Title: {title}, Author: {tac_gia}, Year: {year}, The loai: {the_loai}, So luong: {slot}, Created Date: {createdDate}");
                }
            }
        }

        private void Label1_Click(object sender, EventArgs e)
        {
            // Thêm mã xử lý sự kiện cho nhãn 1
        }

        private void Label2_Click(object sender, EventArgs e)
        {
            // Thêm mã xử lý sự kiện cho nhãn 2
        }

        private void CheckedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Thêm mã xử lý sự kiện cho danh sách kiểm tra
        }

        private void Initialize()
        {
            // Thêm mã khởi tạo tùy chỉnh nếu cần
        }
    }
}

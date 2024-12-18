﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Net.Http;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Google.Apis.Auth.OAuth2;
using Google.Apis.Util.Store;
using Newtonsoft.Json.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static Google.Apis.Books.v1.BooksService;

namespace GoogleBooks
{
    public partial class SearchBook : Form
    {
        private static readonly string apiKey = "AIzaSyBA4W3zRELkMnessvoSSjH_qhI8ixSr-oU";
        private static readonly string apiUrl = "https://www.googleapis.com/books/v1/volumes?q=";

        public SearchBook()
        {
            InitializeComponent();
        }

        private async void btnSearch_Click(object sender, EventArgs e)
        {
            string query = txtSearch.Text.Trim();
            if (string.IsNullOrEmpty(query))
            {
                MessageBox.Show("Vui lòng nhập từ khóa để tìm kiếm!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            progressBar.Visible = true;
            progressBar.Style = ProgressBarStyle.Marquee;

            try
            {
                using (HttpClient client = new HttpClient())
                {
                    string requestUrl = $"{apiUrl}{query}&key={apiKey}";
                    HttpResponseMessage response = await client.GetAsync(requestUrl);

                    if (response.IsSuccessStatusCode)
                    {
                        string jsonResponse = await response.Content.ReadAsStringAsync();
                        DisplayBooks(jsonResponse);
                    }
                    else
                    {
                        MessageBox.Show("Không tìm thấy sách nào hoặc lỗi kết nối!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Đã xảy ra lỗi: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                progressBar.Visible = false; // Ẩn ProgressBar khi hoàn thành
            }
        }
        private void DisplayBooks(string jsonResponse)
        {
            dgvBooks.Rows.Clear();

            JObject data = JObject.Parse(jsonResponse);
            var items = data["items"];
            if (items != null)
            {
                foreach (var item in items)
                {
                    string bookId = item["id"]?.ToString() ?? "Không rõ";  // Lấy BookID
                    string title = item["volumeInfo"]["title"]?.ToString() ?? "Không rõ";
                    string authors = item["volumeInfo"]["authors"]?.ToString() ?? "Không rõ";
                    string description = item["volumeInfo"]["description"]?.ToString() ?? "Không có mô tả";

                    // Thêm BookID và sách vào DataGridView
                    dgvBooks.Rows.Add(bookId, title, authors, description);
                }
            }
            else
            {
                MessageBox.Show("Không tìm thấy sách nào phù hợp!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void dgvBooks_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                // Lấy BookID từ hàng được chọn
                string bookId = dgvBooks.Rows[e.RowIndex].Cells[0].Value?.ToString() ?? string.Empty;

                // Mở Form2 và truyền BookID
                if (!string.IsNullOrEmpty(bookId))
                {
                    BookDetail form2 = new BookDetail(bookId);
                    form2.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Không có BookID để lấy thông tin chi tiết.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        
    }
}

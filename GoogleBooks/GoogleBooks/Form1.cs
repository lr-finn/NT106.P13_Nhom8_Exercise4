using System;
using System.Net.Http;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace GoogleBooks
{
    public partial class Form1 : Form
    {
        private static readonly string apiKey = "AIzaSyCcKcLfXBpRCmv4pzhdl-sDmd1ktse8rDo";
        private static readonly string apiUrl = "https://www.googleapis.com/books/v1/volumes?q=";
        public Form1()
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

            // Phân tích JSON để lấy thông tin sách
            JObject data = JObject.Parse(jsonResponse);
            var items = data["items"];
            if (items != null)
            {
                foreach (var item in items)
                {
                    string title = item["volumeInfo"]["title"]?.ToString() ?? "Không rõ";
                    string authors = item["volumeInfo"]["authors"]?.ToString() ?? "Không rõ";
                    string description = item["volumeInfo"]["description"]?.ToString() ?? "Không có mô tả";

                    // Thêm sách vào DataGridView
                    dgvBooks.Rows.Add(title, authors, description);
                }
            }
            else
            {
                MessageBox.Show("Không tìm thấy sách nào phù hợp!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}

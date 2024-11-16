using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Http;
using Newtonsoft.Json;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Net;
using System.Text.RegularExpressions;

namespace GoogleBooks
{
    public partial class BookDetail : Form
    {
        private HttpClient httpClient;
        private string bookID;
        public BookDetail(string bookID)
        {
            InitializeComponent();
            this.bookID = bookID;
            httpClient = new HttpClient();
        }
        private async void Form2_Load(object sender, EventArgs e)
        {
            progressBar.Visible = true;
            progressBar.Style = ProgressBarStyle.Marquee;
            await FetchBookDetaildsAsync(bookID);
            progressBar.Visible = false;
            this.Load += new System.EventHandler(this.Form2_Load);

        }
        public class BookDetails
        {
            public VolumeInfo VolumeInfo { get; set; }
        }

        public class VolumeInfo
        {
            public string Title { get; set; }
            public string Subtitle { get; set; }
            public string[] Authors { get; set; }
            public string Publisher { get; set; }
            public string PublishedDate { get; set; }
            public string Description { get; set; }
            public int PageCount { get; set; }
            public string Language { get; set; }
            public string[] Categories { get; set; }
            public ImageLinks ImageLinks { get; set; }
        }

        public class ImageLinks
        {
            public string SmallThumbnail { get; set; }
            public string Thumbnail { get; set; }
        }
        /*private async void OnBookSelected(string BookID)
        {
            progressBar.Visible = true;
            progressBar.Style = ProgressBarStyle.Marquee;
            await FetchBookDetaildsAsync(BookID);
            progressBar.Visible = false;
        }*/
        private async Task FetchBookDetaildsAsync(string bookId)
        {
            try
            {
                string apiUrl = $"https://www.googleapis.com/books/v1/volumes/{bookId}";
                HttpResponseMessage response = await httpClient.GetAsync(apiUrl);
                response.EnsureSuccessStatusCode();

                // Đọc và phân tích JSON từ API
                string jsonResponse = await response.Content.ReadAsStringAsync();
                var bookDetails = JsonConvert.DeserializeObject<BookDetails>(jsonResponse);

                // Hiển thị thông tin chi tiết sách
                DisplayBookDetails(bookDetails);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi tải sách: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void DisplayBookDetails(BookDetails bookDetails)
        {
            if (bookDetails != null && bookDetails.VolumeInfo != null)
            {
                var info = bookDetails.VolumeInfo;

                var details = $"Tên sách: {info.Title}\n" +
                              $"Phụ đề: {info.Subtitle}\n" +
                              $"Tác giả: {string.Join(", ", info.Authors ?? new string[] { "Không rõ" })}\n" +
                              $"Nhà xuất bản: {info.Publisher}\n" +
                              $"Mô tả: {info.Description}\n" +
                              $"Số trang: {info.PageCount}\n" +
                              $"Ngày xuất bản: {info.PublishedDate}\n" +
                              $"Ngôn ngữ: {info.Language}\n" +
                              $"Thể loại: {string.Join(", ", info.Categories ?? new string[] { "Không rõ" })}\n";

                rtbBookDetails.Text = details;
                if (info.ImageLinks?.Thumbnail != null)
                {
                    rtbBookDetails.Text += $"\nXem bìa sách tại: {info.ImageLinks.Thumbnail}";
                }
            }
            else
            {
                rtbBookDetails.Text = "Không tìm thấy thông tin chi tiết của sách.";
            }
        }

       

    }
}

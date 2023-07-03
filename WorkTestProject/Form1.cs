using System.ComponentModel;
using System.Net;
using System.Net.Http.Json;
using System.Text.Json.Serialization;

namespace WorkTestProject
{
    public partial class Form1 : Form
    {
        private HttpClient _client = new HttpClient();
        private string _url = @"https://fakerapi.it/api/v1/images?_quantity=30&_type=any&_height=300";

        DataResonse? _dataResonse;

        public Form1()
        {
            InitializeComponent();
        }

        private async void Form1_Load(object sender, EventArgs e)
        {
            var response = await _client.GetAsync(_url);

            if (!response.IsSuccessStatusCode)
            {
                MessageBox.Show(response.StatusCode.ToString() + "Error Connection");
                return;
            }

            _dataResonse = await response.Content.ReadFromJsonAsync<DataResonse>();

            if (_dataResonse is null)
            {
                MessageBox.Show("Container Data is Empty");
                return;
            }

            listBoxTitles.DataSource = _dataResonse.Data;
            listBoxTitles.DisplayMember = "title";
        }

        private void listBoxTitles_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            int index = listBoxTitles.IndexFromPoint(e.Location);

            DataItemForm dataItemForm = new DataItemForm()
            {
                Item = _dataResonse!.Data.ElementAt(index)
            };

            dataItemForm.ShowDialog();
        }
    }

    public record DataResonse(string Status, int Code, int Total, BindingList<DataItem> Data);
    
    public class DataItem
    {
        public string Title { get; set; } = null!;
        public string Description { get; set; } = null!;
        public string Url { get; set; } = null!;
    }

}
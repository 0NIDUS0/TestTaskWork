
namespace WorkTestProject
{
    public partial class DataItemForm : Form
    {
        private Image _image = null!;
        public DataItemForm()
        {
            InitializeComponent();
        }

        private void DataItemForm_Load(object sender, EventArgs e)
        {
            dataItemBindingSource.DataSource = Item;
            pictureBox1.ImageLocation = Item.Url;
        }

        private void dataItemBindingSource_CurrentItemChanged(object sender, EventArgs e)
        {
            pictureBox1.ImageLocation = Item.Url;
        }

        public DataItem Item { get; set; } = null!;
    }
}

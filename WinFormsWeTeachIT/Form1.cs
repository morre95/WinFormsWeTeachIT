using System.Diagnostics;
using System.Windows.Forms;

namespace WinFormsWeTeachIT
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void goButton_Click(object sender, EventArgs e)
        {
            Navigate(addressBox.Text);
        }

        private void Navigate(String address)
        {
            if (String.IsNullOrEmpty(address)) return;
            if (address.Equals("about:blank")) return;
            if (!address.StartsWith("http://") &&
                !address.StartsWith("https://"))
            {
                address = "http://" + address;
            }
            try
            {
                webView21.Source = new Uri(address);
            }
            catch (UriFormatException)
            {
                return;
            }
        }

        private void Address_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Navigate(addressBox.Text);
            }
        }
    }
}

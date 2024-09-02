using System.Diagnostics;
using System.Windows.Forms;

namespace WinFormsWeTeachIT
{
    public partial class Form1 : Form
    {
        private List<string> BookList { get; set; }
        public Form1()
        {
            InitializeComponent();
            BookList = new();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            if (bookTxt.Text.Trim().Length > 0) 
            {
                SaveToList(bookTxt.Text.Trim());
            }
        }

        private void SaveToList(string book)
        {
            BookList.Add(book);
            foreach (string item in BookList) 
            { 
                Debug.WriteLine(item);
            }
        }

        private void Books_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && bookTxt.Text.Trim().Length > 0)
            {
                SaveToList(bookTxt.Text.Trim());
            }
        }
    }
}

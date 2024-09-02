using System.Diagnostics;
using System.Windows.Forms;

namespace WinFormsWeTeachIT
{
    public partial class Form1 : Form
    {
        private List<Book> BookList { get; set; }
        private readonly string FileName = "books.txt";

        public Form1()
        {
            InitializeComponent();
            BookList = new();

            if (File.Exists(FileName))
            {
                LoadBooks();
                GenerateRandomBook();
            }
            else
            {
                debugLabel.Text = "No file to read from";
            }
        }

        private void LoadBooks()
        {
            string[] lines = File.ReadAllLines(FileName);
            foreach (var item in lines)
            {
                string[] parts = item.Split("###");
                BookList.Add(new Book(parts[0], parts[1], parts[2], bool.Parse(parts[3])));
            }
        }

        private void SaveToFile(Book book)
        {
            if (File.Exists(FileName))
            {
                File.AppendAllText(FileName, Environment.NewLine + book.ToString(true));
            }
            else
            {
                File.WriteAllText(FileName, book.ToString(true));
            }
        }

        

        private void GenerateRandomBook()
        {
            if (File.Exists(FileName))
            {
                int index = Random.Shared.Next(BookList.Count);
                textBook.Text = BookList[index].ToString();
                checkBoxAvailable.Checked = BookList[index].Available;
            }
            else
            {
                debugLabel.Text = "No file to read from";
            }
        }

        private void buttonNew_Click(object sender, EventArgs e)
        {
            GenerateRandomBook();
        }

        private void CheckBoxAvailable_CheckedChanged(object sender, EventArgs e)
        {
            if (sender is CheckBox cBox)
            {
                cBox.ForeColor = cBox.Checked ? Color.Green : Color.Red;
            }
        }
    }

    public class Book
    {
        public string Name { get; set; }
        public string Author { get; set; }
        public string Genre { get; set; }
        public bool Available { get; set; }

        public Book(string name, string auther, string genre, bool available)
        {
            Name = name;
            Author = auther;
            Genre = genre;
            Available = available;
        }

        public override string ToString()
        {
            return $"{Name}, {Author}, {Genre}";
        }

        public string ToString(bool forFile)
        {
            return $"{Name}###{Author}###{Genre}###{Available}";
        }
    }
}

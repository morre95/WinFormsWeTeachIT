using System.Diagnostics;

namespace WinFormsWeTeachIT
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Add_Click(object sender, EventArgs e)
        {
            if (sender is Button)
            {
                listBox.Items.Add(textBox.Text);
                textBox.Text = string.Empty;
            }
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            if (listBox.SelectedItems.Count > 0 && listBox.SelectedItem != null)
            {
                listBox.Items.Remove(listBox.SelectedItem);
            }
            else
            {
                Debug.WriteLine("Du har inte valt något att ta bort");
            }
        }

        private void Insert_Click(object sender, EventArgs e)
        {
            if (listBox.SelectedItems.Count > 0 && listBox.SelectedItem != null)
            {
                listBox.Items.Insert(listBox.SelectedIndex, textBox.Text);
                textBox.Text = string.Empty;
            }
            else
            {
                Debug.WriteLine("Du har inte valt vart den ska läggas till");
            }
        }


        public void ShowMyImage(String fileToDisplay, int xSize, int ySize)
        {
            pictureBox1.ImageLocation = fileToDisplay;
            pictureBox1.ClientSize = new Size(xSize, ySize);
        }

        private void RadioBtn_Clicked(object sender, EventArgs e)
        {
            if (sender is RadioButton btn) 
            {
                switch (btn.Text) 
                {
                    case "Image 1":
                        ShowMyImage("https://picsum.photos/200", 200, 200);
                        break;
                    case "Image 2":
                        ShowMyImage("https://picsum.photos/id/237/200/200", 200, 200);
                        break;
                    case "Image 3":
                        ShowMyImage("https://picsum.photos/seed/picsum/200/200", 200, 200);
                        break;
                }
            }
        }
    }
}

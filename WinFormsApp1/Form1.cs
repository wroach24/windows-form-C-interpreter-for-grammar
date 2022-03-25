namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public OpenFileDialog ofd;
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            ofd = new OpenFileDialog();
            ofd.Filter = "Text files (*.txt)|*.txt";

        }
        private void executeButton_Click(object sender, EventArgs e)
        {

        }

        private void openFileDialog2_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
        {

        }

        private void openFileDialog1_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
        {
           
          
        }

    

        private void button1_Click(object sender, EventArgs e)
        {
            
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                MessageBox.Show("I love candy", ofd.FileName);
                string path = ofd.FileName;
                richTextBox1.Text = File.ReadAllText(path);

            }
        }
    }
}
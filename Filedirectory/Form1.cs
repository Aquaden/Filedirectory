namespace Filedirectory
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }



        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btnCrFolder_Click(object sender, EventArgs e)
        {
            string path = Path.Combine(@"C:\\Users\\user\\OneDrive\\İş masası\\", txtFoldName.Text);

            if (!Directory.Exists(path))
            {

                Directory.CreateDirectory(path);

            }
            else
            {
                Console.WriteLine("Directory already exists!");
            }

        }

        private void btnCreateFile_Click(object sender, EventArgs e)
        {
            folderBrowserDialog1.ShowDialog();
            string pth = folderBrowserDialog1.SelectedPath;
            string filePath = Path.Combine(pth, txtCrFilename.Text);
            File.Create(filePath);
        }

        private void btnWriteFile_Click(object sender, EventArgs e)
        {
            openFileDialog4.ShowDialog();
            string pth = openFileDialog4.FileName;
            File.WriteAllText(pth, txtWriteToFile.Text);
        }

        private void btnUpdFile_Click(object sender, EventArgs e)
        {
            openFileDialog2.ShowDialog();
            string pth = openFileDialog2.FileName;
            File.AppendAllText(pth, txtWriteToFile.Text);
        }

        private void btnDeleteFile_Click(object sender, EventArgs e)
        {
            openFileDialog3.ShowDialog();
            string pth = openFileDialog3.FileName;
            File.Delete(pth);
        }

        private void btnReadFile_Click(object sender, EventArgs e)
        {
            openFileDialog5.ShowDialog();
            string pth = openFileDialog5.FileName;
            rctxtReadFile.Text = File.ReadAllText(pth);
        }

        private void folderBrowserDialog1_HelpRequest(object sender, EventArgs e)
        {

        }
    }
}
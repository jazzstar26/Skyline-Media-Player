using System.Diagnostics;
using System.Windows.Forms;

namespace Skyline
{
    public partial class Form1 : Form
    {
        private object txtdirectory;

        public Form1()
        {
            InitializeComponent();
        }
        //File Open
        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var fileContent = string.Empty;
            var filePath = string.Empty;

            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = "c:\\";
                openFileDialog.Filter = "All files (*.*)|*.*|MKV Files (*.mkv)|*.mkv|AVI Files (*.avi)|*.avi|MP4 Files (*.mp4)|*.mp4||";
                openFileDialog.FilterIndex = 1;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    //Get the path of specified file
                    filePath = openFileDialog.FileName;

                    //Read the contents of the file into a stream
                    var fileStream = openFileDialog.OpenFile();

                    using (StreamReader reader = new StreamReader(fileStream))
                    {
                        fileContent = reader.ReadToEnd();
                    }
                }
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        //Open Directory
        private void openDirectoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folder = new FolderBrowserDialog();
            DialogResult result = folder.ShowDialog();
        }
        //Close
        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
        //Exit
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //Help
        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
        //View
        private void viewToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
        //Aspect Ratio
        private void aspectRatioToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
        //File
        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
        //Help
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
        //Check For Software Updates
        private void checkForSoftwareUpdatesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void aboutToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("Skyline Media Player");
        }
    }
}
using System.Windows.Forms;

namespace Skyline
{
    public partial class Form1 : Form
    {
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
                openFileDialog.Filter = "MKV files (*.mkv)|*.mkv|All files (*.*)|*.*|AVI Files (*.avi)|*.avi|MP4 Files (*.mp4)|*.mp4||";
                openFileDialog.FilterIndex = 2;
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
        //Open Directory
        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
        //Close
        private void button1_Click(object sender, EventArgs e)
        {

        }
        //Exit
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void closeToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        //About
        private void aboutToolStripMenuItem1_Click(object sender, EventArgs e)
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
        private void soToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
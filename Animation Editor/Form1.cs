using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Animation_Editor
{
    public partial class Form1 : Form
    {

        public string file;

        public SaveFileDialog extractYanmMotionOrPart = new SaveFileDialog();

        public Form1()
        {
            InitializeComponent();

        }


        private void OpenFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog OpenFile = new OpenFileDialog();
            OpenFile.Title = "Open 0000 file";
            OpenFile.Filter = "All files (*.*)|*.*";
            OpenFile.FileName = "*.*";
            if (OpenFile.ShowDialog() == DialogResult.OK)
                
            {
                YANMFileWindow.Nodes.Clear();
               
            }
            
        }

        private void openAnimation0000000AToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog OpenFile = new OpenFileDialog();
            OpenFile.Title = "Open 0000 file";
            OpenFile.Filter = "All files (*.*)|*.*";
            OpenFile.FileName = "*.*";
            if (OpenFile.ShowDialog() == DialogResult.OK)
                
            {
                YANMFileWindow.Nodes.Clear();
            }

        }


        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close(); //Basic ability to close the program via "File -> Exit"
        }

        private void aboutAnimationEditorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Animation Editor V0.0.1 by Jakey J. Pearce. Used for WWE Games.");

        }

        private void btnExtract_Click(object sender, EventArgs e)
        {
            
        }
        

        private void openCamera000AToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog OpenFile = new OpenFileDialog();
            OpenFile.Title = "Open 000A file";
            OpenFile.Filter = "All files (*.*)|*.*";
            OpenFile.FileName = "*.*";
            if (OpenFile.ShowDialog() == DialogResult.OK)
            {
                file = OpenFile.FileName;
                

            }

            {
                YANMFileWindow.Nodes.Clear();

            }
        }

        private void openYANMFileToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}

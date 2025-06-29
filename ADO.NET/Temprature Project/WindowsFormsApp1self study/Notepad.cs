using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1self_study
{
    public partial class Notepad : Form
    {
        string path;
        public Notepad()
        {
            InitializeComponent();
            path = null;
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
           if(saveASfiled.ShowDialog() == DialogResult.OK)
            {
                rtbox.SaveFile(saveASfiled.FileName);
                rtbox.Clear();
                path = null ;
            }
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (opfiledialog.ShowDialog()==DialogResult.OK ) {
                rtbox.LoadFile(opfiledialog.FileName);
                path= opfiledialog.FileName;
            }
        }

        private void Notepad_Load(object sender, EventArgs e)
        {

        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (path != null) { 
            
                rtbox.SaveFile(path);
                rtbox.Clear();
                path = null;
            }
            else
            {
                saveAsToolStripMenuItem_Click(null, null);
            }
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (rtbox.Text != "") {
                if (MessageBox.Show("Do you want to save this data ?", "confirm", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    saveAsToolStripMenuItem_Click(null, null); 
                }
            }
            path = null ;
            rtbox.Clear() ;
        }

        private void fontToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (fontD.ShowDialog() == DialogResult.OK) {
                if (rtbox.SelectedText!= "") {
                
                rtbox.SelectionFont = fontD.Font;

                }
                else
                {
                    rtbox.Font = fontD.Font;
                }
            
            }
        }

        private void colorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(colorD.ShowDialog()== DialogResult.OK){
            
                if (rtbox.SelectedText != "")
                {
                    rtbox.SelectionColor = colorD.Color;
                }else
                {
                    rtbox.ForeColor = colorD.Color;
                }
            
            
            }
        }

        private void backColorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (colorD.ShowDialog() == DialogResult.OK)
            {

                if (rtbox.SelectedText != "")
                {
                    rtbox.SelectionBackColor = colorD.Color;
                }
                else
                {
                    rtbox.BackColor = colorD.Color;
                }


            }
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to close this file ?", "confirm", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void aboutUSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This Notepad built by Moomen Abd Elshaheed \nAll copyrights are reserved © ");
        }

        private void printToolStripMenuItem_Click(object sender, EventArgs e)
        {
     }
    }
}

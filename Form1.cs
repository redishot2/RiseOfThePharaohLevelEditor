using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

// Coded by Natasha Martinez
// Form design by ^
namespace MapEditor
{
    public partial class Form1 : Form
    {
        NewLevel nel;
        EditStage ed;
        public Form1()
        {
            InitializeComponent();
            ed = new EditStage(this);
            nel = new NewLevel();
            nel.Main = this;
            ed.Main = this;
        }

        // Gets the level text name and then pulls up the editor window
        private void bLoad_Click(object sender, EventArgs e)
        {
            // Check to see if the name entered is valid
            StreamReader input = null;
            try
            {
                input = new StreamReader(textLoad.Text);
                // At this point, this is a valid file

                // Open the edit form
                ed = new EditStage(textLoad.Text, this);

                ed.Show();
                this.Visible = false;
            }
            catch (Exception er)
            {
                MessageBox.Show("Error! File does not exist", "Error");
            }
            finally
            {
                if(input != null)
                    input.Close();
            }
        }

        // Make a new level
        private void button1_Click(object sender, EventArgs e)
        {
            // Bring up the new level window
            if(nel.IsDisposed == true)
                nel = new NewLevel();

            nel.Show();
            this.Hide();
        }

        private void Quit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bClear_Click(object sender, EventArgs e)
        {
            textLoad.Text = "";
        }
    }
}

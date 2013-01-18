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
    public partial class NewLevel : Form
    {

        EditStage ed;
        Form1 main;

        public NewLevel()
        {
            InitializeComponent();
            ed = new EditStage(main);
        }

        // Properties
        public Form1 Main
        {
            get { return main; }
            set { main = value; }
        }
        public EditStage Ed
        {
            get { return ed; }
            set { ed = value; } 
        }

        private void bOkay_Click(object sender, EventArgs e)
        {
            // This button will make a new txt file with the name from textNewLevel
            // Write a new file
            StreamWriter write = null;
            try
            {
                write = new StreamWriter(textNewLevel.Text);
            }
            catch (Exception ert)
            {
                MessageBox.Show("Error making new file", "Error");
            }
            finally
            {
                if (write != null)
                    write.Close();
            }

            // Now bring the edit screen up with the file loaded
            if (ed.IsDisposed == true)
            {
                ed = new EditStage(textNewLevel.Text, main);
            }
            else
            {
                ed.File = textNewLevel.Text;
            }
            ed.Show();
            this.Close();
        }

        private void bCancel_Click(object sender, EventArgs e)
        {
            // Return to main menu
            this.Close();
            if (main.IsDisposed == true)
            {
                main = new Form1();
            }
            main.Show();
        }
    }
}

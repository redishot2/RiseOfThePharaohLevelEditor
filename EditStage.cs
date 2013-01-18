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
    public partial class EditStage : Form
    {
        private Form1 main;
        private string file;
        public List<String> loca;
        public List<string> xLoca;
        public List<string> yLoca;
        PictureBox newTile;
        int currentTexture; // 0 = Standing Enemy; 1 = Walking Enemy; 2 = Wall; 3 = Trap;
        bool fromTextfile;

        #region Constructors
        public EditStage(Form1 m)
        {
            main = m;
            InitializeComponent();
            StartUp();
        }

        public EditStage(string fileName, Form1 m)
        {
            file = fileName;
            InitializeComponent();
            main = m;
            StartUp();
        }
        #endregion

        // Properties
        public Form1 Main
        {
            get { return main; }
            set { main = value; }
        }
        public string File
        {
            get { return file; }
            set { file = value; StartStuffs(file); }
        }

        #region Buttons
        // Save everything to the txt file
        private void bSave_Click(object sender, EventArgs e)
        {
            // Save the file
            StreamWriter w = null;
            try
            {
                w = new StreamWriter(file);

                // Add the lines
                for (int i = 0; i < loca.Count; i++)
                {
                    w.Write(loca[i] + "\n");
                }
            }
            catch (Exception erty)
            {
                MessageBox.Show("Error saving" + erty.Message, "Error");
            }
            finally
            {
                if (w != null)
                    w.Close();

                // Change this form to the main screen
                if (main == null)
                {
                    main = new Form1();
                }

                main.Visible = true;
                this.Close();
            }
        }
        // Save the coodinates to an array (later to be written to the txt file)
        private void bSaveTile_Click(object sender, EventArgs e)
        {
            // Get the coordinates to save
            int x = newTile.Location.X;
            int y = newTile.Location.Y;

            // Scale it back to correct size
            x *= 2;
            y *= 2;

            // Switch statement to figure out which picture is being used
            switch (currentTexture)
            {
                case 0:  // Standing enemy
                    // Add tile to loca list (x + "," + y + "," + currentTexture)
                    loca.Add(x + "," + y + "," + currentTexture);
                    break;
                case 1:  // Walking enemy
                    // Add tile to loca list (x + "," + y + "," + currentTexture)
                    loca.Add(x + "," + y + "," + currentTexture);
                    break;
                case 2:  // Wall
                    // Add tile to loca list (x + "," + y)
                    loca.Add(x + "," + y);
                    break;
                case 3:  // Trap
                    // Add tile to loca list (x + "," + y + currentTexture)
                    loca.Add(x + "," + y + "," + currentTexture);
                    break;
            }

            
            // Disable ability to change loca with ^>v< buttons
            bUp.Enabled = false;
            bLeft.Enabled = false;
            bDown.Enabled = false;
            bRight.Enabled = false;

            // Dissable this button from clickable
            bSaveTile.Enabled = false;

            // Enable new tile button
            bNewTile.Enabled = true;
            bMovingEnemy.Enabled = true;
            bNewEnemy.Enabled = true;
            bTrap.Enabled = true;
            
        }
        // Allows for quick placement (x and y positions) with the text boxes
        private void bSetAsNewLocation_Click(object sender, EventArgs e)
        {
            int x = 0;
            int y = 0;

            // Make sure the things typed into the x && y location boxes are really numbers
            try
            {
                x = int.Parse(textXLoc.Text);
                y = int.Parse(textYLoc.Text);
            }
            catch (Exception err)
            {
                MessageBox.Show("Error moving! " + err.Message);
            }

            newTile.Location = new Point(x, y);
        }

        #region Add Picture Boxes
        // Add a platform
        private void bNewTile_Click(object sender, EventArgs e)
        {
            // Call the make new tile method
            fromTextfile = false;
            AddAPicture("tileYellow.png", 35, 15, 0, 0);
            currentTexture = 2;
        }
        // Add an enemy
        private void bNewEnemy_Click(object sender, EventArgs e)
        {
            fromTextfile = false;
            AddAPicture("enemy.png", 35, 35, 0 ,0);
            currentTexture = 0;
        }
        // Add a walking enemy
        private void button1_Click(object sender, EventArgs e)
        {
            fromTextfile = false;
            AddAPicture("walkingEnemy.png", 35, 35, 0, 0);
            currentTexture = 1;
        }
        // Add a trap
        private void bTrap_Click(object sender, EventArgs e)
        {
            fromTextfile = false;
            AddAPicture("trap.png", 15, 15, 0, 0);
            currentTexture = 3;
        }

        // A method to add things to the screen
        public void AddAPicture(string nameOfPictureFile, int width, int height, int locX, int locY)
        {
            newTile = new PictureBox();

            // Set the tile size
            newTile.Size = new Size(width, height);

            newTile.Image = new Bitmap(nameOfPictureFile);

            newTile.SizeMode = PictureBoxSizeMode.StretchImage;

            // Set loc to 0,0
            newTile.Location = new Point(locX, locY);

            if (fromTextfile != true)
            {
                // Disable the add buttons from being clickable
                bNewTile.Enabled = false;
                bNewEnemy.Enabled = false;
                bMovingEnemy.Enabled = false;
                bTrap.Enabled = false;

                // Enable place tile button
                bSaveTile.Enabled = true;

                // Enable the move arrows
                bUp.Enabled = true;
                bLeft.Enabled = true;
                bDown.Enabled = true;
                bRight.Enabled = true;
            }

            this.Controls.Add(newTile);

            newTile.BringToFront();
        }
        #endregion

        #region Move the Tile Buttons
        const int INCRAMENT = 4; 
        private void bUp_Click(object sender, EventArgs e)
        {
            int x = newTile.Location.X;
            int y = newTile.Location.Y;
            y -= INCRAMENT;
            newTile.Location = new Point(x, y);
            TextLocations();
        }

        private void bRight_Click(object sender, EventArgs e)
        {
            int x = newTile.Location.X;
            int y = newTile.Location.Y;
            x += INCRAMENT;
            newTile.Location = new Point(x, y);
            TextLocations();
        }

        private void bDown_Click(object sender, EventArgs e)
        {
            int x = newTile.Location.X;
            int y = newTile.Location.Y;
            y += INCRAMENT;
            newTile.Location = new Point(x, y);
            TextLocations();
        }

        private void bLeft_Click(object sender, EventArgs e)
        {
            int x = newTile.Location.X;
            int y = newTile.Location.Y;
            x -= INCRAMENT;
            newTile.Location = new Point(x, y);
            TextLocations();
        }
        #endregion
        #endregion
        
        public void StartStuffs(string fileName)
        {
            file = fileName;
            StreamReader r = null;

            // Read the file (already been tested to see if it exists)
            try
            {
                r = new StreamReader(file);
                loca = new List<string>();
                string woo = null;
                while ((woo = r.ReadLine()) != null)
                {
                    loca.Add(woo);
                }

                // Configure the picture to display the level platforms
                for (int i = 0; i < loca.Count; i++)
                {
                    // Splice the locations read in
                    string[] locations = loca[i].Split(',');
                    int[] numbas = new int[3];
                    for (int j = 0; j < locations.Length; j++)
                    {
                        numbas[j] = int.Parse(locations[j]);
                    }

                    // Add the tile to the screen
                    string nameOfFile = null;
                    int x = 0;
                    int y = 0;
                    switch (locations.Length)
                    {
                        case 2: // This is a platform
                            nameOfFile = "tileYellow.png";
                            x = 35;
                            y = 15;
                            break;
                        case 3: // This is an enemy
                            if (numbas[2] == 0)
                            {
                                nameOfFile = "enemy.png";
                                x = 35;
                                y = 35;
                            }
                            else if (numbas[2] == 1)
                            {
                                nameOfFile = "walkingEnemy.png";
                                x = 35;
                                y = 35;
                            }
                            break;
                    }
                    fromTextfile = true;
                    AddAPicture(nameOfFile, x, y, numbas[0], numbas[1]);
                }
            }
            catch (Exception ero)
            {
                Console.WriteLine("Error reading: " + ero.Message);
            }

            finally
            {
                if (r != null)
                    r.Close();
            }
        }

        // Update the location in the x && y text boxes
        public void TextLocations()
        {
            int textX = newTile.Location.X;
            textXLoc.Text = textX + "";
            int textY = newTile.Location.Y;
            textYLoc.Text = textY + "";
        }

        // Set up initial stuffs
        public void StartUp()
        {
            bUp.Enabled = false;
            bLeft.Enabled = false;
            bDown.Enabled = false;
            bRight.Enabled = false;
            bSaveTile.Enabled = false;
            textXLoc.Text = 0 + "";
            textYLoc.Text = 0 + "";
            loca = new List<string>();

            if(file != null)
                StartStuffs(file);
        }
    }
}

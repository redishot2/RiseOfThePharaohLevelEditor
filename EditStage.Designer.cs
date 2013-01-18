namespace MapEditor
{
    partial class EditStage
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditStage));
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textXLoc = new System.Windows.Forms.TextBox();
            this.textYLoc = new System.Windows.Forms.TextBox();
            this.bRight = new System.Windows.Forms.Button();
            this.bLeft = new System.Windows.Forms.Button();
            this.bDown = new System.Windows.Forms.Button();
            this.bUp = new System.Windows.Forms.Button();
            this.bSaveTile = new System.Windows.Forms.Button();
            this.bNewTile = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.bSave = new System.Windows.Forms.Button();
            this.bNewEnemy = new System.Windows.Forms.Button();
            this.bMovingEnemy = new System.Windows.Forms.Button();
            this.bSetAsNewLocation = new System.Windows.Forms.Button();
            this.bTrap = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(714, 313);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 13);
            this.label4.TabIndex = 28;
            this.label4.Text = "Loc. X:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(714, 339);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 27;
            this.label3.Text = "Loc. Y:";
            // 
            // textXLoc
            // 
            this.textXLoc.Location = new System.Drawing.Point(758, 310);
            this.textXLoc.Name = "textXLoc";
            this.textXLoc.Size = new System.Drawing.Size(65, 20);
            this.textXLoc.TabIndex = 26;
            // 
            // textYLoc
            // 
            this.textYLoc.Location = new System.Drawing.Point(758, 336);
            this.textYLoc.Name = "textYLoc";
            this.textYLoc.Size = new System.Drawing.Size(65, 20);
            this.textYLoc.TabIndex = 25;
            // 
            // bRight
            // 
            this.bRight.Location = new System.Drawing.Point(783, 213);
            this.bRight.Name = "bRight";
            this.bRight.Size = new System.Drawing.Size(81, 57);
            this.bRight.TabIndex = 24;
            this.bRight.Text = "Right";
            this.bRight.UseVisualStyleBackColor = true;
            this.bRight.Click += new System.EventHandler(this.bRight_Click);
            // 
            // bLeft
            // 
            this.bLeft.Location = new System.Drawing.Point(696, 213);
            this.bLeft.Name = "bLeft";
            this.bLeft.Size = new System.Drawing.Size(81, 57);
            this.bLeft.TabIndex = 23;
            this.bLeft.Text = "Left";
            this.bLeft.UseVisualStyleBackColor = true;
            this.bLeft.Click += new System.EventHandler(this.bLeft_Click);
            // 
            // bDown
            // 
            this.bDown.Location = new System.Drawing.Point(742, 255);
            this.bDown.Name = "bDown";
            this.bDown.Size = new System.Drawing.Size(81, 49);
            this.bDown.TabIndex = 22;
            this.bDown.Text = "Down";
            this.bDown.UseVisualStyleBackColor = true;
            this.bDown.Click += new System.EventHandler(this.bDown_Click);
            // 
            // bUp
            // 
            this.bUp.Location = new System.Drawing.Point(742, 178);
            this.bUp.Name = "bUp";
            this.bUp.Size = new System.Drawing.Size(81, 49);
            this.bUp.TabIndex = 21;
            this.bUp.Text = "Up";
            this.bUp.UseVisualStyleBackColor = true;
            this.bUp.Click += new System.EventHandler(this.bUp_Click);
            // 
            // bSaveTile
            // 
            this.bSaveTile.Location = new System.Drawing.Point(704, 117);
            this.bSaveTile.Name = "bSaveTile";
            this.bSaveTile.Size = new System.Drawing.Size(160, 22);
            this.bSaveTile.TabIndex = 20;
            this.bSaveTile.Text = "Place Tile";
            this.bSaveTile.UseVisualStyleBackColor = true;
            this.bSaveTile.Click += new System.EventHandler(this.bSaveTile_Click);
            // 
            // bNewTile
            // 
            this.bNewTile.Location = new System.Drawing.Point(704, 5);
            this.bNewTile.Name = "bNewTile";
            this.bNewTile.Size = new System.Drawing.Size(160, 22);
            this.bNewTile.TabIndex = 19;
            this.bNewTile.Text = "Make New Tile";
            this.bNewTile.UseVisualStyleBackColor = true;
            this.bNewTile.Click += new System.EventHandler(this.bNewTile_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 18;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-2, -4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(700, 400);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            // 
            // bSave
            // 
            this.bSave.Location = new System.Drawing.Point(704, 145);
            this.bSave.Name = "bSave";
            this.bSave.Size = new System.Drawing.Size(160, 22);
            this.bSave.TabIndex = 31;
            this.bSave.Text = "Save n Return to Menu";
            this.bSave.UseVisualStyleBackColor = true;
            this.bSave.Click += new System.EventHandler(this.bSave_Click);
            // 
            // bNewEnemy
            // 
            this.bNewEnemy.Location = new System.Drawing.Point(704, 33);
            this.bNewEnemy.Name = "bNewEnemy";
            this.bNewEnemy.Size = new System.Drawing.Size(160, 22);
            this.bNewEnemy.TabIndex = 32;
            this.bNewEnemy.Text = "Make New Enemy";
            this.bNewEnemy.UseVisualStyleBackColor = true;
            this.bNewEnemy.Click += new System.EventHandler(this.bNewEnemy_Click);
            // 
            // bMovingEnemy
            // 
            this.bMovingEnemy.Location = new System.Drawing.Point(704, 61);
            this.bMovingEnemy.Name = "bMovingEnemy";
            this.bMovingEnemy.Size = new System.Drawing.Size(160, 22);
            this.bMovingEnemy.TabIndex = 33;
            this.bMovingEnemy.Text = "Make New Walking Enemy";
            this.bMovingEnemy.UseVisualStyleBackColor = true;
            this.bMovingEnemy.Click += new System.EventHandler(this.button1_Click);
            // 
            // bSetAsNewLocation
            // 
            this.bSetAsNewLocation.Location = new System.Drawing.Point(704, 368);
            this.bSetAsNewLocation.Name = "bSetAsNewLocation";
            this.bSetAsNewLocation.Size = new System.Drawing.Size(160, 22);
            this.bSetAsNewLocation.TabIndex = 34;
            this.bSetAsNewLocation.Text = "Move Tile To Location";
            this.bSetAsNewLocation.UseVisualStyleBackColor = true;
            this.bSetAsNewLocation.Click += new System.EventHandler(this.bSetAsNewLocation_Click);
            // 
            // bTrap
            // 
            this.bTrap.Location = new System.Drawing.Point(704, 89);
            this.bTrap.Name = "bTrap";
            this.bTrap.Size = new System.Drawing.Size(160, 22);
            this.bTrap.TabIndex = 35;
            this.bTrap.Text = "Make New Trap";
            this.bTrap.UseVisualStyleBackColor = true;
            this.bTrap.Click += new System.EventHandler(this.bTrap_Click);
            // 
            // EditStage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(868, 402);
            this.Controls.Add(this.bTrap);
            this.Controls.Add(this.bSetAsNewLocation);
            this.Controls.Add(this.bMovingEnemy);
            this.Controls.Add(this.bNewEnemy);
            this.Controls.Add(this.bSave);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textXLoc);
            this.Controls.Add(this.textYLoc);
            this.Controls.Add(this.bRight);
            this.Controls.Add(this.bLeft);
            this.Controls.Add(this.bDown);
            this.Controls.Add(this.bUp);
            this.Controls.Add(this.bSaveTile);
            this.Controls.Add(this.bNewTile);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "EditStage";
            this.Text = "Level Editor";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textXLoc;
        private System.Windows.Forms.TextBox textYLoc;
        private System.Windows.Forms.Button bRight;
        private System.Windows.Forms.Button bLeft;
        private System.Windows.Forms.Button bDown;
        private System.Windows.Forms.Button bUp;
        private System.Windows.Forms.Button bSaveTile;
        private System.Windows.Forms.Button bNewTile;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button bSave;
        private System.Windows.Forms.Button bNewEnemy;
        private System.Windows.Forms.Button bMovingEnemy;
        private System.Windows.Forms.Button bSetAsNewLocation;
        private System.Windows.Forms.Button bTrap;
    }
}
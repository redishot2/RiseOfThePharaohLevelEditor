namespace MapEditor
{
    partial class NewLevel
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textNewLevel = new System.Windows.Forms.TextBox();
            this.bOkay = new System.Windows.Forms.Button();
            this.bCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Level Name (No Spaces):";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 1;
            // 
            // textNewLevel
            // 
            this.textNewLevel.Location = new System.Drawing.Point(10, 36);
            this.textNewLevel.Name = "textNewLevel";
            this.textNewLevel.Size = new System.Drawing.Size(136, 20);
            this.textNewLevel.TabIndex = 2;
            // 
            // bOkay
            // 
            this.bOkay.Location = new System.Drawing.Point(10, 62);
            this.bOkay.Name = "bOkay";
            this.bOkay.Size = new System.Drawing.Size(75, 23);
            this.bOkay.TabIndex = 3;
            this.bOkay.Text = "Okay";
            this.bOkay.UseVisualStyleBackColor = true;
            this.bOkay.Click += new System.EventHandler(this.bOkay_Click);
            // 
            // bCancel
            // 
            this.bCancel.Location = new System.Drawing.Point(91, 62);
            this.bCancel.Name = "bCancel";
            this.bCancel.Size = new System.Drawing.Size(56, 23);
            this.bCancel.TabIndex = 4;
            this.bCancel.Text = "Cancel";
            this.bCancel.UseVisualStyleBackColor = true;
            this.bCancel.Click += new System.EventHandler(this.bCancel_Click);
            // 
            // NewLevel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(159, 96);
            this.Controls.Add(this.bCancel);
            this.Controls.Add(this.bOkay);
            this.Controls.Add(this.textNewLevel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "NewLevel";
            this.Text = "New Level";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textNewLevel;
        private System.Windows.Forms.Button bOkay;
        private System.Windows.Forms.Button bCancel;
    }
}
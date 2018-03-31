namespace Prog4
{
    partial class Prog4Form
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
            this.orginLabel = new System.Windows.Forms.Label();
            this.destLabel = new System.Windows.Forms.Label();
            this.lengthLabel = new System.Windows.Forms.Label();
            this.widthLabel = new System.Windows.Forms.Label();
            this.heightLabel = new System.Windows.Forms.Label();
            this.weightLabel = new System.Windows.Forms.Label();
            this.orginTextBox = new System.Windows.Forms.TextBox();
            this.destTextBox = new System.Windows.Forms.TextBox();
            this.lengthTextBox = new System.Windows.Forms.TextBox();
            this.widthTextBox = new System.Windows.Forms.TextBox();
            this.heightTextBox = new System.Windows.Forms.TextBox();
            this.weightTextBox = new System.Windows.Forms.TextBox();
            this.addPackageButton = new System.Windows.Forms.Button();
            this.detailsButton = new System.Windows.Forms.Button();
            this.sendToButton = new System.Windows.Forms.Button();
            this.sendFromButton = new System.Windows.Forms.Button();
            this.packageListBox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // orginLabel
            // 
            this.orginLabel.AutoSize = true;
            this.orginLabel.Location = new System.Drawing.Point(25, 33);
            this.orginLabel.Name = "orginLabel";
            this.orginLabel.Size = new System.Drawing.Size(53, 13);
            this.orginLabel.TabIndex = 0;
            this.orginLabel.Text = "Orgin Zip:";
            // 
            // destLabel
            // 
            this.destLabel.AutoSize = true;
            this.destLabel.Location = new System.Drawing.Point(25, 59);
            this.destLabel.Name = "destLabel";
            this.destLabel.Size = new System.Drawing.Size(53, 13);
            this.destLabel.TabIndex = 1;
            this.destLabel.Text = "Dest. Zip:";
            // 
            // lengthLabel
            // 
            this.lengthLabel.AutoSize = true;
            this.lengthLabel.Location = new System.Drawing.Point(33, 85);
            this.lengthLabel.Name = "lengthLabel";
            this.lengthLabel.Size = new System.Drawing.Size(43, 13);
            this.lengthLabel.TabIndex = 2;
            this.lengthLabel.Text = "Length:";
            // 
            // widthLabel
            // 
            this.widthLabel.AutoSize = true;
            this.widthLabel.Location = new System.Drawing.Point(40, 111);
            this.widthLabel.Name = "widthLabel";
            this.widthLabel.Size = new System.Drawing.Size(38, 13);
            this.widthLabel.TabIndex = 3;
            this.widthLabel.Text = "Width:";
            // 
            // heightLabel
            // 
            this.heightLabel.AutoSize = true;
            this.heightLabel.Location = new System.Drawing.Point(37, 139);
            this.heightLabel.Name = "heightLabel";
            this.heightLabel.Size = new System.Drawing.Size(41, 13);
            this.heightLabel.TabIndex = 4;
            this.heightLabel.Text = "Height:";
            // 
            // weightLabel
            // 
            this.weightLabel.AutoSize = true;
            this.weightLabel.Location = new System.Drawing.Point(34, 165);
            this.weightLabel.Name = "weightLabel";
            this.weightLabel.Size = new System.Drawing.Size(44, 13);
            this.weightLabel.TabIndex = 5;
            this.weightLabel.Text = "Weight:";
            // 
            // orginTextBox
            // 
            this.orginTextBox.Location = new System.Drawing.Point(81, 30);
            this.orginTextBox.Name = "orginTextBox";
            this.orginTextBox.Size = new System.Drawing.Size(101, 20);
            this.orginTextBox.TabIndex = 6;
            // 
            // destTextBox
            // 
            this.destTextBox.Location = new System.Drawing.Point(82, 56);
            this.destTextBox.Name = "destTextBox";
            this.destTextBox.Size = new System.Drawing.Size(100, 20);
            this.destTextBox.TabIndex = 7;
            // 
            // lengthTextBox
            // 
            this.lengthTextBox.Location = new System.Drawing.Point(82, 82);
            this.lengthTextBox.Name = "lengthTextBox";
            this.lengthTextBox.Size = new System.Drawing.Size(100, 20);
            this.lengthTextBox.TabIndex = 8;
            // 
            // widthTextBox
            // 
            this.widthTextBox.Location = new System.Drawing.Point(81, 108);
            this.widthTextBox.Name = "widthTextBox";
            this.widthTextBox.Size = new System.Drawing.Size(101, 20);
            this.widthTextBox.TabIndex = 9;
            // 
            // heightTextBox
            // 
            this.heightTextBox.Location = new System.Drawing.Point(81, 136);
            this.heightTextBox.Name = "heightTextBox";
            this.heightTextBox.Size = new System.Drawing.Size(100, 20);
            this.heightTextBox.TabIndex = 10;
            // 
            // weightTextBox
            // 
            this.weightTextBox.Location = new System.Drawing.Point(81, 162);
            this.weightTextBox.Name = "weightTextBox";
            this.weightTextBox.Size = new System.Drawing.Size(100, 20);
            this.weightTextBox.TabIndex = 11;
            // 
            // addPackageButton
            // 
            this.addPackageButton.Location = new System.Drawing.Point(43, 198);
            this.addPackageButton.Name = "addPackageButton";
            this.addPackageButton.Size = new System.Drawing.Size(139, 28);
            this.addPackageButton.TabIndex = 13;
            this.addPackageButton.Text = "Add Ground Package";
            this.addPackageButton.UseVisualStyleBackColor = true;
            this.addPackageButton.Click += new System.EventHandler(this.addPackageButton_Click);
            // 
            // detailsButton
            // 
            this.detailsButton.Location = new System.Drawing.Point(346, 40);
            this.detailsButton.Name = "detailsButton";
            this.detailsButton.Size = new System.Drawing.Size(91, 32);
            this.detailsButton.TabIndex = 14;
            this.detailsButton.Text = "Details";
            this.detailsButton.UseVisualStyleBackColor = true;
            this.detailsButton.Click += new System.EventHandler(this.detailsButton_Click);
            // 
            // sendToButton
            // 
            this.sendToButton.Location = new System.Drawing.Point(346, 92);
            this.sendToButton.Name = "sendToButton";
            this.sendToButton.Size = new System.Drawing.Size(91, 32);
            this.sendToButton.TabIndex = 15;
            this.sendToButton.Text = "Send to UofL";
            this.sendToButton.UseVisualStyleBackColor = true;
            this.sendToButton.Click += new System.EventHandler(this.sendToButton_Click);
            // 
            // sendFromButton
            // 
            this.sendFromButton.Location = new System.Drawing.Point(346, 144);
            this.sendFromButton.Name = "sendFromButton";
            this.sendFromButton.Size = new System.Drawing.Size(91, 34);
            this.sendFromButton.TabIndex = 16;
            this.sendFromButton.Text = "Send from UofL";
            this.sendFromButton.UseVisualStyleBackColor = true;
            this.sendFromButton.Click += new System.EventHandler(this.sendFromButton_Click);
            // 
            // packageListBox
            // 
            this.packageListBox.FormattingEnabled = true;
            this.packageListBox.Location = new System.Drawing.Point(201, 30);
            this.packageListBox.Name = "packageListBox";
            this.packageListBox.Size = new System.Drawing.Size(139, 173);
            this.packageListBox.TabIndex = 17;
            // 
            // Prog4Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(443, 238);
            this.Controls.Add(this.packageListBox);
            this.Controls.Add(this.sendFromButton);
            this.Controls.Add(this.sendToButton);
            this.Controls.Add(this.detailsButton);
            this.Controls.Add(this.addPackageButton);
            this.Controls.Add(this.weightTextBox);
            this.Controls.Add(this.heightTextBox);
            this.Controls.Add(this.widthTextBox);
            this.Controls.Add(this.lengthTextBox);
            this.Controls.Add(this.destTextBox);
            this.Controls.Add(this.orginTextBox);
            this.Controls.Add(this.weightLabel);
            this.Controls.Add(this.heightLabel);
            this.Controls.Add(this.widthLabel);
            this.Controls.Add(this.lengthLabel);
            this.Controls.Add(this.destLabel);
            this.Controls.Add(this.orginLabel);
            this.Name = "Prog4Form";
            this.Text = "Program 4";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label orginLabel;
        private System.Windows.Forms.Label destLabel;
        private System.Windows.Forms.Label lengthLabel;
        private System.Windows.Forms.Label widthLabel;
        private System.Windows.Forms.Label heightLabel;
        private System.Windows.Forms.Label weightLabel;
        private System.Windows.Forms.TextBox orginTextBox;
        private System.Windows.Forms.TextBox destTextBox;
        private System.Windows.Forms.TextBox lengthTextBox;
        private System.Windows.Forms.TextBox widthTextBox;
        private System.Windows.Forms.TextBox heightTextBox;
        private System.Windows.Forms.TextBox weightTextBox;
        private System.Windows.Forms.Button addPackageButton;
        private System.Windows.Forms.Button detailsButton;
        private System.Windows.Forms.Button sendToButton;
        private System.Windows.Forms.Button sendFromButton;
        private System.Windows.Forms.ListBox packageListBox;
    }
}


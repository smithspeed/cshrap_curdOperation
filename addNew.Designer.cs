
namespace curdOperations
{
    partial class addNew
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
            this.namelabel = new System.Windows.Forms.Label();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.mobileTextBox = new System.Windows.Forms.TextBox();
            this.mobileLabel = new System.Windows.Forms.Label();
            this.emailIdTextBox = new System.Windows.Forms.TextBox();
            this.emailIdLabel = new System.Windows.Forms.Label();
            this.genderLabel = new System.Windows.Forms.Label();
            this.genderComboBox = new System.Windows.Forms.ComboBox();
            this.statusComboBox = new System.Windows.Forms.ComboBox();
            this.statusLabel = new System.Windows.Forms.Label();
            this.addButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // namelabel
            // 
            this.namelabel.AutoSize = true;
            this.namelabel.Location = new System.Drawing.Point(72, 20);
            this.namelabel.Name = "namelabel";
            this.namelabel.Size = new System.Drawing.Size(54, 13);
            this.namelabel.TabIndex = 0;
            this.namelabel.Text = "Full Name";
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(72, 37);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(236, 20);
            this.nameTextBox.TabIndex = 0;
            // 
            // mobileTextBox
            // 
            this.mobileTextBox.Location = new System.Drawing.Point(72, 100);
            this.mobileTextBox.MaxLength = 10;
            this.mobileTextBox.Name = "mobileTextBox";
            this.mobileTextBox.Size = new System.Drawing.Size(236, 20);
            this.mobileTextBox.TabIndex = 1;
            // 
            // mobileLabel
            // 
            this.mobileLabel.AutoSize = true;
            this.mobileLabel.Location = new System.Drawing.Point(72, 83);
            this.mobileLabel.Name = "mobileLabel";
            this.mobileLabel.Size = new System.Drawing.Size(38, 13);
            this.mobileLabel.TabIndex = 2;
            this.mobileLabel.Text = "Mobile";
            // 
            // emailIdTextBox
            // 
            this.emailIdTextBox.Location = new System.Drawing.Point(72, 160);
            this.emailIdTextBox.MaxLength = 100;
            this.emailIdTextBox.Name = "emailIdTextBox";
            this.emailIdTextBox.Size = new System.Drawing.Size(236, 20);
            this.emailIdTextBox.TabIndex = 2;
            // 
            // emailIdLabel
            // 
            this.emailIdLabel.AutoSize = true;
            this.emailIdLabel.Location = new System.Drawing.Point(72, 143);
            this.emailIdLabel.Name = "emailIdLabel";
            this.emailIdLabel.Size = new System.Drawing.Size(44, 13);
            this.emailIdLabel.TabIndex = 4;
            this.emailIdLabel.Text = "Email Id";
            // 
            // genderLabel
            // 
            this.genderLabel.AutoSize = true;
            this.genderLabel.Location = new System.Drawing.Point(72, 198);
            this.genderLabel.Name = "genderLabel";
            this.genderLabel.Size = new System.Drawing.Size(42, 13);
            this.genderLabel.TabIndex = 5;
            this.genderLabel.Text = "Gender";
            // 
            // genderComboBox
            // 
            this.genderComboBox.FormattingEnabled = true;
            this.genderComboBox.Items.AddRange(new object[] {
            "Select Gender",
            "Male",
            "Female"});
            this.genderComboBox.Location = new System.Drawing.Point(72, 214);
            this.genderComboBox.Name = "genderComboBox";
            this.genderComboBox.Size = new System.Drawing.Size(233, 21);
            this.genderComboBox.TabIndex = 3;
            // 
            // statusComboBox
            // 
            this.statusComboBox.FormattingEnabled = true;
            this.statusComboBox.Items.AddRange(new object[] {
            "Select Status",
            "Active",
            "Inactive"});
            this.statusComboBox.Location = new System.Drawing.Point(72, 272);
            this.statusComboBox.Name = "statusComboBox";
            this.statusComboBox.Size = new System.Drawing.Size(233, 21);
            this.statusComboBox.TabIndex = 4;
            // 
            // statusLabel
            // 
            this.statusLabel.AutoSize = true;
            this.statusLabel.Location = new System.Drawing.Point(72, 256);
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(37, 13);
            this.statusLabel.TabIndex = 7;
            this.statusLabel.Text = "Status";
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(199, 314);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(106, 32);
            this.addButton.TabIndex = 5;
            this.addButton.Text = "Add Student";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addStudent);
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(72, 314);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(106, 32);
            this.clearButton.TabIndex = 6;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            // 
            // addNew
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(396, 382);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.statusComboBox);
            this.Controls.Add(this.statusLabel);
            this.Controls.Add(this.genderComboBox);
            this.Controls.Add(this.genderLabel);
            this.Controls.Add(this.emailIdTextBox);
            this.Controls.Add(this.emailIdLabel);
            this.Controls.Add(this.mobileTextBox);
            this.Controls.Add(this.mobileLabel);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.namelabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "addNew";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Student";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label namelabel;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.TextBox mobileTextBox;
        private System.Windows.Forms.Label mobileLabel;
        private System.Windows.Forms.TextBox emailIdTextBox;
        private System.Windows.Forms.Label emailIdLabel;
        private System.Windows.Forms.Label genderLabel;
        private System.Windows.Forms.ComboBox genderComboBox;
        private System.Windows.Forms.ComboBox statusComboBox;
        private System.Windows.Forms.Label statusLabel;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button clearButton;
    }
}
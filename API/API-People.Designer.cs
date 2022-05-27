namespace API
{
    partial class API_People
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
            this.searchbutton = new System.Windows.Forms.Button();
            this.searchtextBox = new System.Windows.Forms.TextBox();
            this.dgvContact = new System.Windows.Forms.DataGridView();
            this.deletebutton = new System.Windows.Forms.Button();
            this.updatebutton = new System.Windows.Forms.Button();
            this.savebutton = new System.Windows.Forms.Button();
            this.cellphoneNumbertextBox = new System.Windows.Forms.TextBox();
            this.emailAddresstextBox = new System.Windows.Forms.TextBox();
            this.LastNametextBox = new System.Windows.Forms.TextBox();
            this.firstNametextBox = new System.Windows.Forms.TextBox();
            this.cellphoneNumerlabel = new System.Windows.Forms.Label();
            this.emailAddresslabel = new System.Windows.Forms.Label();
            this.lastNamelabel = new System.Windows.Forms.Label();
            this.firstNamelabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvContact)).BeginInit();
            this.SuspendLayout();
            // 
            // searchbutton
            // 
            this.searchbutton.Location = new System.Drawing.Point(603, 33);
            this.searchbutton.Name = "searchbutton";
            this.searchbutton.Size = new System.Drawing.Size(75, 23);
            this.searchbutton.TabIndex = 27;
            this.searchbutton.Text = "Search";
            this.searchbutton.UseVisualStyleBackColor = true;
            this.searchbutton.Click += new System.EventHandler(this.searchbutton_Click_1);
            // 
            // searchtextBox
            // 
            this.searchtextBox.Location = new System.Drawing.Point(386, 36);
            this.searchtextBox.Name = "searchtextBox";
            this.searchtextBox.Size = new System.Drawing.Size(190, 20);
            this.searchtextBox.TabIndex = 26;
            // 
            // dgvContact
            // 
            this.dgvContact.BackgroundColor = System.Drawing.Color.White;
            this.dgvContact.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvContact.Location = new System.Drawing.Point(386, 62);
            this.dgvContact.Name = "dgvContact";
            this.dgvContact.Size = new System.Drawing.Size(347, 185);
            this.dgvContact.TabIndex = 25;
            this.dgvContact.DoubleClick += new System.EventHandler(this.dgvContact_DoubleClick_1);
            // 
            // deletebutton
            // 
            this.deletebutton.Location = new System.Drawing.Point(150, 224);
            this.deletebutton.Name = "deletebutton";
            this.deletebutton.Size = new System.Drawing.Size(75, 23);
            this.deletebutton.TabIndex = 24;
            this.deletebutton.Text = "Delete";
            this.deletebutton.UseVisualStyleBackColor = true;
            this.deletebutton.Click += new System.EventHandler(this.deletebutton_Click_1);
            // 
            // updatebutton
            // 
            this.updatebutton.Location = new System.Drawing.Point(251, 224);
            this.updatebutton.Name = "updatebutton";
            this.updatebutton.Size = new System.Drawing.Size(75, 23);
            this.updatebutton.TabIndex = 23;
            this.updatebutton.Text = "Update";
            this.updatebutton.UseVisualStyleBackColor = true;
            this.updatebutton.Click += new System.EventHandler(this.updatebutton_Click);
            // 
            // savebutton
            // 
            this.savebutton.Location = new System.Drawing.Point(51, 224);
            this.savebutton.Name = "savebutton";
            this.savebutton.Size = new System.Drawing.Size(75, 23);
            this.savebutton.TabIndex = 22;
            this.savebutton.Text = "Save";
            this.savebutton.UseVisualStyleBackColor = true;
            this.savebutton.Click += new System.EventHandler(this.savebutton_Click);
            // 
            // cellphoneNumbertextBox
            // 
            this.cellphoneNumbertextBox.Location = new System.Drawing.Point(125, 173);
            this.cellphoneNumbertextBox.Name = "cellphoneNumbertextBox";
            this.cellphoneNumbertextBox.Size = new System.Drawing.Size(201, 20);
            this.cellphoneNumbertextBox.TabIndex = 21;
            // 
            // emailAddresstextBox
            // 
            this.emailAddresstextBox.Location = new System.Drawing.Point(125, 133);
            this.emailAddresstextBox.Name = "emailAddresstextBox";
            this.emailAddresstextBox.Size = new System.Drawing.Size(201, 20);
            this.emailAddresstextBox.TabIndex = 20;
            // 
            // LastNametextBox
            // 
            this.LastNametextBox.Location = new System.Drawing.Point(125, 97);
            this.LastNametextBox.Name = "LastNametextBox";
            this.LastNametextBox.Size = new System.Drawing.Size(201, 20);
            this.LastNametextBox.TabIndex = 19;
            // 
            // firstNametextBox
            // 
            this.firstNametextBox.Location = new System.Drawing.Point(125, 62);
            this.firstNametextBox.Name = "firstNametextBox";
            this.firstNametextBox.Size = new System.Drawing.Size(201, 20);
            this.firstNametextBox.TabIndex = 18;
            // 
            // cellphoneNumerlabel
            // 
            this.cellphoneNumerlabel.AutoSize = true;
            this.cellphoneNumerlabel.Location = new System.Drawing.Point(48, 176);
            this.cellphoneNumerlabel.Name = "cellphoneNumerlabel";
            this.cellphoneNumerlabel.Size = new System.Drawing.Size(54, 13);
            this.cellphoneNumerlabel.TabIndex = 17;
            this.cellphoneNumerlabel.Text = "Cellphone";
            // 
            // emailAddresslabel
            // 
            this.emailAddresslabel.AutoSize = true;
            this.emailAddresslabel.Location = new System.Drawing.Point(48, 133);
            this.emailAddresslabel.Name = "emailAddresslabel";
            this.emailAddresslabel.Size = new System.Drawing.Size(73, 13);
            this.emailAddresslabel.TabIndex = 16;
            this.emailAddresslabel.Text = "Email Address";
            // 
            // lastNamelabel
            // 
            this.lastNamelabel.AutoSize = true;
            this.lastNamelabel.Location = new System.Drawing.Point(48, 97);
            this.lastNamelabel.Name = "lastNamelabel";
            this.lastNamelabel.Size = new System.Drawing.Size(58, 13);
            this.lastNamelabel.TabIndex = 15;
            this.lastNamelabel.Text = "Last Name";
            // 
            // firstNamelabel
            // 
            this.firstNamelabel.AutoSize = true;
            this.firstNamelabel.Location = new System.Drawing.Point(48, 62);
            this.firstNamelabel.Name = "firstNamelabel";
            this.firstNamelabel.Size = new System.Drawing.Size(57, 13);
            this.firstNamelabel.TabIndex = 14;
            this.firstNamelabel.Text = "First Name";
            // 
            // API_People
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.searchbutton);
            this.Controls.Add(this.searchtextBox);
            this.Controls.Add(this.dgvContact);
            this.Controls.Add(this.deletebutton);
            this.Controls.Add(this.updatebutton);
            this.Controls.Add(this.savebutton);
            this.Controls.Add(this.cellphoneNumbertextBox);
            this.Controls.Add(this.emailAddresstextBox);
            this.Controls.Add(this.LastNametextBox);
            this.Controls.Add(this.firstNametextBox);
            this.Controls.Add(this.cellphoneNumerlabel);
            this.Controls.Add(this.emailAddresslabel);
            this.Controls.Add(this.lastNamelabel);
            this.Controls.Add(this.firstNamelabel);
            this.Name = "API_People";
            this.Text = "API_People";
            ((System.ComponentModel.ISupportInitialize)(this.dgvContact)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button searchbutton;
        private System.Windows.Forms.TextBox searchtextBox;
        private System.Windows.Forms.DataGridView dgvContact;
        private System.Windows.Forms.Button deletebutton;
        private System.Windows.Forms.Button updatebutton;
        private System.Windows.Forms.Button savebutton;
        private System.Windows.Forms.TextBox cellphoneNumbertextBox;
        private System.Windows.Forms.TextBox emailAddresstextBox;
        private System.Windows.Forms.TextBox LastNametextBox;
        private System.Windows.Forms.TextBox firstNametextBox;
        private System.Windows.Forms.Label cellphoneNumerlabel;
        private System.Windows.Forms.Label emailAddresslabel;
        private System.Windows.Forms.Label lastNamelabel;
        private System.Windows.Forms.Label firstNamelabel;
    }
}
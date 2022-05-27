namespace API
{
    partial class API_Tournaments
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
            this.dgvTournamnet = new System.Windows.Forms.DataGridView();
            this.deletebutton = new System.Windows.Forms.Button();
            this.updatebutton = new System.Windows.Forms.Button();
            this.savebutton = new System.Windows.Forms.Button();
            this.entryFeetextBox = new System.Windows.Forms.TextBox();
            this.tournamentNametextBox = new System.Windows.Forms.TextBox();
            this.entryFeelabel = new System.Windows.Forms.Label();
            this.tournamentNamelabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTournamnet)).BeginInit();
            this.SuspendLayout();
            // 
            // searchbutton
            // 
            this.searchbutton.Location = new System.Drawing.Point(617, 86);
            this.searchbutton.Name = "searchbutton";
            this.searchbutton.Size = new System.Drawing.Size(75, 23);
            this.searchbutton.TabIndex = 41;
            this.searchbutton.Text = "Search";
            this.searchbutton.UseVisualStyleBackColor = true;
            this.searchbutton.Click += new System.EventHandler(this.searchbutton_Click_1);
            // 
            // searchtextBox
            // 
            this.searchtextBox.Location = new System.Drawing.Point(400, 89);
            this.searchtextBox.Name = "searchtextBox";
            this.searchtextBox.Size = new System.Drawing.Size(190, 20);
            this.searchtextBox.TabIndex = 40;
            // 
            // dgvTournamnet
            // 
            this.dgvTournamnet.BackgroundColor = System.Drawing.Color.White;
            this.dgvTournamnet.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTournamnet.Location = new System.Drawing.Point(400, 115);
            this.dgvTournamnet.Name = "dgvTournamnet";
            this.dgvTournamnet.Size = new System.Drawing.Size(347, 185);
            this.dgvTournamnet.TabIndex = 39;
            this.dgvTournamnet.DoubleClick += new System.EventHandler(this.dgvTournamnet_DoubleClick);
            // 
            // deletebutton
            // 
            this.deletebutton.Location = new System.Drawing.Point(164, 277);
            this.deletebutton.Name = "deletebutton";
            this.deletebutton.Size = new System.Drawing.Size(75, 23);
            this.deletebutton.TabIndex = 38;
            this.deletebutton.Text = "Delete";
            this.deletebutton.UseVisualStyleBackColor = true;
            this.deletebutton.Click += new System.EventHandler(this.deletebutton_Click);
            // 
            // updatebutton
            // 
            this.updatebutton.Location = new System.Drawing.Point(265, 277);
            this.updatebutton.Name = "updatebutton";
            this.updatebutton.Size = new System.Drawing.Size(75, 23);
            this.updatebutton.TabIndex = 37;
            this.updatebutton.Text = "Update";
            this.updatebutton.UseVisualStyleBackColor = true;
            // 
            // savebutton
            // 
            this.savebutton.Location = new System.Drawing.Point(65, 277);
            this.savebutton.Name = "savebutton";
            this.savebutton.Size = new System.Drawing.Size(75, 23);
            this.savebutton.TabIndex = 36;
            this.savebutton.Text = "Save";
            this.savebutton.UseVisualStyleBackColor = true;
            this.savebutton.Click += new System.EventHandler(this.savebutton_Click);
            // 
            // entryFeetextBox
            // 
            this.entryFeetextBox.Location = new System.Drawing.Point(65, 207);
            this.entryFeetextBox.Name = "entryFeetextBox";
            this.entryFeetextBox.Size = new System.Drawing.Size(201, 20);
            this.entryFeetextBox.TabIndex = 33;
            // 
            // tournamentNametextBox
            // 
            this.tournamentNametextBox.Location = new System.Drawing.Point(65, 143);
            this.tournamentNametextBox.Name = "tournamentNametextBox";
            this.tournamentNametextBox.Size = new System.Drawing.Size(201, 20);
            this.tournamentNametextBox.TabIndex = 32;
            // 
            // entryFeelabel
            // 
            this.entryFeelabel.AutoSize = true;
            this.entryFeelabel.Location = new System.Drawing.Point(62, 181);
            this.entryFeelabel.Name = "entryFeelabel";
            this.entryFeelabel.Size = new System.Drawing.Size(52, 13);
            this.entryFeelabel.TabIndex = 29;
            this.entryFeelabel.Text = "Entry Fee";
            // 
            // tournamentNamelabel
            // 
            this.tournamentNamelabel.AutoSize = true;
            this.tournamentNamelabel.Location = new System.Drawing.Point(62, 115);
            this.tournamentNamelabel.Name = "tournamentNamelabel";
            this.tournamentNamelabel.Size = new System.Drawing.Size(95, 13);
            this.tournamentNamelabel.TabIndex = 28;
            this.tournamentNamelabel.Text = "Tournament Name";
            // 
            // API_Tournaments
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.searchbutton);
            this.Controls.Add(this.searchtextBox);
            this.Controls.Add(this.dgvTournamnet);
            this.Controls.Add(this.deletebutton);
            this.Controls.Add(this.updatebutton);
            this.Controls.Add(this.savebutton);
            this.Controls.Add(this.entryFeetextBox);
            this.Controls.Add(this.tournamentNametextBox);
            this.Controls.Add(this.entryFeelabel);
            this.Controls.Add(this.tournamentNamelabel);
            this.Name = "API_Tournaments";
            this.Text = "API_Tournaments";
            this.Load += new System.EventHandler(this.API_Tournaments_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTournamnet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button searchbutton;
        private System.Windows.Forms.TextBox searchtextBox;
        private System.Windows.Forms.DataGridView dgvTournamnet;
        private System.Windows.Forms.Button deletebutton;
        private System.Windows.Forms.Button updatebutton;
        private System.Windows.Forms.Button savebutton;
        private System.Windows.Forms.TextBox entryFeetextBox;
        private System.Windows.Forms.TextBox tournamentNametextBox;
        private System.Windows.Forms.Label entryFeelabel;
        private System.Windows.Forms.Label tournamentNamelabel;
    }
}
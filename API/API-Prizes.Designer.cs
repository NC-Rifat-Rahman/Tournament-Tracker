namespace API
{
    partial class API_Prizes
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
            this.dgvPrice = new System.Windows.Forms.DataGridView();
            this.deletebutton = new System.Windows.Forms.Button();
            this.updatebutton = new System.Windows.Forms.Button();
            this.savebutton = new System.Windows.Forms.Button();
            this.pricePercentagetextBox = new System.Windows.Forms.TextBox();
            this.prizeAmounttextBox = new System.Windows.Forms.TextBox();
            this.placeNametextBox = new System.Windows.Forms.TextBox();
            this.placeNumbertextBox = new System.Windows.Forms.TextBox();
            this.prizePercantagelabel = new System.Windows.Forms.Label();
            this.prizeAmountlabel = new System.Windows.Forms.Label();
            this.placeNamelabel = new System.Windows.Forms.Label();
            this.placeNumberlabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrice)).BeginInit();
            this.SuspendLayout();
            // 
            // searchbutton
            // 
            this.searchbutton.Location = new System.Drawing.Point(672, 81);
            this.searchbutton.Name = "searchbutton";
            this.searchbutton.Size = new System.Drawing.Size(75, 23);
            this.searchbutton.TabIndex = 41;
            this.searchbutton.Text = "Search";
            this.searchbutton.UseVisualStyleBackColor = true;
            this.searchbutton.Click += new System.EventHandler(this.searchbutton_Click);
            // 
            // searchtextBox
            // 
            this.searchtextBox.Location = new System.Drawing.Point(455, 84);
            this.searchtextBox.Name = "searchtextBox";
            this.searchtextBox.Size = new System.Drawing.Size(190, 20);
            this.searchtextBox.TabIndex = 40;
            // 
            // dgvPrice
            // 
            this.dgvPrice.BackgroundColor = System.Drawing.Color.White;
            this.dgvPrice.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPrice.Location = new System.Drawing.Point(455, 110);
            this.dgvPrice.Name = "dgvPrice";
            this.dgvPrice.Size = new System.Drawing.Size(347, 185);
            this.dgvPrice.TabIndex = 39;
            this.dgvPrice.DoubleClick += new System.EventHandler(this.dgvPrice_DoubleClick);
            // 
            // deletebutton
            // 
            this.deletebutton.Location = new System.Drawing.Point(156, 272);
            this.deletebutton.Name = "deletebutton";
            this.deletebutton.Size = new System.Drawing.Size(75, 23);
            this.deletebutton.TabIndex = 38;
            this.deletebutton.Text = "Delete";
            this.deletebutton.UseVisualStyleBackColor = true;
            this.deletebutton.Click += new System.EventHandler(this.deletebutton_Click);
            // 
            // updatebutton
            // 
            this.updatebutton.Location = new System.Drawing.Point(257, 272);
            this.updatebutton.Name = "updatebutton";
            this.updatebutton.Size = new System.Drawing.Size(75, 23);
            this.updatebutton.TabIndex = 37;
            this.updatebutton.Text = "Update";
            this.updatebutton.UseVisualStyleBackColor = true;
            // 
            // savebutton
            // 
            this.savebutton.Location = new System.Drawing.Point(57, 272);
            this.savebutton.Name = "savebutton";
            this.savebutton.Size = new System.Drawing.Size(75, 23);
            this.savebutton.TabIndex = 36;
            this.savebutton.Text = "Save";
            this.savebutton.UseVisualStyleBackColor = true;
            this.savebutton.Click += new System.EventHandler(this.savebutton_Click);
            // 
            // pricePercentagetextBox
            // 
            this.pricePercentagetextBox.Location = new System.Drawing.Point(156, 221);
            this.pricePercentagetextBox.Name = "pricePercentagetextBox";
            this.pricePercentagetextBox.Size = new System.Drawing.Size(201, 20);
            this.pricePercentagetextBox.TabIndex = 35;
            // 
            // prizeAmounttextBox
            // 
            this.prizeAmounttextBox.Location = new System.Drawing.Point(156, 181);
            this.prizeAmounttextBox.Name = "prizeAmounttextBox";
            this.prizeAmounttextBox.Size = new System.Drawing.Size(201, 20);
            this.prizeAmounttextBox.TabIndex = 34;
            // 
            // placeNametextBox
            // 
            this.placeNametextBox.Location = new System.Drawing.Point(156, 145);
            this.placeNametextBox.Name = "placeNametextBox";
            this.placeNametextBox.Size = new System.Drawing.Size(201, 20);
            this.placeNametextBox.TabIndex = 33;
            // 
            // placeNumbertextBox
            // 
            this.placeNumbertextBox.Location = new System.Drawing.Point(156, 110);
            this.placeNumbertextBox.Name = "placeNumbertextBox";
            this.placeNumbertextBox.Size = new System.Drawing.Size(201, 20);
            this.placeNumbertextBox.TabIndex = 32;
            // 
            // prizePercantagelabel
            // 
            this.prizePercantagelabel.AutoSize = true;
            this.prizePercantagelabel.Location = new System.Drawing.Point(54, 224);
            this.prizePercantagelabel.Name = "prizePercantagelabel";
            this.prizePercantagelabel.Size = new System.Drawing.Size(89, 13);
            this.prizePercantagelabel.TabIndex = 31;
            this.prizePercantagelabel.Text = "Price Percentage";
            // 
            // prizeAmountlabel
            // 
            this.prizeAmountlabel.AutoSize = true;
            this.prizeAmountlabel.Location = new System.Drawing.Point(54, 181);
            this.prizeAmountlabel.Name = "prizeAmountlabel";
            this.prizeAmountlabel.Size = new System.Drawing.Size(69, 13);
            this.prizeAmountlabel.TabIndex = 30;
            this.prizeAmountlabel.Text = "Prize Amount";
            // 
            // placeNamelabel
            // 
            this.placeNamelabel.AutoSize = true;
            this.placeNamelabel.Location = new System.Drawing.Point(54, 145);
            this.placeNamelabel.Name = "placeNamelabel";
            this.placeNamelabel.Size = new System.Drawing.Size(65, 13);
            this.placeNamelabel.TabIndex = 29;
            this.placeNamelabel.Text = "Place Name";
            // 
            // placeNumberlabel
            // 
            this.placeNumberlabel.AutoSize = true;
            this.placeNumberlabel.Location = new System.Drawing.Point(54, 110);
            this.placeNumberlabel.Name = "placeNumberlabel";
            this.placeNumberlabel.Size = new System.Drawing.Size(74, 13);
            this.placeNumberlabel.TabIndex = 28;
            this.placeNumberlabel.Text = "Place Number";
            // 
            // API_Prizes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(855, 416);
            this.Controls.Add(this.searchbutton);
            this.Controls.Add(this.searchtextBox);
            this.Controls.Add(this.dgvPrice);
            this.Controls.Add(this.deletebutton);
            this.Controls.Add(this.updatebutton);
            this.Controls.Add(this.savebutton);
            this.Controls.Add(this.pricePercentagetextBox);
            this.Controls.Add(this.prizeAmounttextBox);
            this.Controls.Add(this.placeNametextBox);
            this.Controls.Add(this.placeNumbertextBox);
            this.Controls.Add(this.prizePercantagelabel);
            this.Controls.Add(this.prizeAmountlabel);
            this.Controls.Add(this.placeNamelabel);
            this.Controls.Add(this.placeNumberlabel);
            this.Name = "API_Prizes";
            this.Text = "API_Prizes";
            this.Load += new System.EventHandler(this.API_Prizes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrice)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button searchbutton;
        private System.Windows.Forms.TextBox searchtextBox;
        private System.Windows.Forms.DataGridView dgvPrice;
        private System.Windows.Forms.Button deletebutton;
        private System.Windows.Forms.Button updatebutton;
        private System.Windows.Forms.Button savebutton;
        private System.Windows.Forms.TextBox pricePercentagetextBox;
        private System.Windows.Forms.TextBox prizeAmounttextBox;
        private System.Windows.Forms.TextBox placeNametextBox;
        private System.Windows.Forms.TextBox placeNumbertextBox;
        private System.Windows.Forms.Label prizePercantagelabel;
        private System.Windows.Forms.Label prizeAmountlabel;
        private System.Windows.Forms.Label placeNamelabel;
        private System.Windows.Forms.Label placeNumberlabel;
    }
}
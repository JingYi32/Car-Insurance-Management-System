namespace IOOP_Assignment___Car_Insurance_Management_System
{
    partial class Searching_Page
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
            this.btnMainPage = new System.Windows.Forms.Button();
            this.btnCUST = new System.Windows.Forms.Button();
            this.btnINS = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.dgvSearchResult = new System.Windows.Forms.DataGridView();
            this.cbSelect = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSearchResult)).BeginInit();
            this.SuspendLayout();
            // 
            // btnMainPage
            // 
            this.btnMainPage.BackColor = System.Drawing.Color.CadetBlue;
            this.btnMainPage.ForeColor = System.Drawing.Color.White;
            this.btnMainPage.Location = new System.Drawing.Point(98, 649);
            this.btnMainPage.Name = "btnMainPage";
            this.btnMainPage.Size = new System.Drawing.Size(203, 49);
            this.btnMainPage.TabIndex = 3;
            this.btnMainPage.Text = "Back to Main Page";
            this.btnMainPage.UseVisualStyleBackColor = false;
            this.btnMainPage.Click += new System.EventHandler(this.btnMainPage_Click);
            // 
            // btnCUST
            // 
            this.btnCUST.BackColor = System.Drawing.Color.CadetBlue;
            this.btnCUST.ForeColor = System.Drawing.Color.White;
            this.btnCUST.Location = new System.Drawing.Point(458, 649);
            this.btnCUST.Name = "btnCUST";
            this.btnCUST.Size = new System.Drawing.Size(203, 49);
            this.btnCUST.TabIndex = 4;
            this.btnCUST.Text = "View Customer Profile";
            this.btnCUST.UseVisualStyleBackColor = false;
            this.btnCUST.Click += new System.EventHandler(this.btnCUST_Click);
            // 
            // btnINS
            // 
            this.btnINS.BackColor = System.Drawing.Color.CadetBlue;
            this.btnINS.ForeColor = System.Drawing.Color.White;
            this.btnINS.Location = new System.Drawing.Point(819, 649);
            this.btnINS.Name = "btnINS";
            this.btnINS.Size = new System.Drawing.Size(203, 49);
            this.btnINS.TabIndex = 5;
            this.btnINS.Text = "View Insurance Details";
            this.btnINS.UseVisualStyleBackColor = false;
            this.btnINS.Click += new System.EventHandler(this.btnINS_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.BackColor = System.Drawing.Color.CadetBlue;
            this.txtSearch.Font = new System.Drawing.Font("Gabriola", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.ForeColor = System.Drawing.SystemColors.Control;
            this.txtSearch.Location = new System.Drawing.Point(98, 112);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(924, 58);
            this.txtSearch.TabIndex = 1;
            this.txtSearch.Text = "Enter  to Search:";
            // 
            // dgvSearchResult
            // 
            this.dgvSearchResult.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSearchResult.Location = new System.Drawing.Point(98, 179);
            this.dgvSearchResult.Name = "dgvSearchResult";
            this.dgvSearchResult.RowHeadersWidth = 51;
            this.dgvSearchResult.RowTemplate.Height = 24;
            this.dgvSearchResult.Size = new System.Drawing.Size(924, 450);
            this.dgvSearchResult.TabIndex = 2;
            this.dgvSearchResult.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSearchResult_CellContentClick);
            // 
            // cbSelect
            // 
            this.cbSelect.FormattingEnabled = true;
            this.cbSelect.Items.AddRange(new object[] {
            "Customer ID",
            "Insurance ID"});
            this.cbSelect.Location = new System.Drawing.Point(98, 53);
            this.cbSelect.Name = "cbSelect";
            this.cbSelect.Size = new System.Drawing.Size(457, 50);
            this.cbSelect.TabIndex = 6;
            this.cbSelect.SelectedIndexChanged += new System.EventHandler(this.cbSelect_SelectedIndexChanged);
            // 
            // Searching_Page
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 42F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1102, 757);
            this.ControlBox = false;
            this.Controls.Add(this.cbSelect);
            this.Controls.Add(this.dgvSearchResult);
            this.Controls.Add(this.btnINS);
            this.Controls.Add(this.btnCUST);
            this.Controls.Add(this.btnMainPage);
            this.Controls.Add(this.txtSearch);
            this.Font = new System.Drawing.Font("Gabriola", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 8, 3, 8);
            this.Name = "Searching_Page";
            this.Text = "Searching_Page";
            this.Load += new System.EventHandler(this.Searching_Page_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSearchResult)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnMainPage;
        private System.Windows.Forms.Button btnCUST;
        private System.Windows.Forms.Button btnINS;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.DataGridView dgvSearchResult;
        private System.Windows.Forms.ComboBox cbSelect;
    }
}
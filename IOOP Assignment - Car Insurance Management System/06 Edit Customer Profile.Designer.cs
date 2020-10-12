namespace IOOP_Assignment___Car_Insurance_Management_System
{
    partial class Edit_Customer_Profile
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
            this.lblProfile = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblProfile
            // 
            this.lblProfile.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.lblProfile.Font = new System.Drawing.Font("Gabriola", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProfile.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lblProfile.Location = new System.Drawing.Point(348, 33);
            this.lblProfile.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblProfile.Name = "lblProfile";
            this.lblProfile.Size = new System.Drawing.Size(397, 76);
            this.lblProfile.TabIndex = 2;
            this.lblProfile.Text = "Mr./Mrs.____\'s Profile";
            // 
            // Edit_Customer_Profile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 50F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1102, 757);
            this.Controls.Add(this.lblProfile);
            this.Font = new System.Drawing.Font("Gabriola", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.Margin = new System.Windows.Forms.Padding(4, 9, 4, 9);
            this.Name = "Edit_Customer_Profile";
            this.Text = "Edit_Customer_Profile";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblProfile;
    }
}
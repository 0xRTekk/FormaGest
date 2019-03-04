namespace GestionFormation
{
    partial class AdminView
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
            this.btnUsersManagement = new System.Windows.Forms.Button();
            this.btnApplicationManagement = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnUsersManagement
            // 
            this.btnUsersManagement.Location = new System.Drawing.Point(77, 62);
            this.btnUsersManagement.Name = "btnUsersManagement";
            this.btnUsersManagement.Size = new System.Drawing.Size(158, 59);
            this.btnUsersManagement.TabIndex = 0;
            this.btnUsersManagement.Text = "Gestion des utilisateurs";
            this.btnUsersManagement.UseVisualStyleBackColor = true;
            // 
            // btnApplicationManagement
            // 
            this.btnApplicationManagement.Location = new System.Drawing.Point(77, 194);
            this.btnApplicationManagement.Name = "btnApplicationManagement";
            this.btnApplicationManagement.Size = new System.Drawing.Size(158, 59);
            this.btnApplicationManagement.TabIndex = 1;
            this.btnApplicationManagement.Text = "Gestion des candidatures";
            this.btnApplicationManagement.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(77, 338);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(158, 59);
            this.button3.TabIndex = 2;
            this.button3.Text = "Gestion du calendrier";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // AdminView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(316, 450);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.btnApplicationManagement);
            this.Controls.Add(this.btnUsersManagement);
            this.Name = "AdminView";
            this.Text = "Panneau administrateur";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnUsersManagement;
        private System.Windows.Forms.Button btnApplicationManagement;
        private System.Windows.Forms.Button button3;
    }
}
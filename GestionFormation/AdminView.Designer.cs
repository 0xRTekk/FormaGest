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
            this.btnCalendarManagement = new System.Windows.Forms.Button();
            this.btnTicketsView = new System.Windows.Forms.Button();
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
            this.btnUsersManagement.Click += new System.EventHandler(this.btnUsersManagement_Click);
            // 
            // btnCalendarManagement
            // 
            this.btnCalendarManagement.Location = new System.Drawing.Point(77, 199);
            this.btnCalendarManagement.Name = "btnCalendarManagement";
            this.btnCalendarManagement.Size = new System.Drawing.Size(158, 59);
            this.btnCalendarManagement.TabIndex = 2;
            this.btnCalendarManagement.Text = "Gestion du calendrier";
            this.btnCalendarManagement.UseVisualStyleBackColor = true;
            this.btnCalendarManagement.Click += new System.EventHandler(this.btnCalendarManagement_Click);
            // 
            // btnTicketsView
            // 
            this.btnTicketsView.Location = new System.Drawing.Point(77, 335);
            this.btnTicketsView.Name = "btnTicketsView";
            this.btnTicketsView.Size = new System.Drawing.Size(158, 59);
            this.btnTicketsView.TabIndex = 3;
            this.btnTicketsView.Text = "Gestion des tickets";
            this.btnTicketsView.UseVisualStyleBackColor = true;
            this.btnTicketsView.Click += new System.EventHandler(this.btnTicketsView_Click);
            // 
            // AdminView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(316, 456);
            this.Controls.Add(this.btnTicketsView);
            this.Controls.Add(this.btnCalendarManagement);
            this.Controls.Add(this.btnUsersManagement);
            this.Name = "AdminView";
            this.Text = "Panneau administrateur";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnUsersManagement;
        private System.Windows.Forms.Button btnCalendarManagement;
        private System.Windows.Forms.Button btnTicketsView;
    }
}
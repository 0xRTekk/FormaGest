namespace GestionFormation
{
    partial class AdminCalendarManagement
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
            this.cbTraining = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAddTraining = new System.Windows.Forms.Button();
            this.dgvSessions = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.btnRemoveTraining = new System.Windows.Forms.Button();
            this.btnAddSession = new System.Windows.Forms.Button();
            this.btnRemoveSession = new System.Windows.Forms.Button();
            this.btnEditSession = new System.Windows.Forms.Button();
            this.btnAdminView = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSessions)).BeginInit();
            this.SuspendLayout();
            // 
            // cbTraining
            // 
            this.cbTraining.FormattingEnabled = true;
            this.cbTraining.Location = new System.Drawing.Point(279, 27);
            this.cbTraining.Name = "cbTraining";
            this.cbTraining.Size = new System.Drawing.Size(258, 24);
            this.cbTraining.TabIndex = 0;
            this.cbTraining.SelectedIndexChanged += new System.EventHandler(this.cbTraining_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(191, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Formations:";
            // 
            // btnAddTraining
            // 
            this.btnAddTraining.Location = new System.Drawing.Point(543, 27);
            this.btnAddTraining.Name = "btnAddTraining";
            this.btnAddTraining.Size = new System.Drawing.Size(28, 24);
            this.btnAddTraining.TabIndex = 2;
            this.btnAddTraining.Text = "+";
            this.btnAddTraining.UseVisualStyleBackColor = true;
            this.btnAddTraining.Click += new System.EventHandler(this.btnAddTraining_Click);
            // 
            // dgvSessions
            // 
            this.dgvSessions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSessions.Location = new System.Drawing.Point(12, 126);
            this.dgvSessions.Name = "dgvSessions";
            this.dgvSessions.RowTemplate.Height = 24;
            this.dgvSessions.Size = new System.Drawing.Size(776, 253);
            this.dgvSessions.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Liste des sessions:";
            // 
            // btnRemoveTraining
            // 
            this.btnRemoveTraining.Location = new System.Drawing.Point(577, 26);
            this.btnRemoveTraining.Name = "btnRemoveTraining";
            this.btnRemoveTraining.Size = new System.Drawing.Size(28, 24);
            this.btnRemoveTraining.TabIndex = 5;
            this.btnRemoveTraining.Text = "-";
            this.btnRemoveTraining.UseVisualStyleBackColor = true;
            // 
            // btnAddSession
            // 
            this.btnAddSession.Location = new System.Drawing.Point(58, 398);
            this.btnAddSession.Name = "btnAddSession";
            this.btnAddSession.Size = new System.Drawing.Size(173, 40);
            this.btnAddSession.TabIndex = 6;
            this.btnAddSession.Text = "Ajouter session";
            this.btnAddSession.UseVisualStyleBackColor = true;
            this.btnAddSession.Click += new System.EventHandler(this.btnAddSession_Click);
            // 
            // btnRemoveSession
            // 
            this.btnRemoveSession.Location = new System.Drawing.Point(576, 398);
            this.btnRemoveSession.Name = "btnRemoveSession";
            this.btnRemoveSession.Size = new System.Drawing.Size(173, 40);
            this.btnRemoveSession.TabIndex = 7;
            this.btnRemoveSession.Text = "Supprimer session";
            this.btnRemoveSession.UseVisualStyleBackColor = true;
            this.btnRemoveSession.Click += new System.EventHandler(this.btnRemoveSession_Click);
            // 
            // btnEditSession
            // 
            this.btnEditSession.Location = new System.Drawing.Point(317, 398);
            this.btnEditSession.Name = "btnEditSession";
            this.btnEditSession.Size = new System.Drawing.Size(173, 40);
            this.btnEditSession.TabIndex = 8;
            this.btnEditSession.Text = "Modifier session";
            this.btnEditSession.UseVisualStyleBackColor = true;
            this.btnEditSession.Click += new System.EventHandler(this.btnEditSession_Click);
            // 
            // btnAdminView
            // 
            this.btnAdminView.Location = new System.Drawing.Point(12, 13);
            this.btnAdminView.Name = "btnAdminView";
            this.btnAdminView.Size = new System.Drawing.Size(75, 23);
            this.btnAdminView.TabIndex = 9;
            this.btnAdminView.Text = "Retour";
            this.btnAdminView.UseVisualStyleBackColor = true;
            this.btnAdminView.Click += new System.EventHandler(this.btnAdminView_Click);
            // 
            // AdminCalendarManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnAdminView);
            this.Controls.Add(this.btnEditSession);
            this.Controls.Add(this.btnRemoveSession);
            this.Controls.Add(this.btnAddSession);
            this.Controls.Add(this.btnRemoveTraining);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgvSessions);
            this.Controls.Add(this.btnAddTraining);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbTraining);
            this.Name = "AdminCalendarManagement";
            this.Text = "Gestion du calendrier";
            this.Load += new System.EventHandler(this.AdminCalendarManagement_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSessions)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbTraining;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAddTraining;
        private System.Windows.Forms.DataGridView dgvSessions;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnRemoveTraining;
        private System.Windows.Forms.Button btnAddSession;
        private System.Windows.Forms.Button btnRemoveSession;
        private System.Windows.Forms.Button btnEditSession;
        private System.Windows.Forms.Button btnAdminView;
    }
}
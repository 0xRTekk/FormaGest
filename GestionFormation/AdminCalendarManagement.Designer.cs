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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.cbTraining = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAddTraining = new System.Windows.Forms.Button();
            this.dgvSessions = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAddSession = new System.Windows.Forms.Button();
            this.btnRemoveSession = new System.Windows.Forms.Button();
            this.btnEditSession = new System.Windows.Forms.Button();
            this.btnAdminView = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSessions)).BeginInit();
            this.SuspendLayout();
            // 
            // cbTraining
            // 
            this.cbTraining.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTraining.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
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
            this.btnAddTraining.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.btnAddTraining.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddTraining.Location = new System.Drawing.Point(296, 67);
            this.btnAddTraining.Name = "btnAddTraining";
            this.btnAddTraining.Size = new System.Drawing.Size(206, 42);
            this.btnAddTraining.TabIndex = 2;
            this.btnAddTraining.Text = "Ajouter une formation";
            this.btnAddTraining.UseVisualStyleBackColor = true;
            this.btnAddTraining.Click += new System.EventHandler(this.btnAddTraining_Click);
            // 
            // dgvSessions
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgvSessions.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvSessions.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgvSessions.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvSessions.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvSessions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSessions.Location = new System.Drawing.Point(12, 126);
            this.dgvSessions.MultiSelect = false;
            this.dgvSessions.Name = "dgvSessions";
            this.dgvSessions.ReadOnly = true;
            this.dgvSessions.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvSessions.RowHeadersVisible = false;
            this.dgvSessions.RowTemplate.Height = 24;
            this.dgvSessions.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
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
            // btnAddSession
            // 
            this.btnAddSession.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.btnAddSession.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
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
            this.btnRemoveSession.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.btnRemoveSession.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
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
            this.btnEditSession.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.btnEditSession.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
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
            this.btnAdminView.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.btnAdminView.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdminView.Location = new System.Drawing.Point(12, 13);
            this.btnAdminView.Name = "btnAdminView";
            this.btnAdminView.Size = new System.Drawing.Size(75, 34);
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
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgvSessions);
            this.Controls.Add(this.btnAddTraining);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbTraining);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
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
        private System.Windows.Forms.Button btnAddSession;
        private System.Windows.Forms.Button btnRemoveSession;
        private System.Windows.Forms.Button btnEditSession;
        private System.Windows.Forms.Button btnAdminView;
    }
}
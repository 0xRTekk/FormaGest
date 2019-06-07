namespace GestionFormation
{
    partial class AdminApplicationManagement
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnRefus = new System.Windows.Forms.Button();
            this.btnValidate = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvInterests = new System.Windows.Forms.DataGridView();
            this.btnBack = new System.Windows.Forms.Button();
            this.cbCandidat = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvSessions = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInterests)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSessions)).BeginInit();
            this.SuspendLayout();
            // 
            // btnRefus
            // 
            this.btnRefus.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.btnRefus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefus.Location = new System.Drawing.Point(180, 509);
            this.btnRefus.Name = "btnRefus";
            this.btnRefus.Size = new System.Drawing.Size(163, 50);
            this.btnRefus.TabIndex = 8;
            this.btnRefus.Text = "Refuser candidature";
            this.btnRefus.UseVisualStyleBackColor = true;
            this.btnRefus.Click += new System.EventHandler(this.btnRefus_Click);
            // 
            // btnValidate
            // 
            this.btnValidate.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.btnValidate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnValidate.Location = new System.Drawing.Point(432, 509);
            this.btnValidate.Name = "btnValidate";
            this.btnValidate.Size = new System.Drawing.Size(173, 50);
            this.btnValidate.TabIndex = 7;
            this.btnValidate.Text = "Valider candidature";
            this.btnValidate.UseVisualStyleBackColor = true;
            this.btnValidate.Click += new System.EventHandler(this.btnValidate_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 115);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "Liste des souhaits";
            // 
            // dgvInterests
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgvInterests.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvInterests.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgvInterests.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvInterests.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvInterests.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInterests.Location = new System.Drawing.Point(12, 135);
            this.dgvInterests.MultiSelect = false;
            this.dgvInterests.Name = "dgvInterests";
            this.dgvInterests.ReadOnly = true;
            this.dgvInterests.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvInterests.RowHeadersVisible = false;
            this.dgvInterests.RowTemplate.Height = 24;
            this.dgvInterests.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvInterests.Size = new System.Drawing.Size(175, 339);
            this.dgvInterests.TabIndex = 5;
            this.dgvInterests.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvInterests_CellMouseDoubleClick);
            // 
            // btnBack
            // 
            this.btnBack.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Location = new System.Drawing.Point(16, 13);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 33);
            this.btnBack.TabIndex = 10;
            this.btnBack.Text = "Retour";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnAdminView_Click);
            // 
            // cbCandidat
            // 
            this.cbCandidat.FormattingEnabled = true;
            this.cbCandidat.Location = new System.Drawing.Point(285, 76);
            this.cbCandidat.Name = "cbCandidat";
            this.cbCandidat.Size = new System.Drawing.Size(213, 24);
            this.cbCandidat.TabIndex = 11;
            this.cbCandidat.SelectedIndexChanged += new System.EventHandler(this.cbCandidat_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(355, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 17);
            this.label2.TabIndex = 12;
            this.label2.Text = "Candidat :";
            // 
            // dgvSessions
            // 
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgvSessions.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvSessions.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgvSessions.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvSessions.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvSessions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSessions.Location = new System.Drawing.Point(224, 135);
            this.dgvSessions.MultiSelect = false;
            this.dgvSessions.Name = "dgvSessions";
            this.dgvSessions.ReadOnly = true;
            this.dgvSessions.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvSessions.RowHeadersVisible = false;
            this.dgvSessions.RowTemplate.Height = 24;
            this.dgvSessions.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSessions.Size = new System.Drawing.Size(564, 339);
            this.dgvSessions.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(221, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(140, 17);
            this.label3.TabIndex = 14;
            this.label3.Text = "Sessions disponibles";
            // 
            // AdminApplicationManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 591);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dgvSessions);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbCandidat);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnRefus);
            this.Controls.Add(this.btnValidate);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvInterests);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "AdminApplicationManagement";
            this.Text = "Gestion des candidatures";
            this.Load += new System.EventHandler(this.AdminApplicationManagement_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvInterests)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSessions)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnRefus;
        private System.Windows.Forms.Button btnValidate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvInterests;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.ComboBox cbCandidat;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvSessions;
        private System.Windows.Forms.Label label3;
    }
}
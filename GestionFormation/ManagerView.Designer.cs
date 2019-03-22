namespace GestionFormation
{
    partial class ManagerView
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
            this.label1 = new System.Windows.Forms.Label();
            this.cbTraining = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvSession = new System.Windows.Forms.DataGridView();
            this.btnAddApplication = new System.Windows.Forms.Button();
            this.btnEditConvocation = new System.Windows.Forms.Button();
            this.btnSendSms = new System.Windows.Forms.Button();
            this.btnRegistrationPreview = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSession)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(186, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Formation:";
            // 
            // cbTraining
            // 
            this.cbTraining.FormattingEnabled = true;
            this.cbTraining.Location = new System.Drawing.Point(268, 9);
            this.cbTraining.Name = "cbTraining";
            this.cbTraining.Size = new System.Drawing.Size(269, 24);
            this.cbTraining.TabIndex = 1;
            this.cbTraining.SelectedIndexChanged += new System.EventHandler(this.cbTraining_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(163, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Calendrier des sessions:";
            // 
            // dgvSession
            // 
            this.dgvSession.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSession.Location = new System.Drawing.Point(13, 103);
            this.dgvSession.Name = "dgvSession";
            this.dgvSession.RowTemplate.Height = 24;
            this.dgvSession.Size = new System.Drawing.Size(775, 204);
            this.dgvSession.TabIndex = 3;
            // 
            // btnAddApplication
            // 
            this.btnAddApplication.Location = new System.Drawing.Point(73, 328);
            this.btnAddApplication.Name = "btnAddApplication";
            this.btnAddApplication.Size = new System.Drawing.Size(665, 49);
            this.btnAddApplication.TabIndex = 4;
            this.btnAddApplication.Text = "Ajouter une candidature";
            this.btnAddApplication.UseVisualStyleBackColor = true;
            this.btnAddApplication.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnEditConvocation
            // 
            this.btnEditConvocation.Location = new System.Drawing.Point(84, 415);
            this.btnEditConvocation.Name = "btnEditConvocation";
            this.btnEditConvocation.Size = new System.Drawing.Size(156, 43);
            this.btnEditConvocation.TabIndex = 5;
            this.btnEditConvocation.Text = "Editer la convocation";
            this.btnEditConvocation.UseVisualStyleBackColor = true;
            // 
            // btnSendSms
            // 
            this.btnSendSms.Location = new System.Drawing.Point(312, 415);
            this.btnSendSms.Name = "btnSendSms";
            this.btnSendSms.Size = new System.Drawing.Size(157, 43);
            this.btnSendSms.TabIndex = 6;
            this.btnSendSms.Text = "Envoyer SMS";
            this.btnSendSms.UseVisualStyleBackColor = true;
            // 
            // btnRegistrationPreview
            // 
            this.btnRegistrationPreview.Location = new System.Drawing.Point(541, 415);
            this.btnRegistrationPreview.Name = "btnRegistrationPreview";
            this.btnRegistrationPreview.Size = new System.Drawing.Size(183, 43);
            this.btnRegistrationPreview.TabIndex = 7;
            this.btnRegistrationPreview.Text = "Feuille emargement";
            this.btnRegistrationPreview.UseVisualStyleBackColor = true;
            // 
            // ManagerView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 470);
            this.Controls.Add(this.btnRegistrationPreview);
            this.Controls.Add(this.btnSendSms);
            this.Controls.Add(this.btnEditConvocation);
            this.Controls.Add(this.btnAddApplication);
            this.Controls.Add(this.dgvSession);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbTraining);
            this.Controls.Add(this.label1);
            this.Name = "ManagerView";
            this.Text = "Panneau gestionnaire";
            this.Load += new System.EventHandler(this.ManagerView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSession)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbTraining;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvSession;
        private System.Windows.Forms.Button btnAddApplication;
        private System.Windows.Forms.Button btnEditConvocation;
        private System.Windows.Forms.Button btnSendSms;
        private System.Windows.Forms.Button btnRegistrationPreview;
    }
}
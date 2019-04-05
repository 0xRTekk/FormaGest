namespace GestionFormation.Views.Manager
{
    partial class ManagerCandidateInscription
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.cbTraining = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvSession = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.btnInscription = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSession)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(183, 12);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(447, 22);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = "// Le candidat <NOM> <PRENOM> est interesse par <NB> de fomrations.";
            // 
            // cbTraining
            // 
            this.cbTraining.FormattingEnabled = true;
            this.cbTraining.Location = new System.Drawing.Point(303, 58);
            this.cbTraining.Name = "cbTraining";
            this.cbTraining.Size = new System.Drawing.Size(263, 24);
            this.cbTraining.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(207, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Formations : ";
            // 
            // dgvSession
            // 
            this.dgvSession.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSession.Location = new System.Drawing.Point(12, 161);
            this.dgvSession.Name = "dgvSession";
            this.dgvSession.RowTemplate.Height = 24;
            this.dgvSession.Size = new System.Drawing.Size(776, 212);
            this.dgvSession.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 138);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Liste des sessions  ";
            // 
            // btnInscription
            // 
            this.btnInscription.Location = new System.Drawing.Point(194, 395);
            this.btnInscription.Name = "btnInscription";
            this.btnInscription.Size = new System.Drawing.Size(166, 43);
            this.btnInscription.TabIndex = 5;
            this.btnInscription.Text = "Inscrire candidat";
            this.btnInscription.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(423, 395);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(166, 43);
            this.btnCancel.TabIndex = 6;
            this.btnCancel.Text = "Annuler";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // ManagerCandidateInscription
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnInscription);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgvSession);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbTraining);
            this.Controls.Add(this.textBox1);
            this.Name = "ManagerCandidateInscription";
            this.Text = "ManagerCandidateInscription";
            ((System.ComponentModel.ISupportInitialize)(this.dgvSession)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ComboBox cbTraining;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvSession;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnInscription;
        private System.Windows.Forms.Button btnCancel;
    }
}
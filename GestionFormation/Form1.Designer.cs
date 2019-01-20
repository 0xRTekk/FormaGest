namespace GestionFormation
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.comboBoxFormations = new System.Windows.Forms.ComboBox();
            this.dataGridViewSessions = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSessions)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBoxFormations
            // 
            this.comboBoxFormations.FormattingEnabled = true;
            this.comboBoxFormations.Location = new System.Drawing.Point(26, 124);
            this.comboBoxFormations.Name = "comboBoxFormations";
            this.comboBoxFormations.Size = new System.Drawing.Size(379, 24);
            this.comboBoxFormations.TabIndex = 0;
            this.comboBoxFormations.Text = "Liste des formations";
            // 
            // dataGridViewSessions
            // 
            this.dataGridViewSessions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSessions.Location = new System.Drawing.Point(26, 202);
            this.dataGridViewSessions.Name = "dataGridViewSessions";
            this.dataGridViewSessions.RowTemplate.Height = 24;
            this.dataGridViewSessions.Size = new System.Drawing.Size(379, 230);
            this.dataGridViewSessions.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(431, 455);
            this.Controls.Add(this.dataGridViewSessions);
            this.Controls.Add(this.comboBoxFormations);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSessions)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxFormations;
        private System.Windows.Forms.DataGridView dataGridViewSessions;
    }
}


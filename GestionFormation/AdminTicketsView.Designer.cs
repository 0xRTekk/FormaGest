namespace GestionFormation
{
    partial class AdminTicketsView
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
            this.dgvListTickets = new System.Windows.Forms.DataGridView();
            this.lbTickets = new System.Windows.Forms.Label();
            this.rtbTicket = new System.Windows.Forms.RichTextBox();
            this.cbEtat = new System.Windows.Forms.ComboBox();
            this.btnValidate = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListTickets)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvListTickets
            // 
            this.dgvListTickets.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListTickets.Location = new System.Drawing.Point(12, 42);
            this.dgvListTickets.Name = "dgvListTickets";
            this.dgvListTickets.Size = new System.Drawing.Size(776, 235);
            this.dgvListTickets.TabIndex = 0;
            // 
            // lbTickets
            // 
            this.lbTickets.AutoSize = true;
            this.lbTickets.Location = new System.Drawing.Point(12, 9);
            this.lbTickets.Name = "lbTickets";
            this.lbTickets.Size = new System.Drawing.Size(117, 17);
            this.lbTickets.TabIndex = 1;
            this.lbTickets.Text = "Liste des tickets :";
            // 
            // rtbTicket
            // 
            this.rtbTicket.Location = new System.Drawing.Point(12, 340);
            this.rtbTicket.Name = "rtbTicket";
            this.rtbTicket.Size = new System.Drawing.Size(776, 224);
            this.rtbTicket.TabIndex = 2;
            this.rtbTicket.Text = "";
            // 
            // cbEtat
            // 
            this.cbEtat.FormattingEnabled = true;
            this.cbEtat.Location = new System.Drawing.Point(276, 586);
            this.cbEtat.Name = "cbEtat";
            this.cbEtat.Size = new System.Drawing.Size(219, 24);
            this.cbEtat.TabIndex = 3;
            // 
            // btnValidate
            // 
            this.btnValidate.Location = new System.Drawing.Point(235, 653);
            this.btnValidate.Name = "btnValidate";
            this.btnValidate.Size = new System.Drawing.Size(116, 43);
            this.btnValidate.TabIndex = 4;
            this.btnValidate.Text = "Valider";
            this.btnValidate.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(451, 653);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(120, 43);
            this.button2.TabIndex = 5;
            this.button2.Text = "Annuler";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // AdminTicketsView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 720);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnValidate);
            this.Controls.Add(this.cbEtat);
            this.Controls.Add(this.rtbTicket);
            this.Controls.Add(this.lbTickets);
            this.Controls.Add(this.dgvListTickets);
            this.Name = "AdminTicketsView";
            this.Text = "AdminTicketsView";
            ((System.ComponentModel.ISupportInitialize)(this.dgvListTickets)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvListTickets;
        private System.Windows.Forms.Label lbTickets;
        private System.Windows.Forms.RichTextBox rtbTicket;
        private System.Windows.Forms.ComboBox cbEtat;
        private System.Windows.Forms.Button btnValidate;
        private System.Windows.Forms.Button button2;
    }
}
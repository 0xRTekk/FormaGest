namespace GestionFormation
{
    partial class UserTicket
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
            this.lbLibelle = new System.Windows.Forms.Label();
            this.tbLibelle = new System.Windows.Forms.TextBox();
            this.lbDescription = new System.Windows.Forms.Label();
            this.rtbDescription = new System.Windows.Forms.RichTextBox();
            this.btnValidate = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbLibelle
            // 
            this.lbLibelle.AutoSize = true;
            this.lbLibelle.Location = new System.Drawing.Point(21, 42);
            this.lbLibelle.Name = "lbLibelle";
            this.lbLibelle.Size = new System.Drawing.Size(57, 17);
            this.lbLibelle.TabIndex = 0;
            this.lbLibelle.Text = "Libellé :";
            // 
            // tbLibelle
            // 
            this.tbLibelle.Location = new System.Drawing.Point(24, 62);
            this.tbLibelle.Name = "tbLibelle";
            this.tbLibelle.Size = new System.Drawing.Size(536, 22);
            this.tbLibelle.TabIndex = 1;
            // 
            // lbDescription
            // 
            this.lbDescription.AutoSize = true;
            this.lbDescription.Location = new System.Drawing.Point(21, 166);
            this.lbDescription.Name = "lbDescription";
            this.lbDescription.Size = new System.Drawing.Size(87, 17);
            this.lbDescription.TabIndex = 2;
            this.lbDescription.Text = "Description :";
            // 
            // rtbDescription
            // 
            this.rtbDescription.Location = new System.Drawing.Point(24, 186);
            this.rtbDescription.Name = "rtbDescription";
            this.rtbDescription.Size = new System.Drawing.Size(536, 173);
            this.rtbDescription.TabIndex = 3;
            this.rtbDescription.Text = "";
            // 
            // btnValidate
            // 
            this.btnValidate.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.btnValidate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnValidate.Location = new System.Drawing.Point(320, 379);
            this.btnValidate.Name = "btnValidate";
            this.btnValidate.Size = new System.Drawing.Size(90, 38);
            this.btnValidate.TabIndex = 4;
            this.btnValidate.Text = "Valider";
            this.btnValidate.UseVisualStyleBackColor = true;
            this.btnValidate.Click += new System.EventHandler(this.btnValidate_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Location = new System.Drawing.Point(166, 379);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(90, 38);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "Annuler";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // UserTicket
            // 
            this.AcceptButton = this.btnValidate;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(583, 429);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnValidate);
            this.Controls.Add(this.rtbDescription);
            this.Controls.Add(this.lbDescription);
            this.Controls.Add(this.tbLibelle);
            this.Controls.Add(this.lbLibelle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "UserTicket";
            this.Text = "UserTicket";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbLibelle;
        private System.Windows.Forms.TextBox tbLibelle;
        private System.Windows.Forms.Label lbDescription;
        private System.Windows.Forms.RichTextBox rtbDescription;
        private System.Windows.Forms.Button btnValidate;
        private System.Windows.Forms.Button btnCancel;
    }
}
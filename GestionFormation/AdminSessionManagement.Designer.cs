namespace GestionFormation
{
    partial class AdminSessionManagement
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbTraining = new System.Windows.Forms.TextBox();
            this.tbHour = new System.Windows.Forms.TextBox();
            this.tbDate = new System.Windows.Forms.TextBox();
            this.tbPlace = new System.Windows.Forms.TextBox();
            this.btnValidate = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(252, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Libellé de la formation:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Date:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(239, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Heure:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(457, 96);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Lieu:";
            // 
            // tbTraining
            // 
            this.tbTraining.Enabled = false;
            this.tbTraining.Location = new System.Drawing.Point(195, 29);
            this.tbTraining.Name = "tbTraining";
            this.tbTraining.Size = new System.Drawing.Size(270, 22);
            this.tbTraining.TabIndex = 4;
            // 
            // tbHour
            // 
            this.tbHour.Location = new System.Drawing.Point(242, 116);
            this.tbHour.Name = "tbHour";
            this.tbHour.Size = new System.Drawing.Size(172, 22);
            this.tbHour.TabIndex = 5;
            // 
            // tbDate
            // 
            this.tbDate.Location = new System.Drawing.Point(24, 116);
            this.tbDate.Name = "tbDate";
            this.tbDate.Size = new System.Drawing.Size(172, 22);
            this.tbDate.TabIndex = 6;
            // 
            // tbPlace
            // 
            this.tbPlace.Location = new System.Drawing.Point(460, 116);
            this.tbPlace.Name = "tbPlace";
            this.tbPlace.Size = new System.Drawing.Size(172, 22);
            this.tbPlace.TabIndex = 7;
            // 
            // btnValidate
            // 
            this.btnValidate.Location = new System.Drawing.Point(179, 190);
            this.btnValidate.Name = "btnValidate";
            this.btnValidate.Size = new System.Drawing.Size(114, 29);
            this.btnValidate.TabIndex = 8;
            this.btnValidate.Text = "Valider";
            this.btnValidate.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(385, 190);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(114, 29);
            this.btnCancel.TabIndex = 9;
            this.btnCancel.Text = "Annuler";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // AdminSessionManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(665, 231);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnValidate);
            this.Controls.Add(this.tbPlace);
            this.Controls.Add(this.tbDate);
            this.Controls.Add(this.tbHour);
            this.Controls.Add(this.tbTraining);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AdminSessionManagement";
            this.Text = "Gestion de session";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbTraining;
        private System.Windows.Forms.TextBox tbHour;
        private System.Windows.Forms.TextBox tbDate;
        private System.Windows.Forms.TextBox tbPlace;
        private System.Windows.Forms.Button btnValidate;
        private System.Windows.Forms.Button btnCancel;
    }
}
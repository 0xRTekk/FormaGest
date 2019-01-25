namespace GestionFormation
{
    partial class Form2
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
            this.labelFormation = new System.Windows.Forms.Label();
            this.textBoxFormation = new System.Windows.Forms.TextBox();
            this.labelSession = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dataGridViewInscrits = new System.Windows.Forms.DataGridView();
            this.dataGridViewParticipants = new System.Windows.Forms.DataGridView();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonValidate = new System.Windows.Forms.Button();
            this.buttonArrowLeft = new System.Windows.Forms.Button();
            this.buttonArrowRight = new System.Windows.Forms.Button();
            this.textBoxDateEnd = new System.Windows.Forms.TextBox();
            this.textBoxDateBegin = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewInscrits)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewParticipants)).BeginInit();
            this.SuspendLayout();
            // 
            // labelFormation
            // 
            this.labelFormation.AutoSize = true;
            this.labelFormation.Location = new System.Drawing.Point(210, 12);
            this.labelFormation.Name = "labelFormation";
            this.labelFormation.Size = new System.Drawing.Size(83, 17);
            this.labelFormation.TabIndex = 0;
            this.labelFormation.Text = "Formation : ";
            // 
            // textBoxFormation
            // 
            this.textBoxFormation.Location = new System.Drawing.Point(299, 9);
            this.textBoxFormation.Name = "textBoxFormation";
            this.textBoxFormation.Size = new System.Drawing.Size(181, 22);
            this.textBoxFormation.TabIndex = 1;
            // 
            // labelSession
            // 
            this.labelSession.AutoSize = true;
            this.labelSession.Location = new System.Drawing.Point(62, 84);
            this.labelSession.Name = "labelSession";
            this.labelSession.Size = new System.Drawing.Size(70, 17);
            this.labelSession.TabIndex = 2;
            this.labelSession.Text = "Session : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(91, 130);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Début :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(434, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "Fin : ";
            // 
            // dataGridViewInscrits
            // 
            this.dataGridViewInscrits.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewInscrits.Location = new System.Drawing.Point(15, 209);
            this.dataGridViewInscrits.Name = "dataGridViewInscrits";
            this.dataGridViewInscrits.RowTemplate.Height = 24;
            this.dataGridViewInscrits.Size = new System.Drawing.Size(334, 229);
            this.dataGridViewInscrits.TabIndex = 10;
            // 
            // dataGridViewParticipants
            // 
            this.dataGridViewParticipants.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewParticipants.Location = new System.Drawing.Point(454, 209);
            this.dataGridViewParticipants.Name = "dataGridViewParticipants";
            this.dataGridViewParticipants.RowTemplate.Height = 24;
            this.dataGridViewParticipants.Size = new System.Drawing.Size(334, 229);
            this.dataGridViewParticipants.TabIndex = 11;
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(234, 471);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(115, 45);
            this.buttonCancel.TabIndex = 12;
            this.buttonCancel.Text = "Annuler";
            this.buttonCancel.UseVisualStyleBackColor = true;
            // 
            // buttonValidate
            // 
            this.buttonValidate.Location = new System.Drawing.Point(454, 471);
            this.buttonValidate.Name = "buttonValidate";
            this.buttonValidate.Size = new System.Drawing.Size(115, 45);
            this.buttonValidate.TabIndex = 13;
            this.buttonValidate.Text = "Valider";
            this.buttonValidate.UseVisualStyleBackColor = true;
            // 
            // buttonArrowLeft
            // 
            this.buttonArrowLeft.Location = new System.Drawing.Point(355, 250);
            this.buttonArrowLeft.Name = "buttonArrowLeft";
            this.buttonArrowLeft.Size = new System.Drawing.Size(93, 74);
            this.buttonArrowLeft.TabIndex = 14;
            this.buttonArrowLeft.Text = "<=";
            this.buttonArrowLeft.UseVisualStyleBackColor = true;
            this.buttonArrowLeft.Click += new System.EventHandler(this.buttonArrowLeft_Click);
            // 
            // buttonArrowRight
            // 
            this.buttonArrowRight.Location = new System.Drawing.Point(355, 330);
            this.buttonArrowRight.Name = "buttonArrowRight";
            this.buttonArrowRight.Size = new System.Drawing.Size(93, 74);
            this.buttonArrowRight.TabIndex = 15;
            this.buttonArrowRight.Text = "=>";
            this.buttonArrowRight.UseVisualStyleBackColor = true;
            // 
            // textBoxDateEnd
            // 
            this.textBoxDateEnd.Location = new System.Drawing.Point(480, 130);
            this.textBoxDateEnd.Name = "textBoxDateEnd";
            this.textBoxDateEnd.Size = new System.Drawing.Size(166, 22);
            this.textBoxDateEnd.TabIndex = 16;
            // 
            // textBoxDateBegin
            // 
            this.textBoxDateBegin.Location = new System.Drawing.Point(151, 130);
            this.textBoxDateBegin.Name = "textBoxDateBegin";
            this.textBoxDateBegin.Size = new System.Drawing.Size(166, 22);
            this.textBoxDateBegin.TabIndex = 17;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 528);
            this.Controls.Add(this.textBoxDateBegin);
            this.Controls.Add(this.textBoxDateEnd);
            this.Controls.Add(this.buttonArrowRight);
            this.Controls.Add(this.buttonArrowLeft);
            this.Controls.Add(this.buttonValidate);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.dataGridViewParticipants);
            this.Controls.Add(this.dataGridViewInscrits);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labelSession);
            this.Controls.Add(this.textBoxFormation);
            this.Controls.Add(this.labelFormation);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewInscrits)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewParticipants)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelFormation;
        private System.Windows.Forms.TextBox textBoxFormation;
        private System.Windows.Forms.Label labelSession;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dataGridViewInscrits;
        private System.Windows.Forms.DataGridView dataGridViewParticipants;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonValidate;
        private System.Windows.Forms.Button buttonArrowLeft;
        private System.Windows.Forms.Button buttonArrowRight;
        private System.Windows.Forms.TextBox textBoxDateEnd;
        private System.Windows.Forms.TextBox textBoxDateBegin;
    }
}
namespace GestionFormation
{
    partial class AdminAddSession
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
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnValidate = new System.Windows.Forms.Button();
            this.tbPlace = new System.Windows.Forms.TextBox();
            this.tbTraining = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lbHourBegin = new System.Windows.Forms.Label();
            this.lbDate = new System.Windows.Forms.Label();
            this.lbTraining = new System.Windows.Forms.Label();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.hourBegin = new System.Windows.Forms.NumericUpDown();
            this.hourEnd = new System.Windows.Forms.NumericUpDown();
            this.lbHourEnd = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.hourBegin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hourEnd)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(160, 300);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(114, 29);
            this.btnCancel.TabIndex = 10;
            this.btnCancel.Text = "Annuler";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnValidate
            // 
            this.btnValidate.Location = new System.Drawing.Point(335, 300);
            this.btnValidate.Name = "btnValidate";
            this.btnValidate.Size = new System.Drawing.Size(114, 29);
            this.btnValidate.TabIndex = 11;
            this.btnValidate.Text = "Valider";
            this.btnValidate.UseVisualStyleBackColor = true;
            this.btnValidate.Click += new System.EventHandler(this.btnValidate_Click);
            // 
            // tbPlace
            // 
            this.tbPlace.Location = new System.Drawing.Point(366, 53);
            this.tbPlace.Name = "tbPlace";
            this.tbPlace.Size = new System.Drawing.Size(172, 22);
            this.tbPlace.TabIndex = 9;
            // 
            // tbTraining
            // 
            this.tbTraining.Enabled = false;
            this.tbTraining.Location = new System.Drawing.Point(160, 29);
            this.tbTraining.Name = "tbTraining";
            this.tbTraining.Size = new System.Drawing.Size(270, 22);
            this.tbTraining.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(321, 53);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "Lieu:";
            // 
            // lbHourBegin
            // 
            this.lbHourBegin.AutoSize = true;
            this.lbHourBegin.Location = new System.Drawing.Point(120, 140);
            this.lbHourBegin.Name = "lbHourBegin";
            this.lbHourBegin.Size = new System.Drawing.Size(95, 17);
            this.lbHourBegin.TabIndex = 4;
            this.lbHourBegin.Text = "Heure début :";
            // 
            // lbDate
            // 
            this.lbDate.AutoSize = true;
            this.lbDate.Location = new System.Drawing.Point(21, 51);
            this.lbDate.Name = "lbDate";
            this.lbDate.Size = new System.Drawing.Size(42, 17);
            this.lbDate.TabIndex = 2;
            this.lbDate.Text = "Date:";
            // 
            // lbTraining
            // 
            this.lbTraining.AutoSize = true;
            this.lbTraining.Location = new System.Drawing.Point(217, 9);
            this.lbTraining.Name = "lbTraining";
            this.lbTraining.Size = new System.Drawing.Size(151, 17);
            this.lbTraining.TabIndex = 0;
            this.lbTraining.Text = "Libellé de la formation:";
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Location = new System.Drawing.Point(66, 51);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(205, 22);
            this.dateTimePicker.TabIndex = 3;
            // 
            // hourBegin
            // 
            this.hourBegin.Location = new System.Drawing.Point(221, 140);
            this.hourBegin.Name = "hourBegin";
            this.hourBegin.Size = new System.Drawing.Size(50, 22);
            this.hourBegin.TabIndex = 5;
            // 
            // hourEnd
            // 
            this.hourEnd.Location = new System.Drawing.Point(391, 140);
            this.hourEnd.Name = "hourEnd";
            this.hourEnd.Size = new System.Drawing.Size(50, 22);
            this.hourEnd.TabIndex = 7;
            // 
            // lbHourEnd
            // 
            this.lbHourEnd.AutoSize = true;
            this.lbHourEnd.Location = new System.Drawing.Point(311, 140);
            this.lbHourEnd.Name = "lbHourEnd";
            this.lbHourEnd.Size = new System.Drawing.Size(74, 17);
            this.lbHourEnd.TabIndex = 6;
            this.lbHourEnd.Text = "Heure fin :";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dateTimePicker);
            this.groupBox1.Controls.Add(this.lbHourEnd);
            this.groupBox1.Controls.Add(this.lbHourBegin);
            this.groupBox1.Controls.Add(this.hourEnd);
            this.groupBox1.Controls.Add(this.lbDate);
            this.groupBox1.Controls.Add(this.tbPlace);
            this.groupBox1.Controls.Add(this.hourBegin);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Location = new System.Drawing.Point(12, 69);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(564, 195);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Information de la session : ";
            // 
            // AdminAddSession
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(588, 346);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnValidate);
            this.Controls.Add(this.tbTraining);
            this.Controls.Add(this.lbTraining);
            this.Controls.Add(this.groupBox1);
            this.Name = "AdminAddSession";
            this.Text = "Création d\'une session";
            this.Load += new System.EventHandler(this.AdminAddSession_Load);
            ((System.ComponentModel.ISupportInitialize)(this.hourBegin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hourEnd)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnValidate;
        private System.Windows.Forms.TextBox tbPlace;
        private System.Windows.Forms.TextBox tbTraining;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbHourBegin;
        private System.Windows.Forms.Label lbDate;
        private System.Windows.Forms.Label lbTraining;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.NumericUpDown hourBegin;
        private System.Windows.Forms.NumericUpDown hourEnd;
        private System.Windows.Forms.Label lbHourEnd;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}
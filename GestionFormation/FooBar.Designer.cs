namespace GestionFormation
{
    partial class FooBar
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbFoo = new System.Windows.Forms.ComboBox();
            this.cbBar = new System.Windows.Forms.ComboBox();
            this.dgvFoo = new System.Windows.Forms.DataGridView();
            this.dgvBar = new System.Windows.Forms.DataGridView();
            this.btnCancel = new System.Windows.Forms.Button();
            this.Validate = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFoo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBar)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Foo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(398, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Bar";
            // 
            // cbFoo
            // 
            this.cbFoo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbFoo.FormattingEnabled = true;
            this.cbFoo.Location = new System.Drawing.Point(12, 88);
            this.cbFoo.Name = "cbFoo";
            this.cbFoo.Size = new System.Drawing.Size(198, 24);
            this.cbFoo.TabIndex = 2;
            // 
            // cbBar
            // 
            this.cbBar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbBar.FormattingEnabled = true;
            this.cbBar.Location = new System.Drawing.Point(401, 88);
            this.cbBar.Name = "cbBar";
            this.cbBar.Size = new System.Drawing.Size(198, 24);
            this.cbBar.TabIndex = 3;
            // 
            // dgvFoo
            // 
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgvFoo.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvFoo.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgvFoo.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvFoo.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvFoo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFoo.Location = new System.Drawing.Point(12, 118);
            this.dgvFoo.Name = "dgvFoo";
            this.dgvFoo.RowTemplate.Height = 24;
            this.dgvFoo.Size = new System.Drawing.Size(346, 234);
            this.dgvFoo.TabIndex = 4;
            // 
            // dgvBar
            // 
            this.dgvBar.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgvBar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBar.Location = new System.Drawing.Point(401, 118);
            this.dgvBar.Name = "dgvBar";
            this.dgvBar.RowTemplate.Height = 24;
            this.dgvBar.Size = new System.Drawing.Size(387, 234);
            this.dgvBar.TabIndex = 5;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(283, 397);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 6;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // Validate
            // 
            this.Validate.Location = new System.Drawing.Point(401, 397);
            this.Validate.Name = "Validate";
            this.Validate.Size = new System.Drawing.Size(75, 23);
            this.Validate.TabIndex = 7;
            this.Validate.Text = "Validate";
            this.Validate.UseVisualStyleBackColor = true;
            this.Validate.Click += new System.EventHandler(this.Validate_Click);
            // 
            // FooBar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Validate);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.dgvBar);
            this.Controls.Add(this.dgvFoo);
            this.Controls.Add(this.cbBar);
            this.Controls.Add(this.cbFoo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FooBar";
            this.Text = "FooBar";
            this.Load += new System.EventHandler(this.FooBar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFoo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbFoo;
        private System.Windows.Forms.ComboBox cbBar;
        private System.Windows.Forms.DataGridView dgvFoo;
        private System.Windows.Forms.DataGridView dgvBar;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button Validate;
    }
}
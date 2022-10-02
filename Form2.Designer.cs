namespace SendDataToOtherForms_Video6_
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.Semester_label = new System.Windows.Forms.Label();
            this.Name_label = new System.Windows.Forms.Label();
            this.RollNo_label = new System.Windows.Forms.Label();
            this.Section_label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Semester_label
            // 
            this.Semester_label.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Semester_label.AutoSize = true;
            this.Semester_label.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.Semester_label.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Semester_label.Location = new System.Drawing.Point(304, 273);
            this.Semester_label.Name = "Semester_label";
            this.Semester_label.Size = new System.Drawing.Size(0, 32);
            this.Semester_label.TabIndex = 7;
            // 
            // Name_label
            // 
            this.Name_label.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Name_label.AutoSize = true;
            this.Name_label.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.Name_label.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Name_label.Location = new System.Drawing.Point(304, 146);
            this.Name_label.Name = "Name_label";
            this.Name_label.Size = new System.Drawing.Size(0, 32);
            this.Name_label.TabIndex = 4;
            // 
            // RollNo_label
            // 
            this.RollNo_label.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.RollNo_label.AutoSize = true;
            this.RollNo_label.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.RollNo_label.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.RollNo_label.Location = new System.Drawing.Point(304, 187);
            this.RollNo_label.Name = "RollNo_label";
            this.RollNo_label.Size = new System.Drawing.Size(0, 32);
            this.RollNo_label.TabIndex = 5;
            // 
            // Section_label
            // 
            this.Section_label.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Section_label.AutoSize = true;
            this.Section_label.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.Section_label.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Section_label.Location = new System.Drawing.Point(304, 230);
            this.Section_label.Name = "Section_label";
            this.Section_label.Size = new System.Drawing.Size(0, 32);
            this.Section_label.TabIndex = 6;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Semester_label);
            this.Controls.Add(this.Name_label);
            this.Controls.Add(this.RollNo_label);
            this.Controls.Add(this.Section_label);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form2_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label Semester_label;
        private Label Name_label;
        private Label RollNo_label;
        private Label Section_label;
    }
}
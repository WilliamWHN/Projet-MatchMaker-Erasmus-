namespace ProjErasmus
{
    partial class Form1
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
            this.lblButtonCSV = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblButtonCSV
            // 
            this.lblButtonCSV.Location = new System.Drawing.Point(617, 101);
            this.lblButtonCSV.Name = "lblButtonCSV";
            this.lblButtonCSV.Size = new System.Drawing.Size(130, 48);
            this.lblButtonCSV.TabIndex = 0;
            this.lblButtonCSV.Text = "Importer liste d\'élèves (csv)";
            this.lblButtonCSV.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(768, 475);
            this.Controls.Add(this.lblButtonCSV);
            this.Name = "Form1";
            this.Text = "Erasmus";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button lblButtonCSV;
    }
}


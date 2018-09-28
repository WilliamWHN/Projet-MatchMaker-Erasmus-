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
            this.btnCSV = new System.Windows.Forms.Button();
            this.btnCreate = new System.Windows.Forms.Button();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCSV
            // 
            this.btnCSV.Location = new System.Drawing.Point(108, 81);
            this.btnCSV.Name = "btnCSV";
            this.btnCSV.Size = new System.Drawing.Size(130, 48);
            this.btnCSV.TabIndex = 0;
            this.btnCSV.Text = "Import Students list (CSV)";
            this.btnCSV.UseVisualStyleBackColor = true;
            this.btnCSV.Click += new System.EventHandler(this.btnCSV_Click);
            // 
            // btnCreate
            // 
            this.btnCreate.Location = new System.Drawing.Point(108, 145);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(130, 48);
            this.btnCreate.TabIndex = 1;
            this.btnCreate.Text = "Create Student";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // btnGenerate
            // 
            this.btnGenerate.Location = new System.Drawing.Point(108, 208);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(130, 48);
            this.btnGenerate.TabIndex = 2;
            this.btnGenerate.Text = "Generate Groups";
            this.btnGenerate.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(353, 340);
            this.Controls.Add(this.btnGenerate);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.btnCSV);
            this.Name = "Form1";
            this.Text = "Match Maker";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCSV;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Button btnGenerate;
    }
}


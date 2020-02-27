namespace GettingStarted
{
    partial class ListSEForm
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
            this.pickAlignment = new System.Windows.Forms.Button();
            this.listSE = new System.Windows.Forms.Button();
            this.superElevationList = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // pickAlignment
            // 
            this.pickAlignment.Location = new System.Drawing.Point(59, 26);
            this.pickAlignment.Margin = new System.Windows.Forms.Padding(2);
            this.pickAlignment.Name = "pickAlignment";
            this.pickAlignment.Size = new System.Drawing.Size(460, 28);
            this.pickAlignment.TabIndex = 5;
            this.pickAlignment.Text = "Pick Alignement";
            this.pickAlignment.UseVisualStyleBackColor = true;
            this.pickAlignment.Click += new System.EventHandler(this.PickAlignment_Click);
            // 
            // listSE
            // 
            this.listSE.Location = new System.Drawing.Point(59, 78);
            this.listSE.Margin = new System.Windows.Forms.Padding(2);
            this.listSE.Name = "listSE";
            this.listSE.Size = new System.Drawing.Size(460, 28);
            this.listSE.TabIndex = 6;
            this.listSE.Text = "List Superelevation";
            this.listSE.UseVisualStyleBackColor = true;
            this.listSE.Click += new System.EventHandler(this.ListSE_Click);
            // 
            // superElevationList
            // 
            this.superElevationList.FormattingEnabled = true;
            this.superElevationList.Location = new System.Drawing.Point(59, 126);
            this.superElevationList.Name = "superElevationList";
            this.superElevationList.Size = new System.Drawing.Size(460, 303);
            this.superElevationList.TabIndex = 8;
            // 
            // ListSEForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(571, 449);
            this.Controls.Add(this.superElevationList);
            this.Controls.Add(this.listSE);
            this.Controls.Add(this.pickAlignment);
            this.Name = "ListSEForm";
            this.Text = "ListSEForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button pickAlignment;
        private System.Windows.Forms.Button listSE;
        private System.Windows.Forms.ListBox superElevationList;
    }
}
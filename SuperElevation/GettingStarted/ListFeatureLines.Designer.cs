namespace GettingStarted
{
    partial class ListFeatureLines
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
            this.dataGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // pickAlignment
            // 
            this.pickAlignment.Location = new System.Drawing.Point(59, 26);
            this.pickAlignment.Margin = new System.Windows.Forms.Padding(2);
            this.pickAlignment.Name = "pickAlignment";
            this.pickAlignment.Size = new System.Drawing.Size(460, 28);
            this.pickAlignment.TabIndex = 5;
            this.pickAlignment.Text = "Pick Feature Line";
            this.pickAlignment.UseVisualStyleBackColor = true;
            this.pickAlignment.Click += new System.EventHandler(this.PickFeatureLine_Click);
            // 
            // dataGridView
            // 
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(59, 73);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.Size = new System.Drawing.Size(460, 351);
            this.dataGridView.TabIndex = 9;
            // 
            // ListFeatureLines
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(571, 449);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.pickAlignment);
            this.Name = "ListFeatureLines";
            this.Text = "ListSEForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button pickAlignment;
        private System.Windows.Forms.DataGridView dataGridView;
    }
}
namespace GettingStarted
{
    partial class CreateSEForm
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
            this.pickLocation = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.name = new System.Windows.Forms.TextBox();
            this.baselayer = new System.Windows.Forms.TextBox();
            this.description = new System.Windows.Forms.TextBox();
            this.create = new System.Windows.Forms.Button();
            this.pickAlignment = new System.Windows.Forms.Button();
            this.layers = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // pickLocation
            // 
            this.pickLocation.Location = new System.Drawing.Point(417, 231);
            this.pickLocation.Name = "pickLocation";
            this.pickLocation.Size = new System.Drawing.Size(319, 46);
            this.pickLocation.TabIndex = 5;
            this.pickLocation.Text = "Pick Location";
            this.pickLocation.UseVisualStyleBackColor = true;
            this.pickLocation.Click += new System.EventHandler(this.PickLocation_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(67, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(67, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Description";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(67, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Layer";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(67, 177);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "Base layer";
            // 
            // name
            // 
            this.name.Location = new System.Drawing.Point(297, 38);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(439, 26);
            this.name.TabIndex = 0;
            // 
            // baselayer
            // 
            this.baselayer.Location = new System.Drawing.Point(297, 177);
            this.baselayer.Name = "baselayer";
            this.baselayer.Size = new System.Drawing.Size(439, 26);
            this.baselayer.TabIndex = 3;
            // 
            // description
            // 
            this.description.Location = new System.Drawing.Point(297, 88);
            this.description.Name = "description";
            this.description.Size = new System.Drawing.Size(439, 26);
            this.description.TabIndex = 1;
            // 
            // create
            // 
            this.create.Location = new System.Drawing.Point(71, 304);
            this.create.Name = "create";
            this.create.Size = new System.Drawing.Size(665, 49);
            this.create.TabIndex = 6;
            this.create.Text = "Create Superelevation";
            this.create.UseVisualStyleBackColor = true;
            this.create.Click += new System.EventHandler(this.CreateSuperelevation_Click);
            // 
            // pickAlignment
            // 
            this.pickAlignment.Location = new System.Drawing.Point(71, 231);
            this.pickAlignment.Name = "pickAlignment";
            this.pickAlignment.Size = new System.Drawing.Size(319, 46);
            this.pickAlignment.TabIndex = 4;
            this.pickAlignment.Text = "Pick Alignment";
            this.pickAlignment.UseVisualStyleBackColor = true;
            this.pickAlignment.Click += new System.EventHandler(this.PickAlignment_Click);
            // 
            // layers
            // 
            this.layers.FormattingEnabled = true;
            this.layers.Location = new System.Drawing.Point(297, 130);
            this.layers.Name = "layers";
            this.layers.Size = new System.Drawing.Size(439, 28);
            this.layers.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 384);
            this.Controls.Add(this.layers);
            this.Controls.Add(this.pickAlignment);
            this.Controls.Add(this.create);
            this.Controls.Add(this.description);
            this.Controls.Add(this.baselayer);
            this.Controls.Add(this.name);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pickLocation);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button pickLocation;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.TextBox baselayer;
        private System.Windows.Forms.TextBox description;
        private System.Windows.Forms.Button create;
        private System.Windows.Forms.Button pickAlignment;
        private System.Windows.Forms.ComboBox layers;
    }
}
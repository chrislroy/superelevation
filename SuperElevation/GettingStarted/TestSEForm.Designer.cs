namespace GettingStarted
{
    partial class TestSEForm
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
            this.getLocationButton = new System.Windows.Forms.Button();
            this.xlocation = new System.Windows.Forms.TextBox();
            this.ylocation = new System.Windows.Forms.TextBox();
            this.zlocation = new System.Windows.Forms.TextBox();
            this.pickSE = new System.Windows.Forms.Button();
            this.setLocationButton = new System.Windows.Forms.Button();
            this.location = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.crossSlopeVal = new System.Windows.Forms.TextBox();
            this.stationVal = new System.Windows.Forms.TextBox();
            this.graphRangeOptions = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.getGraphRangeOptionButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.StationAndCrossSlopeButton = new System.Windows.Forms.Button();
            this.stationEnd = new System.Windows.Forms.TextBox();
            this.stationStart = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // getLocationButton
            // 
            this.getLocationButton.Location = new System.Drawing.Point(315, 63);
            this.getLocationButton.Margin = new System.Windows.Forms.Padding(2);
            this.getLocationButton.Name = "getLocationButton";
            this.getLocationButton.Size = new System.Drawing.Size(87, 28);
            this.getLocationButton.TabIndex = 0;
            this.getLocationButton.Text = "Get";
            this.getLocationButton.UseVisualStyleBackColor = true;
            this.getLocationButton.Click += new System.EventHandler(this.getLocation);
            // 
            // xlocation
            // 
            this.xlocation.Location = new System.Drawing.Point(108, 68);
            this.xlocation.Margin = new System.Windows.Forms.Padding(2);
            this.xlocation.Name = "xlocation";
            this.xlocation.Size = new System.Drawing.Size(62, 20);
            this.xlocation.TabIndex = 1;
            // 
            // ylocation
            // 
            this.ylocation.Location = new System.Drawing.Point(174, 68);
            this.ylocation.Margin = new System.Windows.Forms.Padding(2);
            this.ylocation.Name = "ylocation";
            this.ylocation.Size = new System.Drawing.Size(62, 20);
            this.ylocation.TabIndex = 2;
            // 
            // zlocation
            // 
            this.zlocation.Location = new System.Drawing.Point(240, 68);
            this.zlocation.Margin = new System.Windows.Forms.Padding(2);
            this.zlocation.Name = "zlocation";
            this.zlocation.Size = new System.Drawing.Size(62, 20);
            this.zlocation.TabIndex = 3;
            // 
            // pickSE
            // 
            this.pickSE.Location = new System.Drawing.Point(46, 22);
            this.pickSE.Margin = new System.Windows.Forms.Padding(2);
            this.pickSE.Name = "pickSE";
            this.pickSE.Size = new System.Drawing.Size(460, 28);
            this.pickSE.TabIndex = 4;
            this.pickSE.Text = "Pick Superelevation";
            this.pickSE.UseVisualStyleBackColor = true;
            this.pickSE.Click += new System.EventHandler(this.PickSE_Click);
            // 
            // setLocationButton
            // 
            this.setLocationButton.Location = new System.Drawing.Point(417, 63);
            this.setLocationButton.Margin = new System.Windows.Forms.Padding(2);
            this.setLocationButton.Name = "setLocationButton";
            this.setLocationButton.Size = new System.Drawing.Size(89, 28);
            this.setLocationButton.TabIndex = 5;
            this.setLocationButton.Text = "Set";
            this.setLocationButton.UseVisualStyleBackColor = true;
            this.setLocationButton.Click += new System.EventHandler(this.setLocation);
            // 
            // location
            // 
            this.location.AutoSize = true;
            this.location.Location = new System.Drawing.Point(46, 71);
            this.location.Name = "location";
            this.location.Size = new System.Drawing.Size(48, 13);
            this.location.TabIndex = 6;
            this.location.Text = "Location";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(46, 122);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 9);
            this.label1.TabIndex = 7;
            this.label1.Text = "Station";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(315, 107);
            this.button2.Margin = new System.Windows.Forms.Padding(2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(87, 28);
            this.button2.TabIndex = 9;
            this.button2.Text = "Get";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.getStationRange);
            // 
            // crossSlopeVal
            // 
            this.crossSlopeVal.Location = new System.Drawing.Point(240, 202);
            this.crossSlopeVal.Margin = new System.Windows.Forms.Padding(2);
            this.crossSlopeVal.Name = "crossSlopeVal";
            this.crossSlopeVal.Size = new System.Drawing.Size(62, 20);
            this.crossSlopeVal.TabIndex = 12;
            // 
            // stationVal
            // 
            this.stationVal.Location = new System.Drawing.Point(174, 202);
            this.stationVal.Margin = new System.Windows.Forms.Padding(2);
            this.stationVal.Name = "stationVal";
            this.stationVal.Size = new System.Drawing.Size(62, 20);
            this.stationVal.TabIndex = 11;
            // 
            // graphRangeOptions
            // 
            this.graphRangeOptions.FormattingEnabled = true;
            this.graphRangeOptions.Location = new System.Drawing.Point(174, 157);
            this.graphRangeOptions.Name = "graphRangeOptions";
            this.graphRangeOptions.Size = new System.Drawing.Size(128, 21);
            this.graphRangeOptions.TabIndex = 14;
            this.graphRangeOptions.SelectedIndexChanged += new System.EventHandler(this.GraphRangeOptions_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(46, 161);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Graph Range Options";
            // 
            // getGraphRangeOptionButton
            // 
            this.getGraphRangeOptionButton.Location = new System.Drawing.Point(315, 153);
            this.getGraphRangeOptionButton.Margin = new System.Windows.Forms.Padding(2);
            this.getGraphRangeOptionButton.Name = "getGraphRangeOptionButton";
            this.getGraphRangeOptionButton.Size = new System.Drawing.Size(87, 28);
            this.getGraphRangeOptionButton.TabIndex = 16;
            this.getGraphRangeOptionButton.Text = "Get";
            this.getGraphRangeOptionButton.UseVisualStyleBackColor = true;
            this.getGraphRangeOptionButton.Click += new System.EventHandler(this.getGraphRangeOption);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(417, 198);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(87, 28);
            this.button1.TabIndex = 17;
            this.button1.Text = "Pick Pt";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.XSlope_click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(46, 198);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 18;
            this.label3.Text = "X Slope";
            // 
            // StationAndCrossSlopeButton
            // 
            this.StationAndCrossSlopeButton.Location = new System.Drawing.Point(315, 198);
            this.StationAndCrossSlopeButton.Margin = new System.Windows.Forms.Padding(2);
            this.StationAndCrossSlopeButton.Name = "StationAndCrossSlopeButton";
            this.StationAndCrossSlopeButton.Size = new System.Drawing.Size(87, 28);
            this.StationAndCrossSlopeButton.TabIndex = 19;
            this.StationAndCrossSlopeButton.Text = "Get";
            this.StationAndCrossSlopeButton.UseVisualStyleBackColor = true;
            this.StationAndCrossSlopeButton.Click += new System.EventHandler(this.getStationAndCrossSlope);
            // 
            // stationEnd
            // 
            this.stationEnd.Location = new System.Drawing.Point(240, 115);
            this.stationEnd.Margin = new System.Windows.Forms.Padding(2);
            this.stationEnd.Name = "stationEnd";
            this.stationEnd.Size = new System.Drawing.Size(62, 20);
            this.stationEnd.TabIndex = 22;
            // 
            // stationStart
            // 
            this.stationStart.Location = new System.Drawing.Point(174, 115);
            this.stationStart.Margin = new System.Windows.Forms.Padding(2);
            this.stationStart.Name = "stationStart";
            this.stationStart.Size = new System.Drawing.Size(62, 20);
            this.stationStart.TabIndex = 21;
            // 
            // TestSEForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(533, 239);
            this.Controls.Add(this.stationEnd);
            this.Controls.Add(this.stationStart);
            this.Controls.Add(this.StationAndCrossSlopeButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.getGraphRangeOptionButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.graphRangeOptions);
            this.Controls.Add(this.crossSlopeVal);
            this.Controls.Add(this.stationVal);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.location);
            this.Controls.Add(this.setLocationButton);
            this.Controls.Add(this.pickSE);
            this.Controls.Add(this.zlocation);
            this.Controls.Add(this.ylocation);
            this.Controls.Add(this.xlocation);
            this.Controls.Add(this.getLocationButton);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "TestSEForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "TestSE";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button getLocationButton;
        private System.Windows.Forms.TextBox xlocation;
        private System.Windows.Forms.TextBox ylocation;
        private System.Windows.Forms.TextBox zlocation;
        private System.Windows.Forms.Button pickSE;
        private System.Windows.Forms.Button setLocationButton;
        private System.Windows.Forms.Label location;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox crossSlopeVal;
        private System.Windows.Forms.TextBox stationVal;
        private System.Windows.Forms.ComboBox graphRangeOptions;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button getGraphRangeOptionButton;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button StationAndCrossSlopeButton;
        private System.Windows.Forms.TextBox stationEnd;
        private System.Windows.Forms.TextBox stationStart;
    }
}
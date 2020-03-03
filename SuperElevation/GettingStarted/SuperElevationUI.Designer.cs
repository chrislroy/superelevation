namespace GettingStarted
{
    partial class SuperElevationUI
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.createPage = new System.Windows.Forms.TabPage();
            this.layerCombo = new System.Windows.Forms.ComboBox();
            this.pickAlignmentButton = new System.Windows.Forms.Button();
            this.createSuperElevationButton = new System.Windows.Forms.Button();
            this.descriptionText = new System.Windows.Forms.TextBox();
            this.baselayerText = new System.Windows.Forms.TextBox();
            this.nameText = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.pickLocationButton = new System.Windows.Forms.Button();
            this.testPage = new System.Windows.Forms.TabPage();
            this.stationEnd = new System.Windows.Forms.TextBox();
            this.stationStart = new System.Windows.Forms.TextBox();
            this.getStationAndCrossSlopeButton = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.pickPositionSlopeButton = new System.Windows.Forms.Button();
            this.getGraphRangeOptionButton = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.graphRangeOptions = new System.Windows.Forms.ComboBox();
            this.crossSlopeVal = new System.Windows.Forms.TextBox();
            this.stationVal = new System.Windows.Forms.TextBox();
            this.getStationButton = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.location = new System.Windows.Forms.Label();
            this.setLocationButton = new System.Windows.Forms.Button();
            this.pickSuperElevationButton = new System.Windows.Forms.Button();
            this.zlocation = new System.Windows.Forms.TextBox();
            this.ylocation = new System.Windows.Forms.TextBox();
            this.xlocation = new System.Windows.Forms.TextBox();
            this.getLocationButton = new System.Windows.Forms.Button();
            this.listPage = new System.Windows.Forms.TabPage();
            this.superElevationList = new System.Windows.Forms.ListBox();
            this.listSE = new System.Windows.Forms.Button();
            this.pickAlignment = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.createPage.SuspendLayout();
            this.testPage.SuspendLayout();
            this.listPage.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tabControl1);
            this.panel1.Location = new System.Drawing.Point(1, 6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(436, 284);
            this.panel1.TabIndex = 0;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.createPage);
            this.tabControl1.Controls.Add(this.testPage);
            this.tabControl1.Controls.Add(this.listPage);
            this.tabControl1.Location = new System.Drawing.Point(4, 4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(429, 273);
            this.tabControl1.TabIndex = 0;
            // 
            // createPage
            // 
            this.createPage.Controls.Add(this.layerCombo);
            this.createPage.Controls.Add(this.pickAlignmentButton);
            this.createPage.Controls.Add(this.createSuperElevationButton);
            this.createPage.Controls.Add(this.descriptionText);
            this.createPage.Controls.Add(this.baselayerText);
            this.createPage.Controls.Add(this.nameText);
            this.createPage.Controls.Add(this.label5);
            this.createPage.Controls.Add(this.label6);
            this.createPage.Controls.Add(this.label7);
            this.createPage.Controls.Add(this.label8);
            this.createPage.Controls.Add(this.pickLocationButton);
            this.createPage.Location = new System.Drawing.Point(4, 22);
            this.createPage.Name = "createPage";
            this.createPage.Padding = new System.Windows.Forms.Padding(3);
            this.createPage.Size = new System.Drawing.Size(421, 247);
            this.createPage.TabIndex = 0;
            this.createPage.Text = "Create";
            this.createPage.UseVisualStyleBackColor = true;
            // 
            // layerCombo
            // 
            this.layerCombo.FormattingEnabled = true;
            this.layerCombo.Location = new System.Drawing.Point(163, 80);
            this.layerCombo.Margin = new System.Windows.Forms.Padding(2);
            this.layerCombo.Name = "layerCombo";
            this.layerCombo.Size = new System.Drawing.Size(248, 21);
            this.layerCombo.TabIndex = 21;
            // 
            // pickAlignmentButton
            // 
            this.pickAlignmentButton.Location = new System.Drawing.Point(12, 146);
            this.pickAlignmentButton.Margin = new System.Windows.Forms.Padding(2);
            this.pickAlignmentButton.Name = "pickAlignmentButton";
            this.pickAlignmentButton.Size = new System.Drawing.Size(167, 30);
            this.pickAlignmentButton.TabIndex = 25;
            this.pickAlignmentButton.Text = "Pick Alignment";
            this.pickAlignmentButton.UseVisualStyleBackColor = true;
            this.pickAlignmentButton.Click += new System.EventHandler(this.PickAlignment_Click);
            // 
            // createSuperElevationButton
            // 
            this.createSuperElevationButton.Location = new System.Drawing.Point(12, 194);
            this.createSuperElevationButton.Margin = new System.Windows.Forms.Padding(2);
            this.createSuperElevationButton.Name = "createSuperElevationButton";
            this.createSuperElevationButton.Size = new System.Drawing.Size(397, 32);
            this.createSuperElevationButton.TabIndex = 28;
            this.createSuperElevationButton.Text = "Create Superelevation";
            this.createSuperElevationButton.UseVisualStyleBackColor = true;
            this.createSuperElevationButton.Click += new System.EventHandler(this.CreateSuperelevation_Click);
            // 
            // descriptionText
            // 
            this.descriptionText.Location = new System.Drawing.Point(163, 53);
            this.descriptionText.Margin = new System.Windows.Forms.Padding(2);
            this.descriptionText.Name = "descriptionText";
            this.descriptionText.Size = new System.Drawing.Size(248, 20);
            this.descriptionText.TabIndex = 19;
            // 
            // baselayerText
            // 
            this.baselayerText.Location = new System.Drawing.Point(163, 111);
            this.baselayerText.Margin = new System.Windows.Forms.Padding(2);
            this.baselayerText.Name = "baselayerText";
            this.baselayerText.Size = new System.Drawing.Size(248, 20);
            this.baselayerText.TabIndex = 23;
            // 
            // nameText
            // 
            this.nameText.Location = new System.Drawing.Point(163, 21);
            this.nameText.Margin = new System.Windows.Forms.Padding(2);
            this.nameText.Name = "nameText";
            this.nameText.Size = new System.Drawing.Size(248, 20);
            this.nameText.TabIndex = 18;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 111);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 13);
            this.label5.TabIndex = 26;
            this.label5.Text = "Base layer";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(10, 80);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(33, 13);
            this.label6.TabIndex = 24;
            this.label6.Text = "Layer";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(10, 53);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 13);
            this.label7.TabIndex = 22;
            this.label7.Text = "Description";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(10, 21);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(35, 13);
            this.label8.TabIndex = 20;
            this.label8.Text = "Name";
            // 
            // pickLocationButton
            // 
            this.pickLocationButton.Location = new System.Drawing.Point(243, 146);
            this.pickLocationButton.Margin = new System.Windows.Forms.Padding(2);
            this.pickLocationButton.Name = "pickLocationButton";
            this.pickLocationButton.Size = new System.Drawing.Size(167, 30);
            this.pickLocationButton.TabIndex = 27;
            this.pickLocationButton.Text = "Pick Location";
            this.pickLocationButton.UseVisualStyleBackColor = true;
            this.pickLocationButton.Click += new System.EventHandler(this.PickLocationButton_Click);
            // 
            // testPage
            // 
            this.testPage.Controls.Add(this.stationEnd);
            this.testPage.Controls.Add(this.stationStart);
            this.testPage.Controls.Add(this.getStationAndCrossSlopeButton);
            this.testPage.Controls.Add(this.label9);
            this.testPage.Controls.Add(this.pickPositionSlopeButton);
            this.testPage.Controls.Add(this.getGraphRangeOptionButton);
            this.testPage.Controls.Add(this.label10);
            this.testPage.Controls.Add(this.graphRangeOptions);
            this.testPage.Controls.Add(this.crossSlopeVal);
            this.testPage.Controls.Add(this.stationVal);
            this.testPage.Controls.Add(this.getStationButton);
            this.testPage.Controls.Add(this.label11);
            this.testPage.Controls.Add(this.location);
            this.testPage.Controls.Add(this.setLocationButton);
            this.testPage.Controls.Add(this.pickSuperElevationButton);
            this.testPage.Controls.Add(this.zlocation);
            this.testPage.Controls.Add(this.ylocation);
            this.testPage.Controls.Add(this.xlocation);
            this.testPage.Controls.Add(this.getLocationButton);
            this.testPage.Location = new System.Drawing.Point(4, 22);
            this.testPage.Name = "testPage";
            this.testPage.Padding = new System.Windows.Forms.Padding(3);
            this.testPage.Size = new System.Drawing.Size(421, 247);
            this.testPage.TabIndex = 1;
            this.testPage.Text = "Test";
            this.testPage.UseVisualStyleBackColor = true;
            // 
            // stationEnd
            // 
            this.stationEnd.Location = new System.Drawing.Point(177, 118);
            this.stationEnd.Margin = new System.Windows.Forms.Padding(2);
            this.stationEnd.Name = "stationEnd";
            this.stationEnd.Size = new System.Drawing.Size(52, 20);
            this.stationEnd.TabIndex = 41;
            // 
            // stationStart
            // 
            this.stationStart.Location = new System.Drawing.Point(103, 118);
            this.stationStart.Margin = new System.Windows.Forms.Padding(2);
            this.stationStart.Name = "stationStart";
            this.stationStart.Size = new System.Drawing.Size(58, 20);
            this.stationStart.TabIndex = 40;
            // 
            // getStationAndCrossSlopeButton
            // 
            this.getStationAndCrossSlopeButton.Location = new System.Drawing.Point(374, 185);
            this.getStationAndCrossSlopeButton.Margin = new System.Windows.Forms.Padding(2);
            this.getStationAndCrossSlopeButton.Name = "getStationAndCrossSlopeButton";
            this.getStationAndCrossSlopeButton.Size = new System.Drawing.Size(40, 28);
            this.getStationAndCrossSlopeButton.TabIndex = 39;
            this.getStationAndCrossSlopeButton.Text = "Get";
            this.getStationAndCrossSlopeButton.UseVisualStyleBackColor = true;
            this.getStationAndCrossSlopeButton.Click += new System.EventHandler(this.getStationAndCrossSlope);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(8, 190);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(44, 13);
            this.label9.TabIndex = 38;
            this.label9.Text = "X Slope";
            // 
            // pickPositionSlopeButton
            // 
            this.pickPositionSlopeButton.Location = new System.Drawing.Point(319, 185);
            this.pickPositionSlopeButton.Name = "pickPositionSlopeButton";
            this.pickPositionSlopeButton.Size = new System.Drawing.Size(40, 28);
            this.pickPositionSlopeButton.TabIndex = 37;
            this.pickPositionSlopeButton.Text = "Pick";
            this.pickPositionSlopeButton.UseVisualStyleBackColor = true;
            this.pickPositionSlopeButton.Click += new System.EventHandler(this.XSlope_click);
            // 
            // getGraphRangeOptionButton
            // 
            this.getGraphRangeOptionButton.Location = new System.Drawing.Point(374, 146);
            this.getGraphRangeOptionButton.Margin = new System.Windows.Forms.Padding(2);
            this.getGraphRangeOptionButton.Name = "getGraphRangeOptionButton";
            this.getGraphRangeOptionButton.Size = new System.Drawing.Size(40, 28);
            this.getGraphRangeOptionButton.TabIndex = 36;
            this.getGraphRangeOptionButton.Text = "Get";
            this.getGraphRangeOptionButton.UseVisualStyleBackColor = true;
            this.getGraphRangeOptionButton.Click += new System.EventHandler(this.getGraphRangeOption);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(8, 156);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(71, 13);
            this.label10.TabIndex = 35;
            this.label10.Text = "Graph Range";
            // 
            // graphRangeOptions
            // 
            this.graphRangeOptions.FormattingEnabled = true;
            this.graphRangeOptions.Location = new System.Drawing.Point(103, 153);
            this.graphRangeOptions.Name = "graphRangeOptions";
            this.graphRangeOptions.Size = new System.Drawing.Size(126, 21);
            this.graphRangeOptions.TabIndex = 34;
            // 
            // crossSlopeVal
            // 
            this.crossSlopeVal.Location = new System.Drawing.Point(177, 190);
            this.crossSlopeVal.Margin = new System.Windows.Forms.Padding(2);
            this.crossSlopeVal.Name = "crossSlopeVal";
            this.crossSlopeVal.Size = new System.Drawing.Size(52, 20);
            this.crossSlopeVal.TabIndex = 33;
            // 
            // stationVal
            // 
            this.stationVal.Location = new System.Drawing.Point(103, 190);
            this.stationVal.Margin = new System.Windows.Forms.Padding(2);
            this.stationVal.Name = "stationVal";
            this.stationVal.Size = new System.Drawing.Size(58, 20);
            this.stationVal.TabIndex = 32;
            // 
            // getStationButton
            // 
            this.getStationButton.Location = new System.Drawing.Point(374, 110);
            this.getStationButton.Margin = new System.Windows.Forms.Padding(2);
            this.getStationButton.Name = "getStationButton";
            this.getStationButton.Size = new System.Drawing.Size(40, 28);
            this.getStationButton.TabIndex = 31;
            this.getStationButton.Text = "Get";
            this.getStationButton.UseVisualStyleBackColor = true;
            this.getStationButton.Click += new System.EventHandler(this.getStationRange);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(8, 117);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(40, 13);
            this.label11.TabIndex = 30;
            this.label11.Text = "Station";
            // 
            // location
            // 
            this.location.AutoSize = true;
            this.location.Location = new System.Drawing.Point(8, 82);
            this.location.Name = "location";
            this.location.Size = new System.Drawing.Size(48, 13);
            this.location.TabIndex = 29;
            this.location.Text = "Location";
            // 
            // setLocationButton
            // 
            this.setLocationButton.Location = new System.Drawing.Point(319, 74);
            this.setLocationButton.Margin = new System.Windows.Forms.Padding(2);
            this.setLocationButton.Name = "setLocationButton";
            this.setLocationButton.Size = new System.Drawing.Size(42, 28);
            this.setLocationButton.TabIndex = 28;
            this.setLocationButton.Text = "Set";
            this.setLocationButton.UseVisualStyleBackColor = true;
            this.setLocationButton.Click += new System.EventHandler(this.setLocation);
            // 
            // pickSuperElevationButton
            // 
            this.pickSuperElevationButton.Location = new System.Drawing.Point(8, 25);
            this.pickSuperElevationButton.Margin = new System.Windows.Forms.Padding(2);
            this.pickSuperElevationButton.Name = "pickSuperElevationButton";
            this.pickSuperElevationButton.Size = new System.Drawing.Size(408, 28);
            this.pickSuperElevationButton.TabIndex = 27;
            this.pickSuperElevationButton.Text = "Pick Superelevation";
            this.pickSuperElevationButton.UseVisualStyleBackColor = true;
            this.pickSuperElevationButton.Click += new System.EventHandler(this.PickSuperElevationButton_Click);
            // 
            // zlocation
            // 
            this.zlocation.Location = new System.Drawing.Point(246, 79);
            this.zlocation.Margin = new System.Windows.Forms.Padding(2);
            this.zlocation.Name = "zlocation";
            this.zlocation.Size = new System.Drawing.Size(59, 20);
            this.zlocation.TabIndex = 26;
            // 
            // ylocation
            // 
            this.ylocation.Location = new System.Drawing.Point(177, 79);
            this.ylocation.Margin = new System.Windows.Forms.Padding(2);
            this.ylocation.Name = "ylocation";
            this.ylocation.Size = new System.Drawing.Size(52, 20);
            this.ylocation.TabIndex = 25;
            // 
            // xlocation
            // 
            this.xlocation.Location = new System.Drawing.Point(103, 79);
            this.xlocation.Margin = new System.Windows.Forms.Padding(2);
            this.xlocation.Name = "xlocation";
            this.xlocation.Size = new System.Drawing.Size(58, 20);
            this.xlocation.TabIndex = 24;
            // 
            // getLocationButton
            // 
            this.getLocationButton.Location = new System.Drawing.Point(374, 74);
            this.getLocationButton.Margin = new System.Windows.Forms.Padding(2);
            this.getLocationButton.Name = "getLocationButton";
            this.getLocationButton.Size = new System.Drawing.Size(40, 28);
            this.getLocationButton.TabIndex = 23;
            this.getLocationButton.Text = "Get";
            this.getLocationButton.UseVisualStyleBackColor = true;
            this.getLocationButton.Click += new System.EventHandler(this.getLocation);
            // 
            // listPage
            // 
            this.listPage.Controls.Add(this.superElevationList);
            this.listPage.Controls.Add(this.listSE);
            this.listPage.Controls.Add(this.pickAlignment);
            this.listPage.Location = new System.Drawing.Point(4, 22);
            this.listPage.Name = "listPage";
            this.listPage.Padding = new System.Windows.Forms.Padding(3);
            this.listPage.Size = new System.Drawing.Size(421, 247);
            this.listPage.TabIndex = 2;
            this.listPage.Text = "List";
            this.listPage.UseVisualStyleBackColor = true;
            // 
            // superElevationList
            // 
            this.superElevationList.FormattingEnabled = true;
            this.superElevationList.Location = new System.Drawing.Point(15, 81);
            this.superElevationList.Name = "superElevationList";
            this.superElevationList.Size = new System.Drawing.Size(388, 160);
            this.superElevationList.TabIndex = 11;
            // 
            // listSE
            // 
            this.listSE.Location = new System.Drawing.Point(15, 47);
            this.listSE.Margin = new System.Windows.Forms.Padding(2);
            this.listSE.Name = "listSE";
            this.listSE.Size = new System.Drawing.Size(388, 29);
            this.listSE.TabIndex = 10;
            this.listSE.Text = "List Superelevation";
            this.listSE.UseVisualStyleBackColor = true;
            this.listSE.Click += new System.EventHandler(this.ListSE_Click);
            // 
            // pickAlignment
            // 
            this.pickAlignment.Location = new System.Drawing.Point(15, 10);
            this.pickAlignment.Margin = new System.Windows.Forms.Padding(2);
            this.pickAlignment.Name = "pickAlignment";
            this.pickAlignment.Size = new System.Drawing.Size(388, 33);
            this.pickAlignment.TabIndex = 9;
            this.pickAlignment.Text = "Pick Alignement";
            this.pickAlignment.UseVisualStyleBackColor = true;
            this.pickAlignment.Click += new System.EventHandler(this.PickAlignment_Click);
            // 
            // SuperElevationUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(436, 295);
            this.Controls.Add(this.panel1);
            this.Name = "SuperElevationUI";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "SuperElevationUI";
            this.panel1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.createPage.ResumeLayout(false);
            this.createPage.PerformLayout();
            this.testPage.ResumeLayout(false);
            this.testPage.PerformLayout();
            this.listPage.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage createPage;
        private System.Windows.Forms.TabPage testPage;
        private System.Windows.Forms.TabPage listPage;
        private System.Windows.Forms.ComboBox layerCombo;
        private System.Windows.Forms.Button pickAlignmentButton;
        private System.Windows.Forms.Button createSuperElevationButton;
        private System.Windows.Forms.TextBox descriptionText;
        private System.Windows.Forms.TextBox baselayerText;
        private System.Windows.Forms.TextBox nameText;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button pickLocationButton;
        private System.Windows.Forms.TextBox stationEnd;
        private System.Windows.Forms.TextBox stationStart;
        private System.Windows.Forms.Button getStationAndCrossSlopeButton;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button pickPositionSlopeButton;
        private System.Windows.Forms.Button getGraphRangeOptionButton;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox graphRangeOptions;
        private System.Windows.Forms.TextBox crossSlopeVal;
        private System.Windows.Forms.TextBox stationVal;
        private System.Windows.Forms.Button getStationButton;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label location;
        private System.Windows.Forms.Button setLocationButton;
        private System.Windows.Forms.Button pickSuperElevationButton;
        private System.Windows.Forms.TextBox zlocation;
        private System.Windows.Forms.TextBox ylocation;
        private System.Windows.Forms.TextBox xlocation;
        private System.Windows.Forms.Button getLocationButton;
        private System.Windows.Forms.ListBox superElevationList;
        private System.Windows.Forms.Button listSE;
        private System.Windows.Forms.Button pickAlignment;
    }
}
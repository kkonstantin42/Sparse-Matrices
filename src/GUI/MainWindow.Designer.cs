namespace SparseMatrices.GUI
{
    partial class MainWindow
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.mainChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.evalButton = new System.Windows.Forms.Button();
            this.danceButton = new System.Windows.Forms.Button();
            this.randomCheck = new System.Windows.Forms.Button();
            this.zeroProbTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dataAmountTextBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.mainChart)).BeginInit();
            this.SuspendLayout();
            // 
            // mainChart
            // 
            chartArea1.Name = "ChartArea1";
            this.mainChart.ChartAreas.Add(chartArea1);
            this.mainChart.Dock = System.Windows.Forms.DockStyle.Top;
            legend1.Name = "Legend1";
            this.mainChart.Legends.Add(legend1);
            this.mainChart.Location = new System.Drawing.Point(0, 0);
            this.mainChart.Margin = new System.Windows.Forms.Padding(3, 3, 3, 20);
            this.mainChart.Name = "mainChart";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.mainChart.Series.Add(series1);
            this.mainChart.Size = new System.Drawing.Size(667, 341);
            this.mainChart.TabIndex = 0;
            this.mainChart.Text = "chart1";
            // 
            // evalButton
            // 
            this.evalButton.Location = new System.Drawing.Point(28, 347);
            this.evalButton.Name = "evalButton";
            this.evalButton.Size = new System.Drawing.Size(120, 23);
            this.evalButton.TabIndex = 1;
            this.evalButton.Text = "Evaluate";
            this.evalButton.UseVisualStyleBackColor = true;
            this.evalButton.Click += new System.EventHandler(this.evalButton_Click);
            // 
            // danceButton
            // 
            this.danceButton.Location = new System.Drawing.Point(167, 347);
            this.danceButton.Name = "danceButton";
            this.danceButton.Size = new System.Drawing.Size(117, 23);
            this.danceButton.TabIndex = 2;
            this.danceButton.Text = "Dance";
            this.danceButton.UseVisualStyleBackColor = true;
            this.danceButton.Click += new System.EventHandler(this.danceButton_Click);
            // 
            // randomCheck
            // 
            this.randomCheck.Location = new System.Drawing.Point(299, 347);
            this.randomCheck.Name = "randomCheck";
            this.randomCheck.Size = new System.Drawing.Size(110, 23);
            this.randomCheck.TabIndex = 3;
            this.randomCheck.Text = "RandomCheck";
            this.randomCheck.UseVisualStyleBackColor = true;
            this.randomCheck.Click += new System.EventHandler(this.randomCheck_Click);
            // 
            // zeroProbTextBox
            // 
            this.zeroProbTextBox.Location = new System.Drawing.Point(502, 350);
            this.zeroProbTextBox.Name = "zeroProbTextBox";
            this.zeroProbTextBox.Size = new System.Drawing.Size(100, 20);
            this.zeroProbTextBox.TabIndex = 4;
            this.zeroProbTextBox.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(416, 356);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Zero probability:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(416, 373);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Amount of data:";
            // 
            // dataAmountTextBox
            // 
            this.dataAmountTextBox.Location = new System.Drawing.Point(502, 373);
            this.dataAmountTextBox.Name = "dataAmountTextBox";
            this.dataAmountTextBox.Size = new System.Drawing.Size(100, 20);
            this.dataAmountTextBox.TabIndex = 7;
            this.dataAmountTextBox.Text = "1000";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(667, 406);
            this.Controls.Add(this.dataAmountTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.zeroProbTextBox);
            this.Controls.Add(this.randomCheck);
            this.Controls.Add(this.danceButton);
            this.Controls.Add(this.evalButton);
            this.Controls.Add(this.mainChart);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.mainChart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataVisualization.Charting.Chart mainChart;
        private System.Windows.Forms.Button evalButton;
        private System.Windows.Forms.Button danceButton;
        private System.Windows.Forms.Button randomCheck;
        private System.Windows.Forms.TextBox zeroProbTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox dataAmountTextBox;
    }
}


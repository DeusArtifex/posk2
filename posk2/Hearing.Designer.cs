namespace posk2
{
    partial class Hearing
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Hearing));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.btnStart = new System.Windows.Forms.Button();
            this.description = new System.Windows.Forms.Label();
            this.btnCheck = new System.Windows.Forms.Button();
            this.tutorial = new System.Windows.Forms.CheckBox();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.resultChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.resultTable = new System.Windows.Forms.Label();
            this.resultAverage = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.resultChart)).BeginInit();
            this.SuspendLayout();
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(327, 87);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(86, 23);
            this.btnStart.TabIndex = 0;
            this.btnStart.Text = "Rozpocznij";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // description
            // 
            this.description.BackColor = System.Drawing.SystemColors.ControlLight;
            this.description.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.description.Location = new System.Drawing.Point(12, 9);
            this.description.Name = "description";
            this.description.Size = new System.Drawing.Size(400, 75);
            this.description.TabIndex = 1;
            this.description.Text = resources.GetString("description.Text");
            // 
            // btnCheck
            // 
            this.btnCheck.Enabled = false;
            this.btnCheck.Location = new System.Drawing.Point(418, 9);
            this.btnCheck.Name = "btnCheck";
            this.btnCheck.Size = new System.Drawing.Size(75, 75);
            this.btnCheck.TabIndex = 3;
            this.btnCheck.Text = "Słyszę";
            this.btnCheck.UseVisualStyleBackColor = true;
            this.btnCheck.Click += new System.EventHandler(this.btnCheck_Click);
            // 
            // tutorial
            // 
            this.tutorial.AutoSize = true;
            this.tutorial.Checked = true;
            this.tutorial.CheckState = System.Windows.Forms.CheckState.Checked;
            this.tutorial.Location = new System.Drawing.Point(327, 116);
            this.tutorial.Name = "tutorial";
            this.tutorial.Size = new System.Drawing.Size(86, 17);
            this.tutorial.TabIndex = 5;
            this.tutorial.Text = "Seria próbna";
            this.tutorial.UseVisualStyleBackColor = true;
            // 
            // timer
            // 
            this.timer.Interval = 5000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // resultChart
            // 
            chartArea3.Name = "ChartArea1";
            this.resultChart.ChartAreas.Add(chartArea3);
            legend3.Enabled = false;
            legend3.Name = "Legend1";
            this.resultChart.Legends.Add(legend3);
            this.resultChart.Location = new System.Drawing.Point(12, 116);
            this.resultChart.Name = "resultChart";
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series3.Legend = "Legend1";
            series3.Name = "Series1";
            this.resultChart.Series.Add(series3);
            this.resultChart.Size = new System.Drawing.Size(300, 300);
            this.resultChart.TabIndex = 6;
            this.resultChart.Text = "chart1";
            this.resultChart.Visible = false;
            // 
            // resultTable
            // 
            this.resultTable.BackColor = System.Drawing.SystemColors.ControlLight;
            this.resultTable.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.resultTable.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resultTable.Location = new System.Drawing.Point(324, 148);
            this.resultTable.Name = "resultTable";
            this.resultTable.Size = new System.Drawing.Size(169, 169);
            this.resultTable.TabIndex = 7;
            this.resultTable.Visible = false;
            // 
            // resultAverage
            // 
            this.resultAverage.BackColor = System.Drawing.SystemColors.ControlLight;
            this.resultAverage.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.resultAverage.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resultAverage.Location = new System.Drawing.Point(321, 334);
            this.resultAverage.Name = "resultAverage";
            this.resultAverage.Size = new System.Drawing.Size(172, 50);
            this.resultAverage.TabIndex = 8;
            this.resultAverage.Visible = false;
            // 
            // Hearing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.resultAverage);
            this.Controls.Add(this.resultTable);
            this.Controls.Add(this.resultChart);
            this.Controls.Add(this.tutorial);
            this.Controls.Add(this.btnCheck);
            this.Controls.Add(this.description);
            this.Controls.Add(this.btnStart);
            this.Name = "Hearing";
            this.Text = "Hearing";
            ((System.ComponentModel.ISupportInitialize)(this.resultChart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Label description;
        private System.Windows.Forms.Button btnCheck;
        private System.Windows.Forms.CheckBox tutorial;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.DataVisualization.Charting.Chart resultChart;
        private System.Windows.Forms.Label resultTable;
        private System.Windows.Forms.Label resultAverage;
    }
}
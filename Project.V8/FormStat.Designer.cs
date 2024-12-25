namespace Project.V8
{
    partial class FormStat
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
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            groupBoxAutoStats_SNM = new GroupBox();
            labelAvgWeight_SNM = new Label();
            labelMinWeight_SNM = new Label();
            labelMaxWeight_SNM = new Label();
            labelAvgSpeed_SNM = new Label();
            labelMinSpeed_SNM = new Label();
            labelMaxSpeed_SNM = new Label();
            labelAvgFuel_SNM = new Label();
            labelMinFuel_SNM = new Label();
            labelMaxFuel_SNM = new Label();
            groupBoxAuto_SNM = new GroupBox();
            labelCondition_SNM = new Label();
            labelPlaceCount_SNM = new Label();
            labelMarkCount_SNM = new Label();
            labelAutoCount_SNM = new Label();
            chartSpeed_SNM = new System.Windows.Forms.DataVisualization.Charting.Chart();
            groupBoxAutoStats_SNM.SuspendLayout();
            groupBoxAuto_SNM.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)chartSpeed_SNM).BeginInit();
            SuspendLayout();
            // 
            // groupBoxAutoStats_SNM
            // 
            groupBoxAutoStats_SNM.Controls.Add(labelAvgWeight_SNM);
            groupBoxAutoStats_SNM.Controls.Add(labelMinWeight_SNM);
            groupBoxAutoStats_SNM.Controls.Add(labelMaxWeight_SNM);
            groupBoxAutoStats_SNM.Controls.Add(labelAvgSpeed_SNM);
            groupBoxAutoStats_SNM.Controls.Add(labelMinSpeed_SNM);
            groupBoxAutoStats_SNM.Controls.Add(labelMaxSpeed_SNM);
            groupBoxAutoStats_SNM.Controls.Add(labelAvgFuel_SNM);
            groupBoxAutoStats_SNM.Controls.Add(labelMinFuel_SNM);
            groupBoxAutoStats_SNM.Controls.Add(labelMaxFuel_SNM);
            groupBoxAutoStats_SNM.Location = new Point(12, 12);
            groupBoxAutoStats_SNM.Name = "groupBoxAutoStats_SNM";
            groupBoxAutoStats_SNM.Size = new Size(291, 300);
            groupBoxAutoStats_SNM.TabIndex = 0;
            groupBoxAutoStats_SNM.TabStop = false;
            groupBoxAutoStats_SNM.Text = "Характеристики машин";
            // 
            // labelAvgWeight_SNM
            // 
            labelAvgWeight_SNM.AutoSize = true;
            labelAvgWeight_SNM.Location = new Point(6, 237);
            labelAvgWeight_SNM.Name = "labelAvgWeight_SNM";
            labelAvgWeight_SNM.Size = new Size(156, 15);
            labelAvgWeight_SNM.TabIndex = 8;
            labelAvgWeight_SNM.Text = "Срдняя грузоподъемность:";
            // 
            // labelMinWeight_SNM
            // 
            labelMinWeight_SNM.AutoSize = true;
            labelMinWeight_SNM.Location = new Point(6, 209);
            labelMinWeight_SNM.Name = "labelMinWeight_SNM";
            labelMinWeight_SNM.Size = new Size(195, 15);
            labelMinWeight_SNM.TabIndex = 7;
            labelMinWeight_SNM.Text = "Минимальная грузоподъемность:";
            // 
            // labelMaxWeight_SNM
            // 
            labelMaxWeight_SNM.AutoSize = true;
            labelMaxWeight_SNM.Location = new Point(6, 184);
            labelMaxWeight_SNM.Name = "labelMaxWeight_SNM";
            labelMaxWeight_SNM.Size = new Size(199, 15);
            labelMaxWeight_SNM.TabIndex = 6;
            labelMaxWeight_SNM.Text = "Максимальная грузоподъемность:";
            // 
            // labelAvgSpeed_SNM
            // 
            labelAvgSpeed_SNM.AutoSize = true;
            labelAvgSpeed_SNM.Location = new Point(6, 159);
            labelAvgSpeed_SNM.Name = "labelAvgSpeed_SNM";
            labelAvgSpeed_SNM.Size = new Size(109, 15);
            labelAvgSpeed_SNM.TabIndex = 5;
            labelAvgSpeed_SNM.Text = "Средняя скорость:";
            // 
            // labelMinSpeed_SNM
            // 
            labelMinSpeed_SNM.AutoSize = true;
            labelMinSpeed_SNM.Location = new Point(6, 132);
            labelMinSpeed_SNM.Name = "labelMinSpeed_SNM";
            labelMinSpeed_SNM.Size = new Size(142, 15);
            labelMinSpeed_SNM.TabIndex = 4;
            labelMinSpeed_SNM.Text = "Минимальная скорость:";
            // 
            // labelMaxSpeed_SNM
            // 
            labelMaxSpeed_SNM.AutoSize = true;
            labelMaxSpeed_SNM.Location = new Point(6, 101);
            labelMaxSpeed_SNM.Name = "labelMaxSpeed_SNM";
            labelMaxSpeed_SNM.Size = new Size(146, 15);
            labelMaxSpeed_SNM.TabIndex = 3;
            labelMaxSpeed_SNM.Text = "Максимальная скорость:";
            // 
            // labelAvgFuel_SNM
            // 
            labelAvgFuel_SNM.AutoSize = true;
            labelAvgFuel_SNM.Location = new Point(6, 74);
            labelAvgFuel_SNM.Name = "labelAvgFuel_SNM";
            labelAvgFuel_SNM.Size = new Size(147, 15);
            labelAvgFuel_SNM.TabIndex = 2;
            labelAvgFuel_SNM.Text = "Средний расход топлива:";
            // 
            // labelMinFuel_SNM
            // 
            labelMinFuel_SNM.AutoSize = true;
            labelMinFuel_SNM.Location = new Point(6, 46);
            labelMinFuel_SNM.Name = "labelMinFuel_SNM";
            labelMinFuel_SNM.Size = new Size(182, 15);
            labelMinFuel_SNM.TabIndex = 1;
            labelMinFuel_SNM.Text = "Минимальный расход топлива:";
            // 
            // labelMaxFuel_SNM
            // 
            labelMaxFuel_SNM.AutoSize = true;
            labelMaxFuel_SNM.Location = new Point(6, 19);
            labelMaxFuel_SNM.Name = "labelMaxFuel_SNM";
            labelMaxFuel_SNM.Size = new Size(186, 15);
            labelMaxFuel_SNM.TabIndex = 0;
            labelMaxFuel_SNM.Text = "Максимальный расход топлива:";
            // 
            // groupBoxAuto_SNM
            // 
            groupBoxAuto_SNM.Controls.Add(labelCondition_SNM);
            groupBoxAuto_SNM.Controls.Add(labelPlaceCount_SNM);
            groupBoxAuto_SNM.Controls.Add(labelMarkCount_SNM);
            groupBoxAuto_SNM.Controls.Add(labelAutoCount_SNM);
            groupBoxAuto_SNM.Location = new Point(309, 12);
            groupBoxAuto_SNM.Name = "groupBoxAuto_SNM";
            groupBoxAuto_SNM.Size = new Size(275, 300);
            groupBoxAuto_SNM.TabIndex = 1;
            groupBoxAuto_SNM.TabStop = false;
            groupBoxAuto_SNM.Text = "Машины";
            // 
            // labelCondition_SNM
            // 
            labelCondition_SNM.AutoSize = true;
            labelCondition_SNM.Location = new Point(6, 101);
            labelCondition_SNM.Name = "labelCondition_SNM";
            labelCondition_SNM.Size = new Size(168, 15);
            labelCondition_SNM.TabIndex = 3;
            labelCondition_SNM.Text = "Основное состояние машин:";
            // 
            // labelPlaceCount_SNM
            // 
            labelPlaceCount_SNM.AutoSize = true;
            labelPlaceCount_SNM.Location = new Point(6, 74);
            labelPlaceCount_SNM.Name = "labelPlaceCount_SNM";
            labelPlaceCount_SNM.Size = new Size(152, 15);
            labelPlaceCount_SNM.TabIndex = 2;
            labelPlaceCount_SNM.Text = "Самое популярное место:";
            // 
            // labelMarkCount_SNM
            // 
            labelMarkCount_SNM.AutoSize = true;
            labelMarkCount_SNM.Location = new Point(5, 46);
            labelMarkCount_SNM.Name = "labelMarkCount_SNM";
            labelMarkCount_SNM.Size = new Size(145, 15);
            labelMarkCount_SNM.TabIndex = 1;
            labelMarkCount_SNM.Text = "Сама популярная марка:";
            // 
            // labelAutoCount_SNM
            // 
            labelAutoCount_SNM.AutoSize = true;
            labelAutoCount_SNM.Location = new Point(5, 19);
            labelAutoCount_SNM.Name = "labelAutoCount_SNM";
            labelAutoCount_SNM.Size = new Size(118, 15);
            labelAutoCount_SNM.TabIndex = 0;
            labelAutoCount_SNM.Text = "Количество машин:";
            // 
            // chartSpeed_SNM
            // 
            chartArea1.Name = "ChartArea1";
            chartSpeed_SNM.ChartAreas.Add(chartArea1);
            chartSpeed_SNM.Location = new Point(590, 12);
            chartSpeed_SNM.Name = "chartSpeed_SNM";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Name = "Series1";
            chartSpeed_SNM.Series.Add(series1);
            chartSpeed_SNM.Size = new Size(344, 300);
            chartSpeed_SNM.TabIndex = 2;
            chartSpeed_SNM.Text = "chart1";
            // 
            // FormStat
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(946, 320);
            Controls.Add(chartSpeed_SNM);
            Controls.Add(groupBoxAuto_SNM);
            Controls.Add(groupBoxAutoStats_SNM);
            Name = "FormStat";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Статистика";
            Load += FormStatistics_Load;
            groupBoxAutoStats_SNM.ResumeLayout(false);
            groupBoxAutoStats_SNM.PerformLayout();
            groupBoxAuto_SNM.ResumeLayout(false);
            groupBoxAuto_SNM.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)chartSpeed_SNM).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBoxAutoStats_SNM;
        private GroupBox groupBoxAuto_SNM;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartSpeed_SNM;
        private Label labelAvgWeight_SNM;
        private Label labelMinWeight_SNM;
        private Label labelMaxWeight_SNM;
        private Label labelAvgSpeed_SNM;
        private Label labelMinSpeed_SNM;
        private Label labelMaxSpeed_SNM;
        private Label labelAvgFuel_SNM;
        private Label labelMinFuel_SNM;
        private Label labelMaxFuel_SNM;
        private Label labelCondition_SNM;
        private Label labelPlaceCount_SNM;
        private Label labelMarkCount_SNM;
        private Label labelAutoCount_SNM;
    }
}
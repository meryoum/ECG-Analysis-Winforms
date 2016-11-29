namespace FineRGRWinforms
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea33 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend33 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea34 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend34 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea35 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend35 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea36 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend36 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea37 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend37 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea38 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend38 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea39 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend39 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea40 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend40 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            this.eCGfileDataSet = new FineRGRWinforms.ECGfileDataSet();
            this.eXPATTRIBUTESBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.eXP_ATTRIBUTESTableAdapter = new FineRGRWinforms.ECGfileDataSetTableAdapters.EXP_ATTRIBUTESTableAdapter();
            this.MainGridView = new System.Windows.Forms.DataGridView();
            this.SoloAnalysisButton = new System.Windows.Forms.Button();
            this.GroupAnalysisButton = new System.Windows.Forms.Button();
            this.NameBox = new System.Windows.Forms.TextBox();
            this.chSSChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.symmTChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.skoSymmTChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.sdnnChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.indexChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.shiftChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.sTRChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.IntervalChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.constNameBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.eCGfileDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eXPATTRIBUTESBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MainGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chSSChart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.symmTChart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.skoSymmTChart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sdnnChart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.indexChart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.shiftChart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sTRChart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.IntervalChart)).BeginInit();
            this.SuspendLayout();
            // 
            // eCGfileDataSet
            // 
            this.eCGfileDataSet.DataSetName = "ECGfileDataSet";
            this.eCGfileDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // eXPATTRIBUTESBindingSource
            // 
            this.eXPATTRIBUTESBindingSource.DataMember = "EXP_ATTRIBUTES";
            this.eXPATTRIBUTESBindingSource.DataSource = this.eCGfileDataSet;
            // 
            // eXP_ATTRIBUTESTableAdapter
            // 
            this.eXP_ATTRIBUTESTableAdapter.ClearBeforeFill = true;
            // 
            // MainGridView
            // 
            this.MainGridView.AllowUserToAddRows = false;
            this.MainGridView.AllowUserToDeleteRows = false;
            this.MainGridView.AllowUserToOrderColumns = true;
            this.MainGridView.AllowUserToResizeColumns = false;
            this.MainGridView.AllowUserToResizeRows = false;
            this.MainGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MainGridView.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.MainGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.MainGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.MainGridView.Location = new System.Drawing.Point(-6, 12);
            this.MainGridView.Name = "MainGridView";
            this.MainGridView.ReadOnly = true;
            this.MainGridView.Size = new System.Drawing.Size(1257, 479);
            this.MainGridView.TabIndex = 0;
            // 
            // SoloAnalysisButton
            // 
            this.SoloAnalysisButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.SoloAnalysisButton.Location = new System.Drawing.Point(1110, 497);
            this.SoloAnalysisButton.Name = "SoloAnalysisButton";
            this.SoloAnalysisButton.Size = new System.Drawing.Size(159, 23);
            this.SoloAnalysisButton.TabIndex = 1;
            this.SoloAnalysisButton.Text = "Анализировать студента";
            this.SoloAnalysisButton.UseVisualStyleBackColor = true;
            this.SoloAnalysisButton.Click += new System.EventHandler(this.SoloAnalysisButton_Click);
            // 
            // GroupAnalysisButton
            // 
            this.GroupAnalysisButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.GroupAnalysisButton.Location = new System.Drawing.Point(1110, 526);
            this.GroupAnalysisButton.Name = "GroupAnalysisButton";
            this.GroupAnalysisButton.Size = new System.Drawing.Size(159, 23);
            this.GroupAnalysisButton.TabIndex = 2;
            this.GroupAnalysisButton.Text = "Групповой анализ";
            this.GroupAnalysisButton.UseVisualStyleBackColor = true;
            this.GroupAnalysisButton.Click += new System.EventHandler(this.GroupAnalysisButton_Click);
            // 
            // NameBox
            // 
            this.NameBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.NameBox.Location = new System.Drawing.Point(342, 499);
            this.NameBox.Name = "NameBox";
            this.NameBox.Size = new System.Drawing.Size(762, 20);
            this.NameBox.TabIndex = 3;
            // 
            // chSSChart
            // 
            chartArea33.Name = "ChartArea1";
            this.chSSChart.ChartAreas.Add(chartArea33);
            legend33.Name = "Legend1";
            this.chSSChart.Legends.Add(legend33);
            this.chSSChart.Location = new System.Drawing.Point(12, 12);
            this.chSSChart.Name = "chSSChart";
            this.chSSChart.Size = new System.Drawing.Size(426, 160);
            this.chSSChart.TabIndex = 4;
            this.chSSChart.Text = "ЧСС";
            this.chSSChart.Visible = false;
            // 
            // symmTChart
            // 
            this.symmTChart.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            chartArea34.Name = "ChartArea1";
            this.symmTChart.ChartAreas.Add(chartArea34);
            legend34.Name = "Legend1";
            this.symmTChart.Legends.Add(legend34);
            this.symmTChart.Location = new System.Drawing.Point(444, 178);
            this.symmTChart.Name = "symmTChart";
            this.symmTChart.Size = new System.Drawing.Size(373, 157);
            this.symmTChart.TabIndex = 5;
            this.symmTChart.Text = "Середня симетрія Т";
            this.symmTChart.Visible = false;
            // 
            // skoSymmTChart
            // 
            this.skoSymmTChart.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            chartArea35.Name = "ChartArea1";
            this.skoSymmTChart.ChartAreas.Add(chartArea35);
            legend35.Name = "Legend1";
            this.skoSymmTChart.Legends.Add(legend35);
            this.skoSymmTChart.Location = new System.Drawing.Point(823, 12);
            this.skoSymmTChart.Name = "skoSymmTChart";
            this.skoSymmTChart.Size = new System.Drawing.Size(446, 160);
            this.skoSymmTChart.TabIndex = 6;
            this.skoSymmTChart.Text = "СКО симетрії Т";
            this.skoSymmTChart.Visible = false;
            // 
            // sdnnChart
            // 
            this.sdnnChart.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            chartArea36.Name = "ChartArea1";
            this.sdnnChart.ChartAreas.Add(chartArea36);
            legend36.Name = "Legend1";
            this.sdnnChart.Legends.Add(legend36);
            this.sdnnChart.Location = new System.Drawing.Point(12, 178);
            this.sdnnChart.Name = "sdnnChart";
            this.sdnnChart.Size = new System.Drawing.Size(426, 157);
            this.sdnnChart.TabIndex = 7;
            this.sdnnChart.Text = "SDNN";
            this.sdnnChart.Visible = false;
            // 
            // indexChart
            // 
            this.indexChart.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            chartArea37.Name = "ChartArea1";
            this.indexChart.ChartAreas.Add(chartArea37);
            legend37.Name = "Legend1";
            this.indexChart.Legends.Add(legend37);
            this.indexChart.Location = new System.Drawing.Point(444, 341);
            this.indexChart.Name = "indexChart";
            this.indexChart.Size = new System.Drawing.Size(373, 152);
            this.indexChart.TabIndex = 8;
            this.indexChart.Text = "Індекс напруги";
            this.indexChart.Visible = false;
            // 
            // shiftChart
            // 
            this.shiftChart.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            chartArea38.Name = "ChartArea1";
            this.shiftChart.ChartAreas.Add(chartArea38);
            legend38.Name = "Legend1";
            this.shiftChart.Legends.Add(legend38);
            this.shiftChart.Location = new System.Drawing.Point(823, 178);
            this.shiftChart.Name = "shiftChart";
            this.shiftChart.Size = new System.Drawing.Size(446, 157);
            this.shiftChart.TabIndex = 9;
            this.shiftChart.Text = "Зсув ST";
            this.shiftChart.Visible = false;
            // 
            // sTRChart
            // 
            this.sTRChart.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            chartArea39.Name = "ChartArea1";
            this.sTRChart.ChartAreas.Add(chartArea39);
            legend39.Name = "Legend1";
            this.sTRChart.Legends.Add(legend39);
            this.sTRChart.Location = new System.Drawing.Point(12, 341);
            this.sTRChart.Name = "sTRChart";
            this.sTRChart.Size = new System.Drawing.Size(426, 150);
            this.sTRChart.TabIndex = 10;
            this.sTRChart.Text = "Площі T/R";
            this.sTRChart.Visible = false;
            // 
            // IntervalChart
            // 
            this.IntervalChart.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            chartArea40.Name = "ChartArea1";
            this.IntervalChart.ChartAreas.Add(chartArea40);
            legend40.Name = "Legend1";
            this.IntervalChart.Legends.Add(legend40);
            this.IntervalChart.Location = new System.Drawing.Point(823, 341);
            this.IntervalChart.Name = "IntervalChart";
            this.IntervalChart.Size = new System.Drawing.Size(446, 150);
            this.IntervalChart.TabIndex = 12;
            this.IntervalChart.Text = "Інтервал P-Q(R)";
            this.IntervalChart.Visible = false;
            // 
            // constNameBox
            // 
            this.constNameBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.constNameBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.constNameBox.Location = new System.Drawing.Point(444, 76);
            this.constNameBox.Name = "constNameBox";
            this.constNameBox.ReadOnly = true;
            this.constNameBox.Size = new System.Drawing.Size(373, 26);
            this.constNameBox.TabIndex = 13;
            this.constNameBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.constNameBox.Visible = false;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1281, 555);
            this.Controls.Add(this.constNameBox);
            this.Controls.Add(this.IntervalChart);
            this.Controls.Add(this.sTRChart);
            this.Controls.Add(this.shiftChart);
            this.Controls.Add(this.indexChart);
            this.Controls.Add(this.sdnnChart);
            this.Controls.Add(this.skoSymmTChart);
            this.Controls.Add(this.symmTChart);
            this.Controls.Add(this.chSSChart);
            this.Controls.Add(this.NameBox);
            this.Controls.Add(this.GroupAnalysisButton);
            this.Controls.Add(this.SoloAnalysisButton);
            this.Controls.Add(this.MainGridView);
            this.Name = "MainWindow";
            this.Text = "Экг анализ";
            this.Load += new System.EventHandler(this.MainWindow_Load);
            ((System.ComponentModel.ISupportInitialize)(this.eCGfileDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eXPATTRIBUTESBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MainGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chSSChart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.symmTChart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.skoSymmTChart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sdnnChart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.indexChart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.shiftChart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sTRChart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.IntervalChart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private ECGfileDataSet eCGfileDataSet;
        private System.Windows.Forms.BindingSource eXPATTRIBUTESBindingSource;
        private ECGfileDataSetTableAdapters.EXP_ATTRIBUTESTableAdapter eXP_ATTRIBUTESTableAdapter;
        private System.Windows.Forms.DataGridView MainGridView;
        private System.Windows.Forms.Button SoloAnalysisButton;
        private System.Windows.Forms.Button GroupAnalysisButton;
        private System.Windows.Forms.TextBox NameBox;
        private System.Windows.Forms.DataVisualization.Charting.Chart chSSChart;
        private System.Windows.Forms.DataVisualization.Charting.Chart symmTChart;
        private System.Windows.Forms.DataVisualization.Charting.Chart skoSymmTChart;
        private System.Windows.Forms.DataVisualization.Charting.Chart sdnnChart;
        private System.Windows.Forms.DataVisualization.Charting.Chart indexChart;
        private System.Windows.Forms.DataVisualization.Charting.Chart shiftChart;
        private System.Windows.Forms.DataVisualization.Charting.Chart sTRChart;
        private System.Windows.Forms.DataVisualization.Charting.Chart IntervalChart;
        private System.Windows.Forms.TextBox constNameBox;
    }
}


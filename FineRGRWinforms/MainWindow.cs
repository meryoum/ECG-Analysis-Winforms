using System;
using System.Collections.Generic;
using System.Windows.Forms;
using static System.Math;
using System.Windows.Forms.DataVisualization.Charting;

namespace FineRGRWinforms
{
    public partial class MainWindow : Form
    {
        private List<ECGstudent> studentsList = DAL.MakeList();
        private List<ECGview> viewsList = new List<ECGview>();
        private List<ECGStats> statisticsList;
        private int[,] typesList;
        bool soloToggle = false, groupToggle = false;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void MainWindow_Load(object sender, EventArgs e)
        {
            foreach (var s in studentsList)
            {
                viewsList.Add(new ECGview(s));
            }
            viewsList.Sort(new ECGviewsComparer());
            MainGridView.DataSource = viewsList;
            MainGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }

        private void SoloAnalysisButton_Click(object sender, EventArgs e)
        {
            if (!soloToggle && (NameBox.Text != String.Empty || NameBox.Text != ""))
            {
                GroupAnalysisButton.Visible = false;
                GroupAnalysisButton.Enabled = false;
                MainGridView.Visible = false;
                constNameBox.Visible = true;
                soloToggle = true;
                chSSChart.Visible = true;
                indexChart.Visible = true;
                sdnnChart.Visible = true;
                shiftChart.Visible = true;
                skoSymmTChart.Visible = true;
                symmTChart.Visible = true;
                IntervalChart.Visible = true;
                sTRChart.Visible = true;

                constNameBox.Text = NameBox.Text;
                SoloAnalysis(NameBox.Text);
            }
            else if ((NameBox.Text == String.Empty || NameBox.Text == "") && !soloToggle)
            {
                MessageBox.Show("Имя не введено!");
            }
            else
            {
                GroupAnalysisButton.Visible = true;
                GroupAnalysisButton.Enabled = true;
                MainGridView.Visible = true;
                constNameBox.Visible = false;
                soloToggle = false;
                chSSChart.Visible = false;
                indexChart.Visible = false;
                sdnnChart.Visible = false;
                shiftChart.Visible = false;
                skoSymmTChart.Visible = false;
                symmTChart.Visible = false;
                IntervalChart.Visible = false;
                sTRChart.Visible = false;
                MainGridView.DataSource = viewsList;
            }
        }

        private void GroupAnalysisButton_Click(object sender, EventArgs e)
        {
            if (!groupToggle)
            {
                SoloAnalysisButton.Visible = false;
                SoloAnalysisButton.Enabled = false;
                NameBox.Visible = false;
                groupToggle = true;
                Statistics();
                MainGridView.DataSource = statisticsList;
                MainGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                ColorCells();
            }
            else
            {
                SoloAnalysisButton.Visible = true;
                SoloAnalysisButton.Enabled = true;
                NameBox.Visible = true;
                groupToggle = false;
                MainGridView.DataSource = viewsList;
                MainGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                ReturnColor();
            }

        }

        private void Statistics()
        {
            statisticsList = new List<ECGStats>();
            typesList = new int[8, 5];
            foreach (var s in studentsList)
            {
                Type(s.chSS[0], s.chSS[1], s.chSS[2], 0);
                Type(s.symmT[0], s.symmT[1], s.symmT[2], 1);
                Type(s.skoSymmT[0], s.skoSymmT[1], s.skoSymmT[2], 2);
                Type(s.sDNN[0], s.sDNN[1], s.sDNN[2], 3);
                Type(s.index[0], s.index[1], s.index[2], 4);
                Type(s.shiftST[0], s.shiftST[1], s.shiftST[2], 5);
                Type(s.sTR[0], s.sTR[1], s.sTR[2], 6);
                Type(s.intervalPQ[0], s.intervalPQ[1], s.intervalPQ[2], 7);
            }
            for (int i = 0; i < 8; i++)
            {
                string tempname = "";
                switch (i)
                {
                    case 0: tempname = "Чсс"; break;
                    case 1: tempname = "Середня симетрія Т"; break;
                    case 2: tempname = "СКО симетрії Т"; break;
                    case 3: tempname = "SDNN"; break;
                    case 4: tempname = "Індекс напруги"; break;
                    case 5: tempname = "Зсув ST"; break;
                    case 6: tempname = "Площі T/R"; break;
                    case 7: tempname = "Інтервал P-Q(R)"; break;
                }
                var E = new ECGStats
                {
                    name = tempname,
                    type1 = typesList[i, 0].ToString() + String.Format("({0:0.00}%)", Percentage(typesList[i, 0], 46)),
                    type2 = typesList[i, 1].ToString() + String.Format("({0:0.00}%)", Percentage(typesList[i, 1], 46)),
                    type3 = typesList[i, 2].ToString() + String.Format("({0:0.00}%)", Percentage(typesList[i, 2], 46)),
                    type4 = typesList[i, 3].ToString() + String.Format("({0:0.00}%)", Percentage(typesList[i, 3], 46)),
                    type5 = typesList[i, 4].ToString() + String.Format("({0:0.00}%)", Percentage(typesList[i, 4], 46)),
                };
                statisticsList.Add(E);
            }
        }

        private double Percentage(int a, int b)
        {
            return ((double)a / b) * 100.0;
        }

        private void Type(double zero, double one, double three, int index)
        {
            if (Abs(one / 10) >= Abs(one - zero) && Abs(one / 10) >= Abs(one - three)) typesList[index, 4]++;
            else if (one > zero && one > three && Abs(one / 10) < Abs(one - zero) && Abs(one / 10) < Abs(one - three))
                typesList[index, 0]++;
            else if (one < zero && one < three && Abs(one / 10) < Abs(one - zero) && Abs(one / 10) < Abs(one - three))
                typesList[index, 1]++;
            else if (one > zero && one < three && (Abs(one / 10) < Abs(one - zero) || Abs(one / 10) < Abs(one - three)))
                typesList[index, 2]++;
            else if (one < zero && one > three && (Abs(one / 10) < Abs(one - zero) || Abs(one / 10) < Abs(one - three)))
                typesList[index, 3]++;
            else typesList[index, 4]++;
        }

        private void SoloAnalysis(string name)
        {
            foreach (var s in studentsList)
            {
                if (s.name == name) // Борисова Галина Вікторівна
                {
                    chSSChart.Series.Clear();
                    chSSChart.Series.Add("ЧСС");
                    chSSChart.ChartAreas[0].AxisX.Enabled = AxisEnabled.False;
                    chSSChart.ChartAreas[0].AxisY.Enabled = AxisEnabled.False;
                    chSSChart.Series["ЧСС"].ChartType = SeriesChartType.Line;
                    chSSChart.Series["ЧСС"].IsXValueIndexed = false;
                    chSSChart.Series[0].Points.Add(new DataPoint(0, s.chSS[0]));
                    chSSChart.Series[0].Points.Add(new DataPoint(1, s.chSS[1]));
                    chSSChart.Series[0].Points.Add(new DataPoint(2, s.chSS[2]));

                    indexChart.Series.Clear();
                    indexChart.Series.Add("Індекс напруги");
                    indexChart.ChartAreas[0].AxisX.Enabled = AxisEnabled.False;
                    indexChart.ChartAreas[0].AxisY.Enabled = AxisEnabled.False;
                    indexChart.Series["Індекс напруги"].ChartType = SeriesChartType.Line;
                    indexChart.Series["Індекс напруги"].IsXValueIndexed = false;
                    indexChart.Series[0].Points.Add(new DataPoint(0, s.index[0]));
                    indexChart.Series[0].Points.Add(new DataPoint(1, s.index[1]));
                    indexChart.Series[0].Points.Add(new DataPoint(2, s.index[2]));

                    sdnnChart.Series.Clear();
                    sdnnChart.Series.Add("SDNN");
                    sdnnChart.ChartAreas[0].AxisX.Enabled = AxisEnabled.False;
                    sdnnChart.ChartAreas[0].AxisY.Enabled = AxisEnabled.False;
                    sdnnChart.Series["SDNN"].ChartType = SeriesChartType.Line;
                    sdnnChart.Series["SDNN"].IsXValueIndexed = false;
                    sdnnChart.Series[0].Points.Add(new DataPoint(0, s.sDNN[0]));
                    sdnnChart.Series[0].Points.Add(new DataPoint(1, s.sDNN[1]));
                    sdnnChart.Series[0].Points.Add(new DataPoint(2, s.sDNN[2]));

                    shiftChart.Series.Clear();
                    shiftChart.Series.Add("Зсув ST");
                    shiftChart.ChartAreas[0].AxisX.Enabled = AxisEnabled.False;
                    shiftChart.ChartAreas[0].AxisY.Enabled = AxisEnabled.False;
                    shiftChart.Series["Зсув ST"].ChartType = SeriesChartType.Line;
                    shiftChart.Series["Зсув ST"].IsXValueIndexed = false;
                    shiftChart.Series[0].Points.Add(new DataPoint(0, s.shiftST[0]));
                    shiftChart.Series[0].Points.Add(new DataPoint(1, s.shiftST[1]));
                    shiftChart.Series[0].Points.Add(new DataPoint(2, s.shiftST[2]));

                    skoSymmTChart.Series.Clear();
                    skoSymmTChart.Series.Add("СКО симетрії T");
                    skoSymmTChart.ChartAreas[0].AxisX.Enabled = AxisEnabled.False;
                    skoSymmTChart.ChartAreas[0].AxisY.Enabled = AxisEnabled.False;
                    skoSymmTChart.Series["СКО симетрії T"].ChartType = SeriesChartType.Line;
                    skoSymmTChart.Series["СКО симетрії T"].IsXValueIndexed = false;
                    skoSymmTChart.Series[0].Points.Add(new DataPoint(0, s.skoSymmT[0]));
                    skoSymmTChart.Series[0].Points.Add(new DataPoint(1, s.skoSymmT[1]));
                    skoSymmTChart.Series[0].Points.Add(new DataPoint(2, s.skoSymmT[2]));

                    symmTChart.Series.Clear();
                    symmTChart.Series.Add("Середня симетрія T");
                    symmTChart.ChartAreas[0].AxisX.Enabled = AxisEnabled.False;
                    symmTChart.ChartAreas[0].AxisY.Enabled = AxisEnabled.False;
                    symmTChart.Series["Середня симетрія T"].ChartType = SeriesChartType.Line;
                    symmTChart.Series["Середня симетрія T"].IsXValueIndexed = false;
                    symmTChart.Series[0].Points.Add(new DataPoint(0, s.symmT[0]));
                    symmTChart.Series[0].Points.Add(new DataPoint(1, s.symmT[1]));
                    symmTChart.Series[0].Points.Add(new DataPoint(2, s.symmT[2]));

                    IntervalChart.Series.Clear();
                    IntervalChart.Series.Add("Інтервал P-Q(R)");
                    IntervalChart.ChartAreas[0].AxisX.Enabled = AxisEnabled.False;
                    IntervalChart.ChartAreas[0].AxisY.Enabled = AxisEnabled.False;
                    IntervalChart.Series["Інтервал P-Q(R)"].ChartType = SeriesChartType.Line;
                    IntervalChart.Series["Інтервал P-Q(R)"].IsXValueIndexed = false;
                    IntervalChart.Series[0].Points.Add(new DataPoint(0, s.intervalPQ[0]));
                    IntervalChart.Series[0].Points.Add(new DataPoint(1, s.intervalPQ[1]));
                    IntervalChart.Series[0].Points.Add(new DataPoint(2, s.intervalPQ[2]));

                    sTRChart.Series.Clear();
                    sTRChart.Series.Add("Площі T/R");
                    sTRChart.ChartAreas[0].AxisX.Enabled = AxisEnabled.False;
                    sTRChart.ChartAreas[0].AxisY.Enabled = AxisEnabled.False;
                    sTRChart.Series["Площі T/R"].ChartType = SeriesChartType.Line;
                    sTRChart.Series["Площі T/R"].IsXValueIndexed = false;
                    sTRChart.Series[0].Points.Add(new DataPoint(0, s.sTR[0]));
                    sTRChart.Series[0].Points.Add(new DataPoint(1, s.sTR[1]));
                    sTRChart.Series[0].Points.Add(new DataPoint(2, s.sTR[2]));
                }
            }
        }

        private void ColorCells()
        {
            DataGridViewCellStyle style = new DataGridViewCellStyle();
            style.BackColor = System.Drawing.Color.DarkGray;
            style.ForeColor = System.Drawing.Color.White;

            for (int i = 0; i < statisticsList.Count; i++)
            {
                for (int j = 1; j < 6; j++)
                {
                    if (typesList[i, j-1] == max(typesList[i, 0],
                        typesList[i, 1],
                        typesList[i, 2],
                        typesList[i, 3],
                        typesList[i, 4]))
                    {
                        MainGridView.Rows[i].Cells[j].Style = style;
                    }
                }
            }
        }

        private void ReturnColor()
        {
            DataGridViewCellStyle style = new DataGridViewCellStyle();
            style.BackColor = System.Drawing.Color.White;
            style.ForeColor = System.Drawing.Color.Black;
            for (int i = 0; i < statisticsList.Count; i++)
            {
                for (int j = 1; j < 6; j++)
                {
                        MainGridView.Rows[i].Cells[j].Style = style;
                }
            }
        }

        public static double max(double one, double two, double three, double four, double five)
        {
            double[] stuff = new double[5];
            stuff[0] = one;
            stuff[1] = two;
            stuff[2] = three;
            stuff[3] = four;
            stuff[4] = five;
            double max = stuff[0];

            for (int i = 0; i < 5; i++)
            {
                if (stuff[i] > max) max = stuff[i];
            }
            return max;
        }
    }
}

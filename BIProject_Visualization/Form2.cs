using BIProject_Visualization.AppCode;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace BIProject_Visualization
{
    public partial class Form2 : Form
    {
        public  int _year = 0;
        public  string _category; 
        public Form2()
        {
            InitializeComponent();
            cbbCategory.DataSource = ComboboxDAL.GetCategory();
            cbbCategory.DisplayMember = "Product_Category";

            cbbYear.Items.Add(2017);
            cbbYear.Items.Add(2018);

            cbbMonth.Items.Add(1);
            cbbMonth.Items.Add(2);
            cbbMonth.Items.Add(3);
            cbbMonth.Items.Add(4);
            cbbMonth.Items.Add(5);
            cbbMonth.Items.Add(6);
            cbbMonth.Items.Add(7);
            cbbMonth.Items.Add(8);
            cbbMonth.Items.Add(9);
            cbbMonth.Items.Add(10);
            cbbMonth.Items.Add(11);
            cbbMonth.Items.Add(12);

           
            
        }
        private void Form2_Load(object sender, EventArgs e)
        {
            if (_year != 0)
            {
                cbbMonth.Text = "1";
                cbbYear.Text = _year.ToString();
                cbbCategory.Text = _category;

                DrawChart(1, _year, _category);
            }
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            var month = int.Parse(cbbMonth.Text);
            var year = int.Parse(cbbYear.Text);
            var category = cbbCategory.Text;
            DrawChart(month, year, category);
        }

        private void DrawChart(int month, int year, string category)
        {
            chartCol.Series.Clear();
            string total = "Số lượt cho điểm";
            chartCol.Series.Add(total);
            chartCol.Series[total].Color = Color.Blue;
            chartCol.Series[total].Legend = "Legend1";
            chartCol.Series[total].ChartArea = "ChartArea1";
            chartCol.Series[total].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Column;

            
            var data = ReviewDAL.ReviewPerScore(month, year, category);
            var max = 0;
            int i = 1;
            foreach (DataColumn item in data.Columns)
            {
                if (item.ColumnName == "d_month") continue;
                chartCol.Series[total].Points.AddXY(i++, data.Rows[0][item.ColumnName]);
                if (data.Rows[0][item.ColumnName] == null || data.Rows[0][item.ColumnName].ToString() == "") continue;
                if (int.Parse(data.Rows[0][item.ColumnName].ToString()) > max) { max = int.Parse(data.Rows[0][item.ColumnName].ToString()); }
            }
            var cCol = chartCol.ChartAreas[0];
            if (max < 10)
            {
                max += 1;
            }
            else if (max < 50)
            {
                max += 5;
            }
            else if(max < 100)
            {
                max += 10;
            }
            else if(max < 250)
            {
                max += 15;
            }
            else
            {
                max += 50;
            }
            cCol.AxisY.Maximum = max;
            cCol.AxisY.Title = "Quantity";
            cCol.AxisX.Title = "Score";



            //-----PIE-------------------------------------------------
            chartPie.Series.Clear();

            chartPie.Series.Add(total);
            chartPie.Series[total].Legend = "Legend1";
            chartPie.Series[total].ChartArea = "ChartArea1";
            chartPie.Series[total].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;

            foreach (DataColumn item in data.Columns)
            {
                if (item.ColumnName == "d_month") continue;
                chartPie.Series[total].Points.AddXY(item.ColumnName, data.Rows[0][item.ColumnName]);
            }

            foreach (DataPoint p in chartCol.Series[total].Points)
            {
                p.Label = "#PERCENT";
            }
            chartCol.ChartAreas["ChartArea1"].AxisX.MajorGrid.LineWidth = 0;
            chartCol.ChartAreas["ChartArea1"].AxisY.MajorGrid.LineWidth = 0;
        }

      
    }
}

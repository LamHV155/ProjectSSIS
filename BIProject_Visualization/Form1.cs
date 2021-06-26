using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BIProject_Visualization.AppCode;

namespace BIProject_Visualization
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            cbbCategory.DataSource = ComboboxDAL.GetCategory();
            cbbCategory.DisplayMember = "Product_Category";
  
            cbbYear.Items.Add(2017);
            cbbYear.Items.Add(2018);
      
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            var objChart = chart.ChartAreas[0];
            objChart.AxisX.IntervalType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Number;
            //month 1 -12
            objChart.AxisX.Minimum = 1;
            objChart.AxisX.Maximum = 12;

            objChart.AxisY.IntervalType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Number;
            objChart.AxisY.Minimum = 0;
            objChart.AxisY.Maximum = 500;
            int max = 0;

            //Clear
            chart.Series.Clear();
            Random random = new Random();
            var year = int.Parse(cbbYear.SelectedItem.ToString());
            var category = cbbCategory.Text;
            var data = ReviewDAL.ReviewPerMonth(year, category);

            string RevWithCmt = "Số lượt đánh giá có bình luận";
            chart.Series.Add(RevWithCmt);
            chart.Series[RevWithCmt].Color = Color.Red;
            chart.Series[RevWithCmt].Legend = "Legend1";
            chart.Series[RevWithCmt].ChartArea = "ChartArea1";
            chart.Series[RevWithCmt].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            chart.ChartAreas["ChartArea1"].AxisX.MajorGrid.LineWidth = 0;
            chart.ChartAreas["ChartArea1"].AxisY.MajorGrid.LineWidth = 0;
            //adding data
            int i = 1;
            foreach(DataRow item in data.Rows)
            {
                chart.Series[RevWithCmt].Points.AddXY(i, item["review_with_cmt"]);
                i++;
            }


            //-------------line2--------------------------------------
            string TotalRev = "Tổng số lượt đánh giá";
            chart.Series.Add(TotalRev);
            chart.Series[TotalRev].Color = Color.Blue;
            chart.Series[TotalRev].Legend = "Legend1";
            chart.Series[TotalRev].ChartArea = "ChartArea1";
            chart.Series[TotalRev].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            //adding data
            i = 1;
            foreach (DataRow item in data.Rows)
            {
                chart.Series[TotalRev].Points.AddXY(i, item["total_review"]);
                if (int.Parse(item["total_review"].ToString()) > max) { max = int.Parse(item["total_review"].ToString()); }
                i++;
            }
     

            //-------------line3--------------------------------------
            string TotalPro = "Tổng số sản phẩm đá bán";
            chart.Series.Add(TotalPro);
            chart.Series[TotalPro].Color = Color.Green;
            chart.Series[TotalPro].Legend = "Legend1";
            chart.Series[TotalPro].ChartArea = "ChartArea1";
            chart.Series[TotalPro].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            //adding data
            i = 1;
            foreach (DataRow item in data.Rows)
            {
                chart.Series[TotalPro].Points.AddXY(i, item["total_pro_sold"]);
                if (int.Parse(item["total_pro_sold"].ToString()) > max) { max = int.Parse(item["total_pro_sold"].ToString()); }
                i++;
            }
            objChart.AxisY.Maximum = max;
        }

        private void chart_Click(object sender, EventArgs e)
        {

        }

        private void btnViewScore_Click(object sender, EventArgs e)
        {
            Form2 frm2 = new Form2();
            frm2._year = int.Parse(cbbYear.Text);
            frm2._category = cbbCategory.Text;
            frm2.Show();
        }
    }
}


namespace BIProject_Visualization
{
    partial class Form2
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Title title3 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Title title4 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.chartCol = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.cbbMonth = new System.Windows.Forms.ComboBox();
            this.cbbCategory = new System.Windows.Forms.ComboBox();
            this.cbbYear = new System.Windows.Forms.ComboBox();
            this.btnCreate = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.chartPie = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.chartCol)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartPie)).BeginInit();
            this.SuspendLayout();
            // 
            // chartCol
            // 
            chartArea3.Name = "ChartArea1";
            this.chartCol.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.chartCol.Legends.Add(legend3);
            this.chartCol.Location = new System.Drawing.Point(18, 38);
            this.chartCol.Name = "chartCol";
            this.chartCol.Size = new System.Drawing.Size(779, 360);
            this.chartCol.TabIndex = 0;
            this.chartCol.Text = "chart1";
            title3.Name = "ChartCol";
            title3.Text = "Chart";
            this.chartCol.Titles.Add(title3);
            // 
            // cbbMonth
            // 
            this.cbbMonth.FormattingEnabled = true;
            this.cbbMonth.Location = new System.Drawing.Point(417, 430);
            this.cbbMonth.Name = "cbbMonth";
            this.cbbMonth.Size = new System.Drawing.Size(96, 24);
            this.cbbMonth.TabIndex = 1;
            // 
            // cbbCategory
            // 
            this.cbbCategory.FormattingEnabled = true;
            this.cbbCategory.Location = new System.Drawing.Point(169, 430);
            this.cbbCategory.Name = "cbbCategory";
            this.cbbCategory.Size = new System.Drawing.Size(173, 24);
            this.cbbCategory.TabIndex = 2;
            // 
            // cbbYear
            // 
            this.cbbYear.FormattingEnabled = true;
            this.cbbYear.Location = new System.Drawing.Point(587, 430);
            this.cbbYear.Name = "cbbYear";
            this.cbbYear.Size = new System.Drawing.Size(121, 24);
            this.cbbYear.TabIndex = 3;
            // 
            // btnCreate
            // 
            this.btnCreate.Location = new System.Drawing.Point(1039, 422);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(98, 38);
            this.btnCreate.TabIndex = 4;
            this.btnCreate.Text = "Create";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(98, 433);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "Category";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(364, 433);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Month";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(543, 433);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "Year";
            // 
            // chartPie
            // 
            chartArea4.Name = "ChartArea1";
            this.chartPie.ChartAreas.Add(chartArea4);
            legend4.Name = "Legend1";
            this.chartPie.Legends.Add(legend4);
            this.chartPie.Location = new System.Drawing.Point(803, 38);
            this.chartPie.Name = "chartPie";
            this.chartPie.Size = new System.Drawing.Size(478, 360);
            this.chartPie.TabIndex = 8;
            this.chartPie.Text = "chartPie";
            title4.Name = "ChartPie";
            this.chartPie.Titles.Add(title4);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1302, 482);
            this.Controls.Add(this.chartPie);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.cbbYear);
            this.Controls.Add(this.cbbCategory);
            this.Controls.Add(this.cbbMonth);
            this.Controls.Add(this.chartCol);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chartCol)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartPie)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chartCol;
        private System.Windows.Forms.ComboBox cbbMonth;
        private System.Windows.Forms.ComboBox cbbCategory;
        private System.Windows.Forms.ComboBox cbbYear;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartPie;
    }
}
namespace genetic_algorithm
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.txt_result = new System.Windows.Forms.TextBox();
            this.txt_key = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.chrt_avg_weight = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chrt_max_weight = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_calculate = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.chrt_avg_weight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chrt_max_weight)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_result
            // 
            this.txt_result.Location = new System.Drawing.Point(156, 60);
            this.txt_result.Name = "txt_result";
            this.txt_result.Size = new System.Drawing.Size(132, 20);
            this.txt_result.TabIndex = 0;
            // 
            // txt_key
            // 
            this.txt_key.Location = new System.Drawing.Point(156, 34);
            this.txt_key.Name = "txt_key";
            this.txt_key.Size = new System.Drawing.Size(132, 20);
            this.txt_key.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Загаданное значение";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Отгаданное значение";
            // 
            // chrt_avg_weight
            // 
            chartArea1.Name = "ChartArea1";
            this.chrt_avg_weight.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chrt_avg_weight.Legends.Add(legend1);
            this.chrt_avg_weight.Location = new System.Drawing.Point(12, 133);
            this.chrt_avg_weight.Name = "chrt_avg_weight";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Avg";
            this.chrt_avg_weight.Series.Add(series1);
            this.chrt_avg_weight.Size = new System.Drawing.Size(321, 170);
            this.chrt_avg_weight.TabIndex = 4;
            this.chrt_avg_weight.Text = "chart1";
            // 
            // chrt_max_weight
            // 
            chartArea2.Name = "ChartArea1";
            this.chrt_max_weight.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chrt_max_weight.Legends.Add(legend2);
            this.chrt_max_weight.Location = new System.Drawing.Point(12, 349);
            this.chrt_max_weight.Name = "chrt_max_weight";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Max";
            this.chrt_max_weight.Series.Add(series2);
            this.chrt_max_weight.Size = new System.Drawing.Size(321, 170);
            this.chrt_max_weight.TabIndex = 5;
            this.chrt_max_weight.Text = "chart2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(36, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(234, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Изменения среднего совпадения популяции";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(36, 330);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(268, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Изменения максимального совпадения популяции";
            // 
            // btn_calculate
            // 
            this.btn_calculate.Location = new System.Drawing.Point(120, 86);
            this.btn_calculate.Name = "btn_calculate";
            this.btn_calculate.Size = new System.Drawing.Size(75, 23);
            this.btn_calculate.TabIndex = 8;
            this.btn_calculate.Text = "Расчитать";
            this.btn_calculate.UseVisualStyleBackColor = true;
            this.btn_calculate.Click += new System.EventHandler(this.btn_calculate_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(345, 531);
            this.Controls.Add(this.btn_calculate);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.chrt_max_weight);
            this.Controls.Add(this.chrt_avg_weight);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_key);
            this.Controls.Add(this.txt_result);
            this.Name = "Form1";
            this.Text = "Генетический алгоритм";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chrt_avg_weight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chrt_max_weight)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_result;
        private System.Windows.Forms.TextBox txt_key;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataVisualization.Charting.Chart chrt_avg_weight;
        private System.Windows.Forms.DataVisualization.Charting.Chart chrt_max_weight;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_calculate;
    }
}


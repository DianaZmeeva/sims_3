namespace sims_3_fly
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.input_weight = new System.Windows.Forms.NumericUpDown();
            this.input_size = new System.Windows.Forms.NumericUpDown();
            this.input_speed = new System.Windows.Forms.NumericUpDown();
            this.input_angle = new System.Windows.Forms.NumericUpDown();
            this.input_height = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.input_weight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.input_size)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.input_speed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.input_angle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.input_height)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.input_weight);
            this.panel1.Controls.Add(this.input_size);
            this.panel1.Controls.Add(this.input_speed);
            this.panel1.Controls.Add(this.input_angle);
            this.panel1.Controls.Add(this.input_height);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(439, 100);
            this.panel1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(352, 71);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 10;
            this.button1.Text = "Launch";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // input_weight
            // 
            this.input_weight.Location = new System.Drawing.Point(245, 37);
            this.input_weight.Name = "input_weight";
            this.input_weight.Size = new System.Drawing.Size(120, 20);
            this.input_weight.TabIndex = 9;
            this.input_weight.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // input_size
            // 
            this.input_size.DecimalPlaces = 2;
            this.input_size.Location = new System.Drawing.Point(245, 7);
            this.input_size.Name = "input_size";
            this.input_size.Size = new System.Drawing.Size(120, 20);
            this.input_size.TabIndex = 8;
            this.input_size.Value = new decimal(new int[] {
            10,
            0,
            0,
            131072});
            // 
            // input_speed
            // 
            this.input_speed.Location = new System.Drawing.Point(56, 66);
            this.input_speed.Name = "input_speed";
            this.input_speed.Size = new System.Drawing.Size(120, 20);
            this.input_speed.TabIndex = 7;
            this.input_speed.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // input_angle
            // 
            this.input_angle.Location = new System.Drawing.Point(56, 37);
            this.input_angle.Name = "input_angle";
            this.input_angle.Size = new System.Drawing.Size(120, 20);
            this.input_angle.TabIndex = 6;
            this.input_angle.Value = new decimal(new int[] {
            45,
            0,
            0,
            0});
            this.input_angle.ValueChanged += new System.EventHandler(this.numericUpDown2_ValueChanged);
            // 
            // input_height
            // 
            this.input_height.Location = new System.Drawing.Point(57, 11);
            this.input_height.Name = "input_height";
            this.input_height.Size = new System.Drawing.Size(120, 20);
            this.input_height.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(198, 41);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Weight";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(198, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(27, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Size";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Speed";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Angle";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Height";
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            this.chart1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chart1.Location = new System.Drawing.Point(0, 100);
            this.chart1.Name = "chart1";
            series1.BorderWidth = 3;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Name = "Series1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(439, 327);
            this.chart1.TabIndex = 1;
            this.chart1.Text = "chart1";
            // 
            // timer1
            // 
            this.timer1.Interval = 10;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(439, 427);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.input_weight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.input_size)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.input_speed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.input_angle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.input_height)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.NumericUpDown input_weight;
        private System.Windows.Forms.NumericUpDown input_size;
        private System.Windows.Forms.NumericUpDown input_speed;
        private System.Windows.Forms.NumericUpDown input_angle;
        private System.Windows.Forms.NumericUpDown input_height;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Timer timer1;
    }
}


namespace KTP
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
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.Coord = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.picture = new System.Windows.Forms.PictureBox();
            this.textBoxN = new System.Windows.Forms.TextBox();
            this.textBoxM = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.textBoxTime = new System.Windows.Forms.TextBox();
            this.textBoxChance = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxSpeed = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.textBoxDot1 = new System.Windows.Forms.TextBox();
            this.DotN = new System.Windows.Forms.CheckBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.button4 = new System.Windows.Forms.Button();
            this.InfDot = new System.Windows.Forms.CheckBox();
            this.SIRSIS = new System.Windows.Forms.CheckBox();
            this.label_S = new System.Windows.Forms.Label();
            this.label_I = new System.Windows.Forms.Label();
            this.label_SR = new System.Windows.Forms.Label();
            this.openFileMatrix = new System.Windows.Forms.OpenFileDialog();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.Statis = new System.Windows.Forms.TextBox();
            this.grap = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.picture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grap)).BeginInit();
            this.SuspendLayout();
            // 
            // Coord
            // 
            this.Coord.AutoSize = true;
            this.Coord.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Coord.Location = new System.Drawing.Point(119, 44);
            this.Coord.Name = "Coord";
            this.Coord.Size = new System.Drawing.Size(92, 19);
            this.Coord.TabIndex = 3;
            this.Coord.Text = "Сoordinates";
            this.Coord.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Beige;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(12, 100);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(272, 47);
            this.button1.TabIndex = 5;
            this.button1.Text = "Draw";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "columns";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 17);
            this.label2.TabIndex = 8;
            this.label2.Text = "lines";
            // 
            // picture
            // 
            this.picture.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.picture.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picture.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.picture.Location = new System.Drawing.Point(292, 12);
            this.picture.Name = "picture";
            this.picture.Size = new System.Drawing.Size(500, 500);
            this.picture.TabIndex = 10;
            this.picture.TabStop = false;
            this.picture.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Picture_MouseClick);
            // 
            // textBoxN
            // 
            this.textBoxN.Location = new System.Drawing.Point(78, 42);
            this.textBoxN.Name = "textBoxN";
            this.textBoxN.Size = new System.Drawing.Size(35, 20);
            this.textBoxN.TabIndex = 1;
            this.textBoxN.Text = "16";
            // 
            // textBoxM
            // 
            this.textBoxM.Location = new System.Drawing.Point(78, 72);
            this.textBoxM.Name = "textBoxM";
            this.textBoxM.Size = new System.Drawing.Size(35, 20);
            this.textBoxM.TabIndex = 2;
            this.textBoxM.Text = "16";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.MistyRose;
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(213, 40);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(70, 54);
            this.button2.TabIndex = 6;
            this.button2.TabStop = false;
            this.button2.Text = "Clear";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Beige;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(156, 250);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(130, 50);
            this.button3.TabIndex = 50;
            this.button3.Text = "Start";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.Button3_Click);
            // 
            // textBoxTime
            // 
            this.textBoxTime.Location = new System.Drawing.Point(80, 224);
            this.textBoxTime.Name = "textBoxTime";
            this.textBoxTime.Size = new System.Drawing.Size(35, 20);
            this.textBoxTime.TabIndex = 9;
            this.textBoxTime.Text = "2";
            // 
            // textBoxChance
            // 
            this.textBoxChance.Location = new System.Drawing.Point(80, 198);
            this.textBoxChance.Name = "textBoxChance";
            this.textBoxChance.Size = new System.Drawing.Size(35, 20);
            this.textBoxChance.TabIndex = 7;
            this.textBoxChance.Text = "30";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(9, 199);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 17);
            this.label3.TabIndex = 15;
            this.label3.Text = "chance";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(9, 225);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 17);
            this.label4.TabIndex = 16;
            this.label4.Text = "time heal";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(160, 199);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 17);
            this.label5.TabIndex = 18;
            this.label5.Text = "speed";
            // 
            // textBoxSpeed
            // 
            this.textBoxSpeed.Location = new System.Drawing.Point(213, 198);
            this.textBoxSpeed.Name = "textBoxSpeed";
            this.textBoxSpeed.Size = new System.Drawing.Size(40, 20);
            this.textBoxSpeed.TabIndex = 8;
            this.textBoxSpeed.Text = "175";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label6.Location = new System.Drawing.Point(12, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 22);
            this.label6.TabIndex = 19;
            this.label6.Text = "Matrix";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label7.Location = new System.Drawing.Point(12, 165);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(95, 22);
            this.label7.TabIndex = 20;
            this.label7.Text = "Simulation";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(160, 225);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(48, 17);
            this.label8.TabIndex = 22;
            this.label8.Text = "Dot №";
            // 
            // textBoxDot1
            // 
            this.textBoxDot1.HideSelection = false;
            this.textBoxDot1.Location = new System.Drawing.Point(213, 224);
            this.textBoxDot1.Name = "textBoxDot1";
            this.textBoxDot1.Size = new System.Drawing.Size(40, 20);
            this.textBoxDot1.TabIndex = 10;
            this.textBoxDot1.Text = "55";
            // 
            // DotN
            // 
            this.DotN.AutoSize = true;
            this.DotN.Checked = true;
            this.DotN.CheckState = System.Windows.Forms.CheckState.Checked;
            this.DotN.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DotN.Location = new System.Drawing.Point(119, 72);
            this.DotN.Name = "DotN";
            this.DotN.Size = new System.Drawing.Size(81, 19);
            this.DotN.TabIndex = 4;
            this.DotN.Text = "Dots Num";
            this.DotN.UseVisualStyleBackColor = true;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.PapayaWhip;
            this.button4.Enabled = false;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(12, 250);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(130, 50);
            this.button4.TabIndex = 23;
            this.button4.Text = "Reset";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.Button4_Click);
            // 
            // InfDot
            // 
            this.InfDot.AutoSize = true;
            this.InfDot.Location = new System.Drawing.Point(259, 228);
            this.InfDot.Name = "InfDot";
            this.InfDot.Size = new System.Drawing.Size(15, 14);
            this.InfDot.TabIndex = 11;
            this.InfDot.UseVisualStyleBackColor = true;
            this.InfDot.MouseClick += new System.Windows.Forms.MouseEventHandler(this.InfDot_MouseClick);
            // 
            // SIRSIS
            // 
            this.SIRSIS.AutoSize = true;
            this.SIRSIS.Checked = true;
            this.SIRSIS.CheckState = System.Windows.Forms.CheckState.Checked;
            this.SIRSIS.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SIRSIS.Location = new System.Drawing.Point(113, 170);
            this.SIRSIS.Name = "SIRSIS";
            this.SIRSIS.Size = new System.Drawing.Size(15, 14);
            this.SIRSIS.TabIndex = 12;
            this.SIRSIS.UseVisualStyleBackColor = true;
            this.SIRSIS.MouseClick += new System.Windows.Forms.MouseEventHandler(this.SIRSIS_MouseClick);
            // 
            // label_S
            // 
            this.label_S.AutoSize = true;
            this.label_S.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_S.ForeColor = System.Drawing.Color.Red;
            this.label_S.Location = new System.Drawing.Point(128, 171);
            this.label_S.Name = "label_S";
            this.label_S.Size = new System.Drawing.Size(15, 13);
            this.label_S.TabIndex = 26;
            this.label_S.Text = "S";
            // 
            // label_I
            // 
            this.label_I.AutoSize = true;
            this.label_I.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_I.ForeColor = System.Drawing.Color.Orange;
            this.label_I.Location = new System.Drawing.Point(139, 171);
            this.label_I.Name = "label_I";
            this.label_I.Size = new System.Drawing.Size(11, 13);
            this.label_I.TabIndex = 27;
            this.label_I.Text = "I";
            // 
            // label_SR
            // 
            this.label_SR.AutoSize = true;
            this.label_SR.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_SR.ForeColor = System.Drawing.Color.DarkGreen;
            this.label_SR.Location = new System.Drawing.Point(146, 171);
            this.label_SR.Name = "label_SR";
            this.label_SR.Size = new System.Drawing.Size(16, 13);
            this.label_SR.TabIndex = 28;
            this.label_SR.Text = "R";
            // 
            // openFileMatrix
            // 
            this.openFileMatrix.FileName = "openFileMatrix";
            // 
            // button5
            // 
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Location = new System.Drawing.Point(81, 10);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(48, 22);
            this.button5.TabIndex = 0;
            this.button5.Text = "File";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.Button5_Click);
            // 
            // button6
            // 
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Location = new System.Drawing.Point(135, 10);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(48, 22);
            this.button6.TabIndex = 52;
            this.button6.Text = "Save";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.Button6_Click);
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.WhiteSmoke;
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button7.Location = new System.Drawing.Point(12, 306);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(274, 50);
            this.button7.TabIndex = 53;
            this.button7.Text = "Graphics and Status";
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.Button7_Click);
            // 
            // Statis
            // 
            this.Statis.Enabled = false;
            this.Statis.Font = new System.Drawing.Font("MS UI Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Statis.Location = new System.Drawing.Point(12, 362);
            this.Statis.Multiline = true;
            this.Statis.Name = "Statis";
            this.Statis.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.Statis.Size = new System.Drawing.Size(274, 150);
            this.Statis.TabIndex = 55;
            this.Statis.Text = "Dotes №| State | Kol ";
            this.Statis.Visible = false;
            // 
            // grap
            // 
            this.grap.BackColor = System.Drawing.SystemColors.Control;
            this.grap.BorderlineColor = System.Drawing.SystemColors.Control;
            this.grap.BorderlineWidth = 0;
            this.grap.BorderSkin.PageColor = System.Drawing.SystemColors.Control;
            chartArea1.AlignmentStyle = ((System.Windows.Forms.DataVisualization.Charting.AreaAlignmentStyles)((System.Windows.Forms.DataVisualization.Charting.AreaAlignmentStyles.PlotPosition | System.Windows.Forms.DataVisualization.Charting.AreaAlignmentStyles.AxesView)));
            chartArea1.Name = "ChartArea1";
            chartArea1.ShadowColor = System.Drawing.SystemColors.Control;
            this.grap.ChartAreas.Add(chartArea1);
            this.grap.Location = new System.Drawing.Point(-35, 510);
            this.grap.Name = "grap";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.Color = System.Drawing.Color.Red;
            series1.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F);
            series1.Name = "SusGraph";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series2.Color = System.Drawing.Color.Gold;
            series2.Name = "InfGraph";
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series3.Color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            series3.Name = "RefGraph";
            this.grap.Series.Add(series1);
            this.grap.Series.Add(series2);
            this.grap.Series.Add(series3);
            this.grap.Size = new System.Drawing.Size(862, 205);
            this.grap.TabIndex = 56;
            this.grap.TabStop = false;
            this.grap.Text = "chart1";
            this.grap.TextAntiAliasingQuality = System.Windows.Forms.DataVisualization.Charting.TextAntiAliasingQuality.SystemDefault;
            this.grap.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(804, 675);
            this.Controls.Add(this.Statis);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.label_S);
            this.Controls.Add(this.SIRSIS);
            this.Controls.Add(this.InfDot);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.DotN);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.textBoxDot1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBoxSpeed);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxChance);
            this.Controls.Add(this.textBoxTime);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.textBoxM);
            this.Controls.Add(this.textBoxN);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Coord);
            this.Controls.Add(this.picture);
            this.Controls.Add(this.label_I);
            this.Controls.Add(this.label_SR);
            this.Controls.Add(this.grap);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Project 2o3";
            ((System.ComponentModel.ISupportInitialize)(this.picture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grap)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.CheckBox Coord;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox picture;
        private System.Windows.Forms.TextBox textBoxN;
        private System.Windows.Forms.TextBox textBoxM;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox textBoxTime;
        private System.Windows.Forms.TextBox textBoxChance;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxSpeed;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBoxDot1;
        private System.Windows.Forms.CheckBox DotN;
        public System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.CheckBox InfDot;
        private System.Windows.Forms.CheckBox SIRSIS;
        private System.Windows.Forms.Label label_S;
        private System.Windows.Forms.Label label_I;
        private System.Windows.Forms.Label label_SR;
        private System.Windows.Forms.OpenFileDialog openFileMatrix;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.TextBox Statis;
        private System.Windows.Forms.DataVisualization.Charting.Chart grap;
    }
}


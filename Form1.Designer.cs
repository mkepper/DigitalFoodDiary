namespace DigitalFoodDiary
{
    partial class Form1
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.txtbxFood = new System.Windows.Forms.TextBox();
            this.txtbxCalories = new System.Windows.Forms.TextBox();
            this.lblTypeOfFood = new System.Windows.Forms.Label();
            this.lblCalories = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.cmbbxMealType = new System.Windows.Forms.ComboBox();
            this.lblMealType = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.chrtLineGraph = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.btnAddMeal = new System.Windows.Forms.Button();
            this.caloriesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dtaUITotalCal = new System.Windows.Forms.DataGridView();
            this.dtaGVTotalCal = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.lblGraph = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chrtLineGraph)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.caloriesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtaUITotalCal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtaGVTotalCal)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtbxFood
            // 
            this.txtbxFood.AcceptsReturn = true;
            this.txtbxFood.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtbxFood.Location = new System.Drawing.Point(56, 95);
            this.txtbxFood.Name = "txtbxFood";
            this.txtbxFood.Size = new System.Drawing.Size(148, 20);
            this.txtbxFood.TabIndex = 0;
            // 
            // txtbxCalories
            // 
            this.txtbxCalories.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtbxCalories.Location = new System.Drawing.Point(232, 95);
            this.txtbxCalories.Name = "txtbxCalories";
            this.txtbxCalories.Size = new System.Drawing.Size(100, 20);
            this.txtbxCalories.TabIndex = 1;
            // 
            // lblTypeOfFood
            // 
            this.lblTypeOfFood.Font = new System.Drawing.Font("Ebrima", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTypeOfFood.Location = new System.Drawing.Point(53, 67);
            this.lblTypeOfFood.Name = "lblTypeOfFood";
            this.lblTypeOfFood.Size = new System.Drawing.Size(100, 25);
            this.lblTypeOfFood.TabIndex = 3;
            this.lblTypeOfFood.Text = "Type of Food";
            // 
            // lblCalories
            // 
            this.lblCalories.Font = new System.Drawing.Font("Ebrima", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCalories.Location = new System.Drawing.Point(229, 63);
            this.lblCalories.Name = "lblCalories";
            this.lblCalories.Size = new System.Drawing.Size(66, 25);
            this.lblCalories.TabIndex = 4;
            this.lblCalories.Text = "Calories";
            this.lblCalories.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblDate
            // 
            this.lblDate.Font = new System.Drawing.Font("Ebrima", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.Location = new System.Drawing.Point(357, 67);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(46, 22);
            this.lblDate.TabIndex = 5;
            this.lblDate.Text = "Date ";
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.CalendarTitleBackColor = System.Drawing.SystemColors.Control;
            this.dateTimePicker.CustomFormat = "yyyy-MM-dd";
            this.dateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker.Location = new System.Drawing.Point(360, 95);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker.TabIndex = 6;
            // 
            // cmbbxMealType
            // 
            this.cmbbxMealType.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cmbbxMealType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbbxMealType.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbbxMealType.FormattingEnabled = true;
            this.cmbbxMealType.Items.AddRange(new object[] {
            "Breakfast",
            "Lunch",
            "Dinner",
            "Snack"});
            this.cmbbxMealType.Location = new System.Drawing.Point(0, 0);
            this.cmbbxMealType.Name = "cmbbxMealType";
            this.cmbbxMealType.Size = new System.Drawing.Size(200, 21);
            this.cmbbxMealType.TabIndex = 7;
            // 
            // lblMealType
            // 
            this.lblMealType.AutoSize = true;
            this.lblMealType.Font = new System.Drawing.Font("Ebrima", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMealType.Location = new System.Drawing.Point(584, 67);
            this.lblMealType.Name = "lblMealType";
            this.lblMealType.Size = new System.Drawing.Size(69, 17);
            this.lblMealType.TabIndex = 8;
            this.lblMealType.Text = "Meal Type";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cmbbxMealType);
            this.panel1.Location = new System.Drawing.Point(587, 95);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 20);
            this.panel1.TabIndex = 9;
            // 
            // chrtLineGraph
            // 
            this.chrtLineGraph.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            chartArea1.Name = "ChartArea1";
            this.chrtLineGraph.ChartAreas.Add(chartArea1);
            this.chrtLineGraph.Location = new System.Drawing.Point(58, 284);
            this.chrtLineGraph.Name = "chrtLineGraph";
            series1.ChartArea = "ChartArea1";
            series1.Name = "Total";
            this.chrtLineGraph.Series.Add(series1);
            this.chrtLineGraph.Size = new System.Drawing.Size(729, 303);
            this.chrtLineGraph.TabIndex = 10;
            this.chrtLineGraph.Text = "chart1";
            // 
            // btnAddMeal
            // 
            this.btnAddMeal.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnAddMeal.FlatAppearance.BorderSize = 0;
            this.btnAddMeal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddMeal.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddMeal.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAddMeal.Location = new System.Drawing.Point(687, 138);
            this.btnAddMeal.Name = "btnAddMeal";
            this.btnAddMeal.Size = new System.Drawing.Size(100, 32);
            this.btnAddMeal.TabIndex = 12;
            this.btnAddMeal.Text = "ADD MEAL";
            this.btnAddMeal.UseVisualStyleBackColor = false;
            this.btnAddMeal.Click += new System.EventHandler(this.btnAddMeal_Click);
            // 
            // dtaUITotalCal
            // 
            this.dtaUITotalCal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtaUITotalCal.Location = new System.Drawing.Point(814, 224);
            this.dtaUITotalCal.Name = "dtaUITotalCal";
            this.dtaUITotalCal.Size = new System.Drawing.Size(12, 13);
            this.dtaUITotalCal.TabIndex = 14;
            this.dtaUITotalCal.Visible = false;
            // 
            // dtaGVTotalCal
            // 
            this.dtaGVTotalCal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtaGVTotalCal.Location = new System.Drawing.Point(816, 207);
            this.dtaGVTotalCal.Name = "dtaGVTotalCal";
            this.dtaGVTotalCal.Size = new System.Drawing.Size(10, 11);
            this.dtaGVTotalCal.TabIndex = 11;
            this.dtaGVTotalCal.Visible = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Gainsboro;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.btnAddMeal);
            this.panel2.Controls.Add(this.txtbxFood);
            this.panel2.Controls.Add(this.txtbxCalories);
            this.panel2.Controls.Add(this.dateTimePicker);
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Controls.Add(this.lblCalories);
            this.panel2.Controls.Add(this.lblTypeOfFood);
            this.panel2.Controls.Add(this.lblMealType);
            this.panel2.Controls.Add(this.lblDate);
            this.panel2.Location = new System.Drawing.Point(-7, -1);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(859, 191);
            this.panel2.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Ebrima", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label1.Location = new System.Drawing.Point(51, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 25);
            this.label1.TabIndex = 17;
            this.label1.Text = "Add your meals";
            // 
            // lblGraph
            // 
            this.lblGraph.AutoSize = true;
            this.lblGraph.Font = new System.Drawing.Font("Ebrima", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGraph.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblGraph.Location = new System.Drawing.Point(53, 228);
            this.lblGraph.Name = "lblGraph";
            this.lblGraph.Size = new System.Drawing.Size(201, 25);
            this.lblGraph.TabIndex = 16;
            this.lblGraph.Text = "Weekly calorie intake";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(850, 599);
            this.Controls.Add(this.lblGraph);
            this.Controls.Add(this.dtaUITotalCal);
            this.Controls.Add(this.dtaGVTotalCal);
            this.Controls.Add(this.chrtLineGraph);
            this.Controls.Add(this.panel2);
            this.Name = "Form1";
            this.Text = "Food Diary";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chrtLineGraph)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.caloriesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtaUITotalCal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtaGVTotalCal)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtbxFood;
        private System.Windows.Forms.TextBox txtbxCalories;
        private System.Windows.Forms.Label lblTypeOfFood;
        private System.Windows.Forms.Label lblCalories;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.ComboBox cmbbxMealType;
        private System.Windows.Forms.Label lblMealType;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chrtLineGraph;
        private System.Windows.Forms.Button btnAddMeal;
        private System.Windows.Forms.BindingSource caloriesBindingSource;
        private System.Windows.Forms.DataGridView dtaUITotalCal;
        private System.Windows.Forms.DataGridView dtaGVTotalCal;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblGraph;
        private System.Windows.Forms.Label label1;
    }
}


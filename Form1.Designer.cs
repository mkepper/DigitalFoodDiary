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
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnAddMeal = new System.Windows.Forms.Button();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.caloriesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chrtLineGraph)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.caloriesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // txtbxFood
            // 
            this.txtbxFood.AcceptsReturn = true;
            this.txtbxFood.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtbxFood.Location = new System.Drawing.Point(58, 76);
            this.txtbxFood.Name = "txtbxFood";
            this.txtbxFood.Size = new System.Drawing.Size(148, 20);
            this.txtbxFood.TabIndex = 0;
            // 
            // txtbxCalories
            // 
            this.txtbxCalories.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtbxCalories.Location = new System.Drawing.Point(234, 76);
            this.txtbxCalories.Name = "txtbxCalories";
            this.txtbxCalories.Size = new System.Drawing.Size(100, 20);
            this.txtbxCalories.TabIndex = 1;
            // 
            // lblTypeOfFood
            // 
            this.lblTypeOfFood.AutoSize = true;
            this.lblTypeOfFood.Location = new System.Drawing.Point(55, 44);
            this.lblTypeOfFood.Name = "lblTypeOfFood";
            this.lblTypeOfFood.Size = new System.Drawing.Size(70, 13);
            this.lblTypeOfFood.TabIndex = 3;
            this.lblTypeOfFood.Text = "Type of Food";
            // 
            // lblCalories
            // 
            this.lblCalories.AutoSize = true;
            this.lblCalories.Location = new System.Drawing.Point(234, 44);
            this.lblCalories.Name = "lblCalories";
            this.lblCalories.Size = new System.Drawing.Size(44, 13);
            this.lblCalories.TabIndex = 4;
            this.lblCalories.Text = "Calories";
            this.lblCalories.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(358, 44);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(33, 13);
            this.lblDate.TabIndex = 5;
            this.lblDate.Text = "Date ";
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.CalendarTitleBackColor = System.Drawing.SystemColors.Control;
            this.dateTimePicker.Location = new System.Drawing.Point(361, 75);
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
            this.lblMealType.Location = new System.Drawing.Point(584, 44);
            this.lblMealType.Name = "lblMealType";
            this.lblMealType.Size = new System.Drawing.Size(57, 13);
            this.lblMealType.TabIndex = 8;
            this.lblMealType.Text = "Meal Type";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cmbbxMealType);
            this.panel1.Location = new System.Drawing.Point(587, 76);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 21);
            this.panel1.TabIndex = 9;
            // 
            // chrtLineGraph
            // 
            this.chrtLineGraph.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            chartArea1.Name = "ChartArea1";
            this.chrtLineGraph.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chrtLineGraph.Legends.Add(legend1);
            this.chrtLineGraph.Location = new System.Drawing.Point(58, 341);
            this.chrtLineGraph.Name = "chrtLineGraph";
            this.chrtLineGraph.Size = new System.Drawing.Size(729, 307);
            this.chrtLineGraph.TabIndex = 10;
            this.chrtLineGraph.Text = "chart1";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(58, 144);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(729, 84);
            this.dataGridView1.TabIndex = 11;
            // 
            // btnAddMeal
            // 
            this.btnAddMeal.Location = new System.Drawing.Point(712, 103);
            this.btnAddMeal.Name = "btnAddMeal";
            this.btnAddMeal.Size = new System.Drawing.Size(75, 23);
            this.btnAddMeal.TabIndex = 12;
            this.btnAddMeal.Text = "Add Meal";
            this.btnAddMeal.UseVisualStyleBackColor = true;
            this.btnAddMeal.Click += new System.EventHandler(this.btnAddMeal_Click);
            // 
            // btnGenerate
            // 
            this.btnGenerate.Location = new System.Drawing.Point(712, 654);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(75, 23);
            this.btnGenerate.TabIndex = 13;
            this.btnGenerate.Text = "Generate";
            this.btnGenerate.UseVisualStyleBackColor = true;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(58, 245);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(729, 90);
            this.dataGridView2.TabIndex = 14;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(859, 691);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.btnGenerate);
            this.Controls.Add(this.btnAddMeal);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.chrtLineGraph);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblMealType);
            this.Controls.Add(this.dateTimePicker);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.lblCalories);
            this.Controls.Add(this.lblTypeOfFood);
            this.Controls.Add(this.txtbxCalories);
            this.Controls.Add(this.txtbxFood);
            this.Name = "Form1";
            this.Text = "Food Diary";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chrtLineGraph)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.caloriesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
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
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnAddMeal;
        private System.Windows.Forms.BindingSource caloriesBindingSource;
        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.DataGridView dataGridView2;
    }
}


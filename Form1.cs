using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DigitalFoodDiary
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //Initialize the two data sets later to be replaced with database functionality
        DataTable table1 = new DataTable();
        DataTable table2 = new DataTable();
    private void Form1_Load(object sender, EventArgs e)
        {
            //Create the regions for the first data set
            table1.Columns.Add("Day of the Week", typeof(DateTime));
            table1.Columns.Add("Breakfast", typeof(int));
            table1.Columns.Add("Lunch", typeof(int));
            table1.Columns.Add("Dinner", typeof(int));
            table1.Columns.Add("Snacks", typeof(int));
            table1.Columns.Add("Total", typeof(int));

            dataGridView1.DataSource = table1;

            //Create the regions for the second data set
            table2.Columns.Add("Day of the Week", typeof(DateTime));
            table2.Columns.Add("Type of Food", typeof(string));
            table2.Columns.Add("Calories", typeof(int));
            table2.Columns.Add("Meal Type", typeof(string));

            dataGridView2.DataSource = table2;

        }
        private void btnAddMeal_Click(object sender, EventArgs e)
        {
            //Add user data authentification
            //On click the second data set will populate with the data from the user
            table2.Rows.Add(dateTimePicker.Value.ToShortDateString(), txtbxFood.Text, txtbxCalories.Text, cmbbxMealType.SelectedItem);
            dataGridView2.DataSource = table2;

            //On click the data from the second table will be exchanged to the first set and totaled then populated in the first data set

            //Add functionality for the input from the user to be sent to a .txt file for now and later implement a database solution

        }

        
    }
}

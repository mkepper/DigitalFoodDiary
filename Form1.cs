using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DigitalFoodDiary
{ 
    public partial class Form1 : Form
    {
        string connectionString = @"Data Source=stusql-cis250-w01-fa21.cimq4ah3jd04.us-east-2.rds.amazonaws.com,1433;Initial Catalog=mk0825822;Persist Security Info=True;User ID=mk0825822;Password=825822";

        public Form1()
        {
            InitializeComponent();
        }

        private void loadGraph()
        {
            SqlConnection sqlCon = new SqlConnection(connectionString);

            SqlCommand cmd = sqlCon.CreateCommand();
            cmd.CommandText = "SELECT DayoftheWeek, Total FROM TotalPerDay WHERE DayoftheWeek >= DATEADD(day, -7, GETDATE())";
            SqlDataReader myReader;

            
            try
            {
                sqlCon.Open();
                myReader = cmd.ExecuteReader();


                this.chrtLineGraph.Series["Total"].Points.Clear();
            while (myReader.Read())
            {

            chrtLineGraph.Series["Total"].Points.AddXY(myReader["DayoftheWeek"], myReader["Total"].ToString());

            }

            }
            catch(Exception ex)
            {
            MessageBox.Show(ex.Message);
            }

                
            
        }

    private void Form1_Load(object sender, EventArgs e)
        {
            loadGraph();
        }

        private void checkNewDate()
        {

            using (SqlConnection sqlCon = new SqlConnection(connectionString))
            {

                using (SqlCommand command = new SqlCommand("SELECT CASE WHEN EXISTS (SELECT DayoftheWeek FROM TotalCalories WHERE DayoftheWeek = '" + dateTimePicker.Text + "') THEN CAST (1 AS BIT) ELSE CAST (0 AS BIT) END", sqlCon))
                {
                    sqlCon.Open();

                    var results = command.ExecuteScalar();

                    if ((bool)results == true)
                    {
                        updateTotalCal(dateTimePicker.Value, Int32.Parse(txtbxCalories.Text), cmbbxMealType.SelectedItem.ToString());
                    }
                    else
                    {
                        command.CommandText = "INSERT INTO dbo.TotalCalories VALUES ('" + dateTimePicker.Text + "', 0, 0, 0, 0)";
                        command.ExecuteNonQuery();
                        command.CommandText = "INSERT INTO dbo.TotalPerDay VALUES ('" + dateTimePicker.Text + "', 0)";
                        command.ExecuteNonQuery();
                        updateTotalCal(dateTimePicker.Value, Int32.Parse(txtbxCalories.Text), cmbbxMealType.SelectedItem.ToString());
                    }

                    sqlCon.Close();
                }
            }
        }

        

        private void updateTotalCal(DateTime date, int cal, string type)
        {
            int newCal = 0;
            int breakfastCal = 0;
            int lunchCal = 0;
            int dinnerCal = 0;
            int snacksCal = 0;
            int total = 0;
            string cmdString = "";

            using (SqlConnection sqlCon = new SqlConnection(connectionString))
            {
                
                using (SqlCommand command = new SqlCommand("SELECT BreakfastCal, LunchCal, DinnerCal, SnacksCal FROM TotalCalories WHERE DayoftheWeek = '" + date + "'", sqlCon))
                {
                    sqlCon.Open();
                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            breakfastCal = Convert.ToInt32(reader["BreakfastCal"]);
                            lunchCal = Convert.ToInt32(reader["LunchCal"]);
                            dinnerCal = Convert.ToInt32(reader["DinnerCal"]);
                            snacksCal = Convert.ToInt32(reader["SnacksCal"]);
                        }
                    }

                    total = breakfastCal + lunchCal + dinnerCal + snacksCal + Convert.ToInt32(txtbxCalories.Text);

                    if (type == "Breakfast")
                    {
                        newCal = cal + breakfastCal;
                        cmdString = "UPDATE dbo.TotalCalories SET BreakfastCal = '" + newCal + "' WHERE DayoftheWeek = '" + date + "'";
                    }
                    else if (type == "Lunch")
                    {
                        newCal = cal + lunchCal;
                        cmdString = "UPDATE dbo.TotalCalories SET LunchCal = '" + newCal + "' WHERE DayoftheWeek = '" + date + "'";
                    }
                    else if (type == "Dinner")
                    {
                        newCal = cal + dinnerCal;
                        cmdString = "UPDATE dbo.TotalCalories SET DinnerCal = '" + newCal + "' WHERE DayoftheWeek = '" + date + "'";
                    }
                    else if (type == "Snacks")
                    {
                        newCal = cal + snacksCal;
                        cmdString = "UPDATE dbo.TotalCalories SET SnacksCal = '" + newCal + "' WHERE DayoftheWeek = '" + date + "'";
                    }

                    

                    sqlCon.Close();
                    sqlCon.Open();

                    SqlCommand cmd = new SqlCommand(cmdString, sqlCon);
                    cmd.ExecuteNonQuery();
                    cmdString = "Update dbo.TotalPerDay SET Total = '" + total + "' WHERE DayoftheWeek = '" + date + "'";
                    SqlCommand comd = new SqlCommand(cmdString, sqlCon);
                    comd.ExecuteNonQuery();

                    reader.Close();
                    sqlCon.Close();
                    loadGraph();

                }
            }
        }



        private void btnAddMeal_Click(object sender, EventArgs e)
        {
            int calories;
            if (int.TryParse(txtbxCalories.Text, out calories))
            {

                using (SqlConnection sqlCon = new SqlConnection(connectionString))
                {

                    SqlCommand command = new SqlCommand();

                    command.CommandType = CommandType.Text;
                    command.CommandText = String.Format("INSERT INTO dbo.UserInputs (DayoftheWeek, Calories, NameofFood, MealType) VALUES ('" + dateTimePicker.Text + "','" + calories + "','" + txtbxFood.Text + "','" + cmbbxMealType.SelectedItem.ToString() + "')");
                    command.Connection = sqlCon;

                    sqlCon.Open();
                    command.ExecuteNonQuery();

                    SqlDataAdapter conUserInputes = new SqlDataAdapter("SELECT * FROM UserInputs", sqlCon);
                    DataTable table2 = new DataTable();
                    conUserInputes.Fill(table2);

                    dtaUITotalCal.DataSource = table2;

                    sqlCon.Close();

                    checkNewDate();

                }

            }
            else
            {
                MessageBox.Show("Please provide a number value only for calories");
                txtbxCalories.Clear();
            }
            

        }

    }
}
    


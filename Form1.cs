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

        private void loadFormOne()
        {
            using (SqlConnection sqlCon = new SqlConnection(connectionString))
            {
                sqlCon.Open();
                SqlDataAdapter conTotalCal = new SqlDataAdapter("SELECT * FROM TotalCalories", sqlCon);
                DataTable table1 = new DataTable();
                conTotalCal.Fill(table1);

                dtaGVTotalCal.DataSource = table1;

                sqlCon.Close();
            }
        }

    private void Form1_Load(object sender, EventArgs e)
        {
            loadFormOne();
        }

        private void updateTotalCal(DateTime date, int cal, string type)
        {
            int newCal = 0;
            int breakfastCal = 0;
            int lunchCal = 0;
            int dinnerCal = 0;
            int snacksCal = 0;
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

                    reader.Close();
                    sqlCon.Close();

                }
            }
        }



        private void btnAddMeal_Click(object sender, EventArgs e)
        {
            using (SqlConnection sqlCon = new SqlConnection(connectionString))
            {

                SqlCommand cmd = new SqlCommand();

                cmd.CommandType = CommandType.Text;
                cmd.CommandText = String.Format("INSERT INTO dbo.UserInputs VALUES ('" + dateTimePicker.Text + "','" + txtbxCalories.Text + "','" + txtbxFood.Text + "','" + cmbbxMealType.SelectedItem.ToString() + "')");
                cmd.Connection = sqlCon;

                sqlCon.Open();
                cmd.ExecuteNonQuery();

                SqlDataAdapter conUserInputes = new SqlDataAdapter("SELECT * FROM UserInputs", sqlCon);
                DataTable table2 = new DataTable();
                conUserInputes.Fill(table2);

                dtaUITotalCal.DataSource = table2;

                sqlCon.Close();

                updateTotalCal(dateTimePicker.Value, Int32.Parse(txtbxCalories.Text), cmbbxMealType.SelectedItem.ToString());
                loadFormOne();
            }

        }

        
        
    }
}

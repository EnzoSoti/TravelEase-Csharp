﻿using LiveChartsCore;
using LiveChartsCore.Kernel.Sketches;
using LiveChartsCore.SkiaSharpView;
using LiveChartsCore.SkiaSharpView.Painting;
using LiveChartsCore.SkiaSharpView.WinForms;
using Microsoft.Data.SqlClient;
using SkiaSharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TechnoSystem
{
    public partial class Dashboard : LayoutForm
    {
        public Dashboard(string user, string pass)
        {
            adminShowValues(user, pass);
            InitializeComponent();

        }

        string connectionString = "Data Source=DESKTOP-HU962IE;Initial Catalog=TravelEaseDB;Persist Security Info=True;User ID=root1;Password=password1;Encrypt=False;TrustServerCertificate=True";

        private void pieChart1_Load(object sender, EventArgs e)
        {
            LoadPieChart();

        }

        private void LoadPieChart()
        {
            try
            {
                
                string query = "SELECT CATEGORY, COUNT(*) AS Count FROM TBL_REGISTER GROUP BY CATEGORY";

                using (SqlConnection connection = new SqlConnection(connectionString))
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();

                    var pieSeries = new List<PieSeries<int>>();
                    int totalCount = 0;

                    while (reader.Read())
                    {
                        string category = reader["CATEGORY"].ToString();
                        int count = Convert.ToInt32(reader["Count"]);

                        pieSeries.Add(new PieSeries<int>
                        {
                            Name = category,
                            Values = new int[] { count },
                            InnerRadius = 50

                        });

                        totalCount += count;
                    }

                    pieChart1.Series = pieSeries.ToArray();


                    label3.Text = totalCount.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading pie chart: " + ex.Message);
            }
        }

        public void LoadCartesian()
        {
            try
            {
                double totalAmount = 0;
             
                string query = "SELECT SUM(AMOUNT) AS TotalAmount FROM TBL_SELLING";

                using (SqlConnection connection = new SqlConnection(connectionString))
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();


                    if (reader.Read())
                    {
                        if (!reader.IsDBNull(0))
                        {
                            totalAmount = reader.GetDouble(0);
                        }
                    }
                    var whitePaint = new SolidColorPaint(SKColors.White);
                    cartesianChart1.XAxes = new List<Axis>
            {
                new Axis
                {

                    Labels = new string[] {"January", "Febuary", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December"},
                     LabelsPaint = whitePaint
                }
            };

                    cartesianChart1.YAxes = new List<Axis>
            {
                new Axis
                {
                    Labels = new string[] {"1,000", "2,000", "3,000", "4,000", "5,000", "6,000", "7,000", "8,000", "9,000", "10,000", "11,000", "12,000" },
                    LabelsPaint = whitePaint
                }
            };

                    cartesianChart1.Series = new ISeries[]
        {
    new LineSeries<double>
    {
        Values = new double[] { 1,2,3,4,5,6,7,8,9,10,11,12,13}

    },

        };

                    cartesianChart1.ZoomMode = LiveChartsCore.Measure.ZoomAndPanMode.X;
                    cartesianChart1.ZoomMode = LiveChartsCore.Measure.ZoomAndPanMode.Y;

                    label4.Text = totalAmount.ToString();
                }
            }




            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }


        private void cartesianChart1_Load(object sender, EventArgs e)
        {
            LoadCartesian();

        }

        public void adminlogin(string username, string password)
        {
            try
            {
 
                string selectQuery = "SELECT * FROM TBL_ADMIN WHERE ADMIN_USERNAME = @username AND PASSWORD = @password";

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    using (SqlCommand command = new SqlCommand(selectQuery, connection))
                    {
                        command.Parameters.AddWithValue("@username", username);
                        command.Parameters.AddWithValue("@password", password);
                        connection.Open();

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                MessageBox.Show($"Successfully Login {username}");

                                adminShowValues(username, password);
                                ShowDialog();
                            }
                            else
                            {
                                MessageBox.Show("Incorrect Username or Password. Please try again.");
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex}");
            }
        }



    }
}


using System;
using System.Drawing;
using System.Data;
using System.Text;
using System.Data.SqlClient; 



namespace AssignmentForm
{

    public partial class Form1 : Form
    {
        SqlConnection Con = new SqlConnection(@"Data Source=SAFWAN;Initial Catalog=Student;Integrated Security=True;TrustServerCertificate=True");

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            populate();
        }

        int StudentKey = 0;
        private void populate()
        {
            try
            {
                Con.Open();
                string query = "SELECT * FROM StudentTbl";
                SqlDataAdapter sda = new SqlDataAdapter(query, Con);
                SqlCommandBuilder builder = new SqlCommandBuilder(sda);
                var ds = new DataSet();
                sda.Fill(ds);
                StudentDGV.DataSource = ds.Tables[0];
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                Con.Close();
            }
        }
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox3.Text == "" || textBox4.Text == "")
            {
                MessageBox.Show("Missing Data");
                return; // Exit the method if data is missing
            }

            try
            {
                using (SqlConnection con = new SqlConnection(@"Data Source=SAFWAN;Initial Catalog=Student;Integrated Security=True;TrustServerCertificate=True"))
                {
                    con.Open();
                    string query = "INSERT INTO StudentTbl (StudentName, StudentAge, StudentPhone) VALUES (@StudentName, @StudentAge, @StudentPhone)";
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@StudentName", textBox1.Text);
                        cmd.Parameters.AddWithValue("@StudentAge", textBox3.Text);
                        cmd.Parameters.AddWithValue("@StudentPhone", textBox4.Text);
                        cmd.ExecuteNonQuery(); // Execute the query
                    }
                }

                MessageBox.Show("Student Successfully Added");

                // Refresh the DataGridView
                populate();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void StudentDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (StudentDGV.SelectedRows.Count > 0 && e.RowIndex >= 0)
            {
                textBox1.Text = StudentDGV.SelectedRows[0].Cells[1].Value.ToString();
                
                textBox3.Text = StudentDGV.SelectedRows[0].Cells[3].Value.ToString();
                textBox4.Text = StudentDGV.SelectedRows[0].Cells[2].Value.ToString();

                if (textBox3.Text == "")
                {
                    StudentKey = 0;
                }
                else
                {
                    StudentKey = Convert.ToInt32(StudentDGV.SelectedRows[0].Cells[0].Value.ToString());
                }
            }
        }

        private void ResetBtn_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void ClearBtn_Click(object sender, EventArgs e)
        {
            if (StudentKey == 0)
            {
                MessageBox.Show("Select The Student To Be Deleted");
            }
            else
            {
                try
                {
                    using (SqlConnection con = new SqlConnection(@"Data Source=SAFWAN;Initial Catalog=Student;Integrated Security=True;TrustServerCertificate=True"))
                    {
                        con.Open();
                        string query = "DELETE FROM StudentTbl WHERE StudentId=@StudentKey";
                        using (SqlCommand cmd = new SqlCommand(query, con))
                        {
                            cmd.Parameters.AddWithValue("@StudentKey", StudentKey);

                            // Execute the delete command
                            int result = cmd.ExecuteNonQuery();

                            if (result > 0) // Check if any row was affected (deleted)
                            {
                                MessageBox.Show("Student Deleted Successfully");
                            }
                            else
                            {
                                MessageBox.Show("Failed to Delete Student. Please try again.");
                            }
                        }
                    }

                    // Refresh the DataGridView after deletion
                    populate();
                    clear();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        
    }

        private void EditBtn_Click(object sender, EventArgs e)
        {
            if (StudentKey == 0)
            {
                MessageBox.Show("Please select a Student to edit.");
                return;
            }

            if (textBox1.Text == "" || textBox3.Text == "" || textBox4.Text == "")
            {
                MessageBox.Show("Missing Data");
                return; // Exit if data is missing
            }

            try
            {
                using (SqlConnection con = new SqlConnection(@"Data Source=SAFWAN;Initial Catalog=Student;Integrated Security=True;TrustServerCertificate=True"))
                {
                    con.Open();
                    string query = "UPDATE StudentTbl SET StudentName=@StudentName, StudentAge=@StudentAge, StudentPhone=@StudentPhone WHERE StudentId=@StudentKey";
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@StudentName", textBox1.Text);
                        cmd.Parameters.AddWithValue("@StudentAge", textBox3.Text);
                        cmd.Parameters.AddWithValue("@StudentPhone", textBox4.Text);
                        cmd.Parameters.AddWithValue("@StudentKey", StudentKey);
                        cmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Student Successfully Updated");
                populate();
                clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void clear()
        {
            textBox4.Text = "";
            
            StudentKey = 0;
            textBox1.Text = "";
            textBox3.Text = "";
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }

}


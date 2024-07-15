using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;
using MySql.Data.MySqlClient;

namespace Finals_152_153_2019
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //Connection string
        string strCon = "datasource=127.0.0.1; database=iot; port=3306; username=root; password=";

        private void InsertDatabase()
        {
            using (MySqlConnection sqlCon = new MySqlConnection(strCon))
            {
                try
                {
                    //Query string
                    string strQuery = "INSERT INTO pirTBL(Date,Time) VALUES(?Date, ?Time);";
                    sqlCon.Open(); //open the connection
                    //sql command
                    using (MySqlCommand sqlCom = new MySqlCommand(strQuery, sqlCon))
                    {
                        sqlCom.Parameters.AddWithValue("?Date", LBLdate.Text);
                        sqlCom.Parameters.AddWithValue("?Time", LBLtime.Text);
                        sqlCom.ExecuteNonQuery();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            
        }

        private void RefreshGrid()
        {
            string retrieveQuery = "Select * from pirTBL";
            MySqlDataAdapter sda = new MySqlDataAdapter(retrieveQuery, strCon);
            DataSet ds = new DataSet();
            sda.Fill(ds, "pirTBL");
            pirTBL.DataSource = ds.Tables[0];
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            
            label4.Text = serialPort1.ReadExisting().ToString();
            LBLdate.Text = DateTime.Now.ToString("MM/dd/yyyy");
            LBLtime.Text = DateTime.Now.ToString("hh:mm:ss tt");
            
            //if motion detected, insert to database
            if (label4.Text.Contains("Motion detected"))
            {
                //show an alert
                MessageBox.Show(label4.Text, "Alert", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                InsertDatabase();
                RefreshGrid(); //refresh datagridview
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //loads data into the 'iotDataSet.pirtbl' table
            this.pirtblTableAdapter.Fill(this.iotDataSet.pirtbl);
            
            if (!serialPort1.IsOpen)
            {
                serialPort1.Open();
            }
            else
            {
                serialPort1.Close();
            }
        }
        private void pirTBL_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        //Button that will clear all data 
        private void BTNclear_Click(object sender, EventArgs e)
        {
            using (MySqlConnection sqlCon = new MySqlConnection(strCon))
            {
                try
                {
                    DialogResult dr = MessageBox.Show("Clear all data?", "Confirmation", MessageBoxButtons.YesNo,
                        MessageBoxIcon.Information);
                    if (dr == DialogResult.Yes)
                    {
                        //Query string
                        string strQuery = "DELETE FROM pirTBL;";
                        sqlCon.Open(); //open the connection
                        using (MySqlCommand sqlCom = new MySqlCommand(strQuery, sqlCon))
                        {
                            sqlCom.ExecuteNonQuery();
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            RefreshGrid();
        }
        //Button wherein you can search by date and it will highlight the specified row(s)
        private void button1_Click(object sender, EventArgs e)
        {
            string searchValue = textBox1.Text;
            pirTBL.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            try
            {
                bool valueResult = false;
                foreach (DataGridViewRow row in pirTBL.Rows)
                {
                    for (int i = 0; i < row.Cells.Count; i++)
                    {
                        if (row.Cells[i].Value != null && row.Cells[i].Value.ToString().Equals(searchValue))
                        {
                            int rowIndex = row.Index;
                            pirTBL.Rows[rowIndex].Selected = true;
                            valueResult = true;
                            break;
                        }
                    }

                }
                if (!valueResult)
                {
                    MessageBox.Show("Unable to find " + textBox1.Text, "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        //Gets the relative position of the band within the DataGridView control.
        private void BTNdel_Click(object sender, EventArgs e)
        {
            using (MySqlConnection sqlCon = new MySqlConnection(strCon))
            {
                try
                {
                    DialogResult dr = MessageBox.Show("Delete selected data?", "Confirmation", MessageBoxButtons.YesNo,
                        MessageBoxIcon.Information);
                    if (dr == DialogResult.Yes)
                    {
                        //Query string
                        string strQuery = "DELETE FROM pirTBL WHERE Date='" +textBox1.Text + "';";
                        sqlCon.Open(); //open the connection
                        using (MySqlCommand sqlCom = new MySqlCommand(strQuery, sqlCon))
                        {
                            sqlCom.ExecuteNonQuery();
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            RefreshGrid();
            
        }
    }
}

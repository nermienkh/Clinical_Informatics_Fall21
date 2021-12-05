using myclinic_tabs.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace myclinic_tabs
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnShowDoctors_Click(object sender, EventArgs e)
        {

            string conStr = ConfigurationManager.ConnectionStrings["db"].ToString();
            #region fill DataGrid using myclinic database doctors table



            using (SqlConnection sqlcon = new SqlConnection(conStr))
            {
                sqlcon.Open();
                #region select query with no parameters

                //select all query 
                SqlDataAdapter sqldataadapter = new SqlDataAdapter("select * from DOCTOR", sqlcon);
                //create dataTable to store the retrieved data
                DataTable datatable = new DataTable();
                //fill retrieved data to data table
                sqldataadapter.Fill(datatable);
                //bind data to grid view
                dataGridView1.DataSource = datatable;
                #endregion
            }



            #endregion
        }

        private void btn_addPatient_Click(object sender, EventArgs e)
        {


            Patient patient = new Patient();
            patient.PAT_ID = txt_patientID.Text;
            patient.PAT_FNAME = txt_patientFName.Text;
            patient.PAT_LNAME = txt_patientLName.Text;
            patient.PAT_NationalID = txt_patientNationalID.Text;
            patient.PAT_PHONE = txt_patientPhone.Text;
            patient.PAT_DOB = dateTimePicker_PatientDOB.Value;

            //Validation
            ValidationContext validationContext = new ValidationContext(patient);
            IList<ValidationResult> errors = new List<ValidationResult>();
            if (!Validator.TryValidateObject(patient, validationContext, errors, true))
            {
                foreach (var item in errors)
                {
                    switch (item.MemberNames.First())
                    {
                        case "PAT_ID":
                            Lbl_IDError.Text = item.ErrorMessage;
                            Lbl_IDError.ForeColor = Color.Red;
                            break;
                        case "PAT_NationalID":
                            Lbl_NIDError.Text = item.ErrorMessage;
                            break;
                        case "PAT_FNAME":
                            Lbl_FNameError.Text = item.ErrorMessage;
                            break;
                        case "PAT_LNAME":
                            Lbl_LNameError.Text = item.ErrorMessage;
                            break;
                        case "PAT_DOB":
                            Lbl_DoBError.Text = item.ErrorMessage;
                            break;
                        default:
                            MessageBox.Show(item.ErrorMessage);
                            break;
                    }
                }
            }
            else
            {
                //database insert patient
                string conStr = ConfigurationManager.ConnectionStrings["db"].ToString();
                #region insert into Patient table
                using (SqlConnection sqlcon = new SqlConnection(conStr))
                {
                    sqlcon.Open();
                    try
                    {
                        //select all query with parameters.
                        SqlCommand command = new SqlCommand("INSERT INTO  PATIENT (PAT_ID,[PAT_NationalID],PAT_FNAME,PAT_LNAME,PAT_DOB,PAT_PHONE)" + " VALUES( @PAT_ID, @PAT_NationalID, @PAT_FNAME, @PAT_LNAME, @PAT_DOB, @PAT_PHONE)", sqlcon);
                        //Add the parameters for the InsertCommand.
                        command.Parameters.Add("@PAT_ID", SqlDbType.NVarChar).Value = patient.PAT_ID.ToString();
                        command.Parameters.Add("@PAT_NationalID", SqlDbType.NVarChar).Value = patient.PAT_NationalID;
                        command.Parameters.Add("@PAT_FNAME", SqlDbType.VarChar).Value = patient.PAT_FNAME;
                        command.Parameters.Add("@PAT_LNAME", SqlDbType.VarChar).Value = patient.PAT_LNAME;
                        command.Parameters.Add("@PAT_PHONE", SqlDbType.VarChar).Value = patient.PAT_PHONE;
                        command.Parameters.Add("@PAT_DOB", SqlDbType.DateTime).Value = patient.PAT_DOB;
                        //pass command to new instance of sqlDataAdapter 
                        SqlDataAdapter adp = new SqlDataAdapter();
                        adp.InsertCommand = command;
                        adp.InsertCommand.ExecuteNonQuery();
                        MessageBox.Show("Patient inserted !! ");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.ToString());
                    }
                }
            }
            #endregion
        }

        private void comboBox1_DropDown(object sender, EventArgs e)
        {


            string conStr = ConfigurationManager.ConnectionStrings["db"].ToString();
            #region fill DataGrid using Bickstores database


            using (SqlConnection sqlcon = new SqlConnection(conStr))
            {
                sqlcon.Open();
                #region select query with no parameters

                //select all query 
                SqlDataAdapter sqldataadapter = new SqlDataAdapter("select * from DRUG", sqlcon);
                ////create dataTable to store the retrieved data
                DataTable datatable = new DataTable();
                //fill retrieved data to data table
                sqldataadapter.Fill(datatable);

                //bind data to combobox
                List<Drug> Drugs = new List<Drug>();
                foreach (DataRow row in datatable.Rows)
                {
                    Drug drug = new Drug() { DRUG_CODE = row["DRUG_CODE"].ToString(), DRUG_NAME = row["DRUG_NAME"].ToString() };
                    Drugs.Add(drug);
                }

                comboBox_listDrugs.DataSource = Drugs.Select(x => x.DRUG_NAME).ToList();
                #endregion
            }
            #endregion
        }

        private void btnFindDrugByCode_Click(object sender, EventArgs e)
        {
            string conStr = ConfigurationManager.ConnectionStrings["db"].ToString();
            #region find drug by code 


            using (SqlConnection sqlcon = new SqlConnection(conStr))
            {
                sqlcon.Open();


                #region select query with  parameters
                //select all query with parameter
                SqlCommand command = new SqlCommand("SELECT * FROM DRUG" + " WHERE [DRUG_CODE] = @drugcode", sqlcon);
                // Add parameters and values to SelectCommand .
                command.Parameters.Add("@drugcode", SqlDbType.VarChar).Value = textBox_drugCode.Text;

                //specify command type [text or stored procedure]
                command.CommandType = CommandType.Text;
                //pass command to new instance of sqlDataAdapter 
                SqlDataAdapter adp = new SqlDataAdapter(command);
                //create dataTable to store the retrieved data
                DataTable dataTable2 = new DataTable();
                //fill retrieved data to data table
                adp.Fill(dataTable2);
                //bind data to grid view

                if (dataTable2.Rows.Count != 0)
                    lblDrugStatus.Text = "Drug Found";
                else
                    lblDrugStatus.Text = "Drug not Found";
                #endregion
            }

            #endregion




        }

        private void dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        
    }
}
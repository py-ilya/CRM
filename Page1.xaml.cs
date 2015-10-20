using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Data.SqlClient;
using System.Data;





namespace CRM
{
    /// <summary>
    /// Логика взаимодействия для Page1.xaml
    /// </summary>
    public partial class Page1 : Page
    {
        
        SqlConnection connection;
        string connectionString;
        SqlCommand command;
        string sql = "Select * from tbContractor";
        
        public Page1()
        {
         
            InitializeComponent();

            connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\dbERP.mdf;Integrated Security=True";

        }

        private void Grid_Loaded(object sender, RoutedEventArgs e)
        {

            PopulateCompany();
            

        }
        private void PopulateCompany()
        {
            DataSet dtset = new DataSet();

            connection = new SqlConnection(connectionString);
            if (this.txtSearch.Text == "")
            {
                sql = "Select * from tbContractor";
            }
            else
            {
               sql = "Select * from tbContractor where name like N'%" + this.txtSearch.Text + "%'; ";;
            }
                command = new SqlCommand(sql, connection);
                SqlDataAdapter adapter = new SqlDataAdapter();
                connection.Open();
                adapter.SelectCommand = command;
                adapter.Fill(dtset, "tbContractor");

                listBox1.DataContext = dtset;
                          
           connection.Close();
            


        }

        private void listBox1_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            DataRowView oDataRowView = listBox1.SelectedItem as DataRowView;
            string sValue = oDataRowView.Row["Id"].ToString();
            string sql = "Select * from tbContractor where Id=" + sValue;

            SqlCommand command = new SqlCommand(sql, connection);
            connection.Open();
            SqlDataReader reader = command.ExecuteReader();

                         
                while (reader.Read())
                {
                
                txtNumber.Text = reader.GetInt32(0).ToString();
                if (!reader.IsDBNull(1))
                {
                    txtName.Text = reader.GetString(1);
                }
                else
                {
                    txtName.Text = "";
                }

                if (!reader.IsDBNull(2))
                {
                    txtFullName.Text = reader.GetString(2);
                }
                else
                {
                    txtFullName.Text = "";
                }
                if (!reader.IsDBNull(3))
                {
                    txtForm.Text = reader.GetString(3);
                }
                else
                {
                    txtForm.Text = "";
                }
                if (!reader.IsDBNull(4))
                {
                    txtResident.Text = reader.GetString(4);
                }
                else
                {
                    txtResident.Text = "";
                }
                if (!reader.IsDBNull(5))
                {
                    txtAnother.Text = reader.GetString(5);
                }
                else
                {
                    txtAnother.Text = "";
                }
                if (!reader.IsDBNull(6))
                {
                    txtManager.Text = reader.GetString(6);
                }
                else
                {
                    txtManager.Text = "";
                }

                if (!reader.IsDBNull(7))
                {
                    txtPosition.Text = reader.GetString(7);
                }
                else
                {
                    txtPosition.Text = "";
                }
                if (!reader.IsDBNull(8))
                {
                    txtManager2.Text = reader.GetString(8);
                }
                else
                {
                    txtManager2.Text = "";
                }
                if (!reader.IsDBNull(9))
                {
                    txtPosition2.Text = reader.GetString(9);
                }
                else
                {
                    txtPosition2.Text = "";
                }
                if (!reader.IsDBNull(10))
                {
                    txtEDRPOU.Text = reader.GetString(10);
                }
                else
                {
                    txtEDRPOU.Text = "";
                }
                if (!reader.IsDBNull(11))
                {
                    txtLegalAdress.Text = reader.GetString(11);
                }
                else
                {
                    txtLegalAdress.Text = "";
                }
                if (!reader.IsDBNull(12))
                {
                    txtPhisicalAdress.Text = reader.GetString(12);
                }
                else
                {
                    txtPhisicalAdress.Text = "";
                }
                if (!reader.IsDBNull(13))
                {
                    txtBankRequisits.Text = reader.GetString(13);
                }
                else
                {
                    txtBankRequisits.Text = "";
                }
                if (!reader.IsDBNull(14))
                {
                    txtBankCode.Text = reader.GetString(14);
                }
                else
                {
                    txtBankCode.Text = "";
                }
                if (!reader.IsDBNull(15))
                {
                    txtOther1.Text = reader.GetString(15);
                }
                else
                {
                    txtOther1.Text = "";
                }
                if (!reader.IsDBNull(16))
                {
                    txtOther2.Text = reader.GetString(16);
                }
                else
                {
                    txtOther2.Text = "";
                }
                if (!reader.IsDBNull(17))
                {
                    txtOther3.Text = reader.GetString(17);
                }
                else
                {
                    txtOther3.Text = "";
                }



                }
            connection.Close();

            


        } //Select

        private void button_Copy1_Click(object sender, RoutedEventArgs e)
        {
            string Query = "insert into tbContractor (name,fullName,form,resident,another,directorName,positiona,lastNameInitials,position,EDRPOU,legalAdress,fisicalAdress,bankRequsit,bankCode,other1,other2,other3)" +
                " values (N'" + this.txtName.Text + "',N'" + this.txtFullName.Text + "',N'" + this.txtForm.Text +
                "',N'" + this.txtResident.Text + "',N'" + this.txtAnother.Text + "',N'" + this.txtManager.Text +
                "',N'" + this.txtPosition.Text + "',N'" + this.txtManager2.Text + "',N'" + this.txtPosition2.Text +
                "',N'" + this.txtEDRPOU.Text + "',N'" + this.txtLegalAdress.Text + "',N'" + this.txtPhisicalAdress.Text +
                "',N'" + this.txtBankRequisits.Text + "',N'" + this.txtBankCode.Text + "',N'" + this.txtOther1.Text +
                "',N'" + this.txtOther2.Text + "',N'" + this.txtOther3.Text + "') ;";
            SqlConnection conDataBase = new SqlConnection(connectionString);
            SqlCommand cmdDataBase = new SqlCommand(Query, conDataBase);
            SqlDataReader myReader;
            try
            {
                conDataBase.Open();
                myReader = cmdDataBase.ExecuteReader();
                while (myReader.Read())
                {

                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            PopulateCompany();

        } //Save

        private void button_Click(object sender, RoutedEventArgs e)
        {
            txtNumber.Text = "";
            txtName.Text = "";
            txtFullName.Text = ""; 
            txtForm.Text = ""; 
            txtResident.Text = ""; 
            txtAnother.Text = "";  
            txtManager.Text = ""; 
            txtPosition.Text = "";
            txtManager2.Text = "";  
            txtPosition2.Text = ""; 
            txtEDRPOU.Text = ""; 
            txtLegalAdress.Text = "";
            txtPhisicalAdress.Text = ""; 
            txtBankRequisits.Text = ""; 
            txtBankCode.Text = "";  
            txtOther1.Text = ""; 
            txtOther2.Text = "";  
            txtOther3.Text = "";
        } //New

        private void ComboBoxItem_Selected(object sender, RoutedEventArgs e)
        {
            string Query = "delete from tbContractor where Id='" + this.txtNumber.Text + "' ;";
            SqlConnection conDataBase = new SqlConnection(connectionString);
            SqlCommand cmdDataBase = new SqlCommand(Query, conDataBase);
            SqlDataReader myReader;
            try
            {
                conDataBase.Open();
                myReader = cmdDataBase.ExecuteReader();
                while (myReader.Read())
                {

                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            PopulateCompany();
        }  //Delete

        private void button_Copy_Click(object sender, RoutedEventArgs e)
        {
            PopulateCompany();
        }//Refresh

        private void txtSearch_TextChanged(object sender, TextChangedEventArgs e)
        {
            PopulateCompany();
        } //Search

    }
}

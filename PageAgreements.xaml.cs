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
    /// Логика взаимодействия для PageAgreements.xaml
    /// </summary>
    public partial class PageAgreements : Page
    {
        SqlConnection connection;
        string connectionString;
        SqlCommand command;
        string sql = "Select * from tbCompany";

        public PageAgreements()
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
                sql = "Select * from tbCompany";
            }
            else
            {
                sql = "Select * from tbCompany where name like N'%" + this.txtSearch.Text + "%'; "; ;
            }
            command = new SqlCommand(sql, connection);
            SqlDataAdapter adapter = new SqlDataAdapter();
            connection.Open();
            adapter.SelectCommand = command;
            adapter.Fill(dtset, "tbCompany");

            listBox1.DataContext = dtset;

            connection.Close();

        }

   
    }
}

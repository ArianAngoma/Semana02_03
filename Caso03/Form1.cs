using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Data.SqlClient;
using System.Configuration;

namespace Caso03
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["Caso03"].ConnectionString);

        private void Form1_Load(object sender, EventArgs e)
        {
            ListarComboAnios();
        }

        public void ListarComboAnios()
        {
            using (SqlCommand command = new SqlCommand("Usp_anios", cn))
            {
                using (SqlDataAdapter dataAdapter = new SqlDataAdapter())
                {
                    dataAdapter.SelectCommand = command;
                    dataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;
                    DataTable dataTable = new DataTable();
                    dataAdapter.Fill(dataTable);
                    CobAnios.DataSource = dataTable;
                    CobAnios.DisplayMember = "Years";
                    CobAnios.ValueMember = "order_years";
                }
            }
        }

        private void CobAnios_SelectionChangeCommitted(object sender, EventArgs e)
        {
            int codigo;
            codigo = Convert.ToInt32(CobAnios.SelectedValue);
            using (SqlCommand command = new SqlCommand("Usp_mes_02", cn))
            {
                using (SqlDataAdapter dataAdapter = new SqlDataAdapter())
                {
                    dataAdapter.SelectCommand = command;
                    dataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;
                    dataAdapter.SelectCommand.Parameters.AddWithValue("@orderYear", codigo);
                    DataTable dataTable = new DataTable();
                    dataAdapter.Fill(dataTable);
                    CobMes.DataSource = dataTable;
                    CobMes.DisplayMember = "month_name";
                    CobMes.ValueMember = "month_number";
                }
            }
        }

        private void CobMes_SelectionChangeCommitted(object sender, EventArgs e)
        {
            int year, month;
            year = Convert.ToInt32(CobMes.SelectedValue);
            month = Convert.ToInt32(CobMes.SelectedValue);
            using (SqlCommand command = new SqlCommand("Usp_filtrar_anio_mes", cn))
            {
                using (SqlDataAdapter dataAdapter = new SqlDataAdapter())
                {
                    dataAdapter.SelectCommand = command;
                    dataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;
                    dataAdapter.SelectCommand.Parameters.AddWithValue("@orderYear", year);
                    dataAdapter.SelectCommand.Parameters.AddWithValue("@orderMonth", month);
                    DataTable dataTable = new DataTable();
                    dataAdapter.Fill(dataTable);
                    DgDatos.DataSource = dataTable;
                }
            }
        }
    }
}

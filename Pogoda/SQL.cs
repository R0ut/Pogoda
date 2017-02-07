using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace Pogoda
{
    class SQL
    {
        SqlConnection connection;
        string connectionString;
        private ComboBox boxState, boxCity;

        public SQL(ComboBox boxState,ComboBox boxCity)
        {
            this.boxState = boxState;
            this.boxCity = boxCity;
            connectionString = ConfigurationManager.ConnectionStrings["Pogoda.Properties.Settings.dbWeatherConnectionString"].ConnectionString;
        }

        public void State()
        {
            using (connection = new SqlConnection(connectionString)) // dzieki using nie musimy zamknac connection using zrobi to za mnie, tak samo zobi z adapter
            using (SqlDataAdapter adapter = new SqlDataAdapter("Select * from States", connection))
            {
                DataTable stateTable = new DataTable();
                adapter.Fill(stateTable);

                boxState.DisplayMember = "State";
                boxState.ValueMember = "Id";
                boxState.DataSource = stateTable;
                boxState.DataSource = stateTable;
            }
        }


        public void City()
        {

            string query = "Select a.City from Cities a " +
                "Inner join StatesCity b on a.Id = b.CitiesId " +
                "WHERE b.StatesId = @RecipeId";
            
            using (connection = new SqlConnection(connectionString)) 
            using (SqlCommand command = new SqlCommand(query, connection))
            using (SqlDataAdapter adapter = new SqlDataAdapter(command))
            {
                command.Parameters.AddWithValue("@RecipeId", boxState.SelectedValue);


                DataTable cityTable = new DataTable();
                adapter.Fill(cityTable);

                boxCity.DisplayMember = "City";
                boxCity.ValueMember = "Id";
                boxCity.DataSource = cityTable;
            }

        }



    }
}

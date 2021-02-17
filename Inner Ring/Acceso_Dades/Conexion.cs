using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;

namespace Acceso_Dades
{
    public abstract class Conexion
    {
        private string connectionString;
        private protected SqlConnection conexion;
        private protected SqlDataAdapter adaptador;
        string query;
        DataSet dts;

        public Conexion()
        {
            connectionString = ConfigurationManager.ConnectionStrings["SecureCore.Properties.Settings.SecureCoreConnectionString"].ConnectionString;
        }

        private protected void Conectar(string query)
        {
            conexion = new SqlConnection(connectionString);

            try
            {
                if (query != null && query != "")
                {
                    adaptador = new SqlDataAdapter(query, conexion);
                    if (conexion.State == ConnectionState.Closed) conexion.Open();
                }
            }
            catch (SqlException)
            {

            }
        }

        public DataTable PortarTaula(string tabla)
        {
            dts = new DataSet();
            query = "select * from " + tabla;
            Conectar(query);
            adaptador.Fill(dts, tabla);
            conexion.Close();
            return dts.Tables[tabla];
        }

        public void Actualitzar()
        {
            conexion.Open();
            SqlDataAdapter adaptador;
            adaptador = new SqlDataAdapter(query, conexion);
            adaptador.RowUpdated += new SqlRowUpdatedEventHandler(OnRowUpdated);
            SqlCommandBuilder cmdBuilder;
            cmdBuilder = new SqlCommandBuilder(adaptador);
            adaptador.Update(dts.Tables[0]);
            conexion.Close();
        }

        private void OnRowUpdated(object sender, SqlRowUpdatedEventArgs args)
        {
            if (args.Status == UpdateStatus.ErrorsOccurred)
            {
                args.Status = UpdateStatus.SkipCurrentRow;
            }
        }

        public DataSet PortarPerConsulta(string consulta)
        {
            dts = new DataSet();
            Conectar(consulta);
            adaptador.Fill(dts);
            conexion.Close();
            return dts;
        }
        public DataSet PortarPerConsulta(string consulta, string tabla)
        {
            dts = new DataSet();
            Conectar(consulta);
            adaptador.Fill(dts, tabla);
            conexion.Close();
            return dts;
        }

        public int Executa(string consult)
        {
            Conectar(consult);
            SqlCommand cmd = new SqlCommand(consult, conexion);
            int registresAfectats = cmd.ExecuteNonQuery();
            return registresAfectats;
        }

        public void Store()
        {
            conexion.Open();
            SqlCommand cmd = new SqlCommand("Ten Most Expensive Products", conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@Login", "1"));
            //cmd.ExecuteNonQuery();
            conexion.Close();
        }

    }
}

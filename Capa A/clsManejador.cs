using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using CapaA;

namespace CapaAccesoDatos
{
    public class clsManejador
    {
        SqlConnection cnx = new SqlConnection("Server=MALVO; DataBase=FinalP2; Integrated Security= True");

        //Metodo para abrir Conexion

        void abrir_conexion()
        {
            if (cnx.State == ConnectionState.Closed)
            {
                cnx.Open();
            }

        }

        //Metodo para cerrar Conexion
        void Cerrar_Conexion()
        {
            if (cnx.State == ConnectionState.Open)
            {
                cnx.Close();
            }
        }
        //Metodos para ejecutar sp
        public void EjecutarSp(string Nombresp, List<clsParametros> lst)
        {
            SqlCommand miquery;

            try
            {
                abrir_conexion();
                miquery = new SqlCommand(Nombresp, cnx);
                miquery.CommandType = CommandType.StoredProcedure;

                if (lst != null)
                {
                    for (int i = 0; i < lst.Count; i++)
                    {
                        if (lst[i].Direccion == ParameterDirection.Input)
                        {
                            miquery.Parameters.AddWithValue(lst[i].Nombre, lst[i].valor);
                        }

                        if (lst[i].Direccion == ParameterDirection.Output)
                        {
                            miquery.Parameters.Add(lst[i].Nombre, lst[i].TipoDato, lst[i].Tamaño).Direction = ParameterDirection.Output;
                        }
                    }

                    miquery.ExecuteNonQuery();

                    for (int i = 0; i < lst.Count; i++)
                    {
                        if (miquery.Parameters[i].Direction == ParameterDirection.Output)
                        {
                            lst[i].valor = miquery.Parameters.ToString();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

            Cerrar_Conexion();
        }

        //Metodo para ejecutar Consultas
        public DataTable consultas(string Nombresp, List<clsParametros> lst)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da;
            try
            {
                da = new SqlDataAdapter(Nombresp, cnx);
                da.SelectCommand.CommandType = CommandType.StoredProcedure;

                if (lst != null)
                {
                    for (int i = 0; i < lst.Count; i++)
                    {
                        da.SelectCommand.Parameters.AddWithValue(lst[i].Nombre, lst[i].valor);

                    }
                }
                da.Fill(dt);

            }
            catch (Exception ex)
            {
                throw ex;
            }

            return dt;
        }
    }


}

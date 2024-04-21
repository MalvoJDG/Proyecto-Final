using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;


namespace CapaA
{
    public class clsParametros
    {
        //Parametros
        public string Nombre { get; set; }
        public Object valor { get; set; }
        public SqlDbType TipoDato { get; set; }
        public Int32 Tamaño { get; set; }
        public ParameterDirection Direccion { get; set; }


        //Constructores
        //Entrada
        public clsParametros(string objNombre, object objValor)
        {
            Nombre = objNombre;
            valor = objValor;
            Direccion = ParameterDirection.Input;


        }

        //Salida
        public clsParametros(string objNombre, SqlDbType objTipoDato, Int32 objTamaño)
        {
            Nombre = objNombre;
            TipoDato = objTipoDato;
            Tamaño = objTamaño;
            Direccion = ParameterDirection.Output;
        }


    }
}
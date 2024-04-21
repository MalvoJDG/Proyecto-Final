using System;
using System.Collections.Generic;
using System.Data;
using CapaA;
using CapaAccesoDatos;

public class UsuarioC
{
    public int Id { get; set; }
    public string Nombre { get; set; }
    public string Apellido { get; set; }
    public string Correo { get; set; }
    public string Telefono { get; set; }
    public DateTime Fecha_cita { get; set; }
    public string razon_consulta { get; set; }



    clsManejador m = new clsManejador();


    //Listado
    public DataTable ListadoConsultas()
    {
        return m.consultas("UsuarioPapolo", null);
    }

    public DataTable UsuarioCarlos()
    {
        return m.consultas("UsuarioCarlos", null);
    }

    //Guardar
    public string GuardarConsulta()
    {
        String msj = "";
        List<clsParametros> lst = new List<clsParametros>();

        try
        {
            // Configurar parámetros

            lst.Add(new clsParametros("@Nombre", Nombre));
            lst.Add(new clsParametros("@apellido", Apellido));
            lst.Add(new clsParametros("@correo", Correo));
            lst.Add(new clsParametros("@telefono", Telefono));
            lst.Add(new clsParametros("@fecha_cita", Fecha_cita));
            lst.Add(new clsParametros("@razon_consulta", razon_consulta));

            // Ejecutar el procedimiento almacenado


            //Parametros de salida
            lst.Add(new clsParametros("@Mensaje", SqlDbType.VarChar, 100));

            m.EjecutarSp("GuardarUsuarioDC", lst);
            msj = lst[6].valor.ToString();
        }
        catch (Exception ex)
        {
            throw ex;
        }

        return msj;
    }

}

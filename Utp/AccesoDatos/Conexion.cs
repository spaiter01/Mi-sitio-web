using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace AccesoDatos
{
  public   class Conexion
    {
        public  SqlConnection cn = new SqlConnection("Data Source=192.168.1.160;Initial Catalog=Reniec;User ID=sa;Password=sa123");
    
        public string Conex()
        {
            return cn.ConnectionString;
        }
        public void Conectar()
        {
            cn.Open();
        }
        public void Desconectar()
        {
            cn.Close();
        }

      
 
    }
}

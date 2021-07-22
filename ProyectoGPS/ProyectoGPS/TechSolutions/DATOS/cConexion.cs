using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DATOS
{
    public class cConexion
    {
        public SqlConnection Cadena = new SqlConnection("Server=.;Database=TechSolutions;Integrated Security=true");
        
        public SqlConnection AbrirConex()
        {
            if (Cadena.State == ConnectionState.Closed)
                Cadena.Open();
            return Cadena;
        }
        
        public SqlConnection CerrarConex()
        {
            if (Cadena.State == ConnectionState.Open)
                Cadena.Close();
            return Cadena;
        }


    }
}

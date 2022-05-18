using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace maq
{
    public class BD
    { 
        SqlConnection cnn = new SqlConnection(@"Server=localhost\SQLEXPRESS;Initial Catalog=maq;User ID=sa;Password=1234"); 
        public SqlConnection AbrirBD()
        {
            cnn.Open();
            return cnn;
        }
        public SqlConnection CerrarBD()
        {
            cnn.Close();
            return cnn;
        }
    }
}

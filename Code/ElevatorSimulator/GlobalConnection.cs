using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ElevatorSimulator
{
    public static class GlobalConnection
    {
        public static OleDbConnection cn;
        public static void OpenConnection()
        {
            try
            {
                cn = new OleDbConnection
                    ("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Elevator.mdb");
                cn.Open();
            }
            catch(Exception ex){
               MessageBox.Show(ex.Message);
            }
       
        }

    }
    
}

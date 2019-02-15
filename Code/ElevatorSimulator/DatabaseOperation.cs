using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Data;
using System.Data.OleDb;

namespace ElevatorSimulator
{
    class DatabaseOperation
    {
        //inserting sting parameter recieved to database
        public void InsertData(string Action)
        {

            string sql = 
                "insert into [ElevatorLog] ([Date],[Time],[Action]) values (@date, @time, @action)";
            string time = DateTime.Now.ToLongTimeString();
            string date = DateTime.Now.ToShortDateString();
            try
            {
                OleDbCommand cmd = new OleDbCommand(sql, GlobalConnection.cn);

                cmd.Parameters.AddWithValue("@DATE", date);
                cmd.Parameters.AddWithValue("@TIME", time);
                cmd.Parameters.AddWithValue("@ACTION", Action);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        //getting data from database
        public DataTable ViewData()
        {

            string sql = "SELECT TIME,DATE,ACTION  FROM ELEVATORLOG";
            OleDbDataAdapter da = new OleDbDataAdapter(sql, GlobalConnection.cn);
            DataSet ds = new DataSet();
            da.Fill(ds, "Data");
            return ds.Tables[0];
        }
        //loading data to datagrid
        public void LoadData(DataGridView Log)
        {
            try
            {

                DataTable dt = ViewData();
                Log.DataSource = dt;
                Log.FirstDisplayedScrollingRowIndex = Log.RowCount - 1;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }


        }

    }
}

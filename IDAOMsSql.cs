using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace SystemRFID
{
    interface IDAOMsSql
    {
        bool LoadTableToDataGrid(SqlConnection conn,DataGridView grid);
        int ReadColumnsCount(SqlConnection conn);
        void ChangeStatus(SqlConnection conn, String EPC, String status);
        void ReadStatus(SqlConnection conn, String EPC);
        void AddToDataBase(SqlConnection conn, String EPC);
    }
}

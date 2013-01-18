using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CommonLib.Interfaces;
using System.Data.OleDb;
using System.Data;

namespace CommonLib.Models
{
    public class Model : IModel
    {

        #region IModel implementation

        public DataSet GetJobData(string fileName)
        {
            string connectionString = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=D:\CSVFILES;
                                        Extended Properties='text;HDR=Yes'";
            string commandText = String.Format("SELECT * FROM {0}", fileName);
            using (OleDbConnection conn = new OleDbConnection(connectionString))
            {
                using (OleDbCommand cmd = new OleDbCommand(commandText,conn))
                {
                    conn.Open();
                    OleDbDataAdapter da = new OleDbDataAdapter(commandText, conn);
                    DataSet jobData = new DataSet();
                    da.Fill(jobData);
                    return jobData;
                }
            }
        }

        #endregion
    }
}

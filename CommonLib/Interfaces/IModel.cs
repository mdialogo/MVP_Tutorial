using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace CommonLib.Interfaces
{
    public interface IModel
    {
        DataSet GetJobData(string fileName);
    }
}

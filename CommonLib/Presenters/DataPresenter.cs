using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CommonLib.Interfaces;

namespace CommonLib.Presenters
{
    public class DataPresenter : Presenter<IMainView>
    {
        public DataPresenter(IMainView view) : base(view)
        { 
        }

        public void Display(string fileName)
        {
            if (View != null)
            {
                View.CSVData = Model.GetJobData(fileName);
            }
        }
    }
}

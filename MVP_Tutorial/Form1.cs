using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using CommonLib.Interfaces;
using CommonLib.Presenters;

namespace MVP_Tutorial
{
    public partial class Form1 : Form, IMainView
    {
        private DataPresenter _presenter;

        public Form1()
        {
            InitializeComponent();

            _presenter = new DataPresenter(this);
            _presenter.Display("test.csv");
        }

        #region IMainView implementation
        
        public DataSet CSVData
        {
            set { dataGridView1.DataSource = value.Tables[0]; }
        }

        #endregion
    }
}

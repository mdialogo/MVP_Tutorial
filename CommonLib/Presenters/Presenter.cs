using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CommonLib.Interfaces;
using CommonLib.Models;

namespace CommonLib.Presenters
{
    public class Presenter<T> where T : IBaseInterface
    {
        protected static IModel Model { get; private set; }
        public T View { get; private set; }

        static Presenter()
        {
            Model = new Model();
        }

        public Presenter(T view)
        {
            View = view;
        }
    }
}

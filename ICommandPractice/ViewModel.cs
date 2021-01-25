using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace ICommandPractice
{
    class ViewModel
    {

        public ICommand cmd { get; set; }


        public ViewModel()
        {
            cmd = new MyCommand(CaniExecute, Execute);

        }



        public bool CaniExecute(object o)
        {
            return true;
        }

        public void Execute(object o)
        {
            MessageBox.Show("HI ALL I AM HERE ");
        }




    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace ICommandPractice
{
    class MyCommand : ICommand
    {
        Func<object,bool> canExe;
        Action<object> exe;


        public MyCommand(Func<object,bool> ce, Action<object> ex)
        {
            canExe = ce;
            exe = ex;

        }



        public event EventHandler CanExecuteChanged;

        public bool CanExecute(object parameter)
        {
            //throw new NotImplementedException();
            return true;
        }

        public void Execute(object parameter)
        {
            //throw new NotImplementedException();
            exe(parameter);
        }
    }
}

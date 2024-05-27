using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture11
{
    internal class Data
    {
        //Fields
        public static ObservableCollection<String> names = new ObservableCollection<string>();

        //Constructors
        static Data()
        {
            names.Add("Leo");
            names.Add("Joshua");
            names.Add("Jeremy");
            names.Add("Tommy");
            names.Add("Carl");
        }
        
        //Properties

        
        //Methods
    }
}

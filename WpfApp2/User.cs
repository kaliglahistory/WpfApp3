using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Text.Json;
using System.Diagnostics.Eventing.Reader;
using System.Text.Json.Serialization;

namespace WpfApp2
{
    

    
    public class User : MainWindow
    {


        public string login { get; set; }
        public int password { get; set; }
        public User (string Login, int Password)
        {
            login = Login; 
            password = Password;
        }
         
        
    }
   
}


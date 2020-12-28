using System;
using System.Collections.Generic;
using System.Text;

namespace _14Class_exercise03_PracticesAndPrinciples.Naming
{
   
    public interface IVehicle
    {
        //.code
    }
    class NamingBestPractices : IVehicle
    {
        
        //Bad practices examples
        private readonly string userpath = @"/whatever";
        public int id { get; set; }
        public string name { get; set; }
        public void  printUser()
        {
            //something
        }

        //Good practices examples
        private readonly string _userPath = @"/whatever";
        public int Id { get; set; }
        public string Name { get; set; }

        public void  PrintUser()
        {
            //something
        }


    }
}

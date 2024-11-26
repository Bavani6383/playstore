using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace playstore
{
    public class User:IUser
    {

        //properties
        public int a; //variable
        public int id {  get; set; }
        public string Name { get; set; } = "Bavani";
        public string email { get; set; }

        public string password { get; set; }
        public int Mobile { get; set; }
        private int UserKey { get; set; } = 123;

        public void AddUser()
        {
        }

        //Functions
        //Syntax: public return/no-return-type MethodName(){}

        public void CreateUser()
        {
            Console.WriteLine("User Key:" + UserKey);
            Console.WriteLine("User Registration");
            //How to read input from Keyboard
            Console.Write("Enter name: ");
            Name = Console.ReadLine();//read input    
            Console.Write("Enter mobile");
            Mobile=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Welcome," + Name);
        }

         void Deleteuser()
       void GetUser()
       void Updateuser()
        
            Public abstract class 

    }
}

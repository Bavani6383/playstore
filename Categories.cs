using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace playstore
{

    public class Categories
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        
        //constructor
        //class name and method name should be same
        //it will trigger automattically when object created

        public Categories()
        {

        }
        public Categories(int id,string name, string description)
        {
            Id = id;
            Name = name;
            Description = description;
        }

        public void AddCategory(int id,string name)
        {
            Console.WriteLine("Category details: " + id + "," + name);
        }
        public void AddCategory(int id, string name,string description)
        {
            Console.WriteLine("Category detail:" + id + "," + name + ","+description);
        }

    }

}

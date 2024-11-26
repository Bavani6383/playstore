using playstore;

Console.WriteLine("My Play Store");

//How to create object for class?
User userObj = new User();
Console.WriteLine("My Name: " + userObj.Name);
userObj.CreateUser(); //function Calling

Categories categories = new Categories(11, "Fashion", "Fashion test");

Console.WriteLine(categories.Id);
Console.WriteLine(categories.Name);
Console.WriteLine(categories.Description);

categories.AddCategory(1, "ABC");
categories.AddCategory(2, "XYZ", "Test");
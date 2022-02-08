using System;
using System.Reflection;

namespace Reflexe
{
    public class Program
    {
        static void Main(string[] args)
        {
            var assembly = Assembly.GetExecutingAssembly();
            var types = assembly.GetTypes();
            foreach (var item in types)
            {
                if(item.Name=="Cookie")
                {
                    Console.WriteLine("Class: " + item.Name);
                    var props = item.GetProperties();
                    Console.WriteLine();
                    foreach (var prop in props)
                    {
                        Console.WriteLine("\tProperty: " + prop.Name);
                        Console.WriteLine("\t\tPropertyType: " + prop.PropertyType);
                    }
                    Console.WriteLine();
                    var methods = item.GetMethods();
                    foreach (var method in methods)
                    {
                        if(method.IsVirtual==true)
                        {
                            Console.WriteLine("\t\t\t\tMethod: " + method.Name);
                        }
                    }
                    Console.WriteLine();
                    var constructors = item.GetConstructors();
                    foreach (var constructor in constructors)
                    {
                            Console.WriteLine("\t\t\t\t\tConstructor: " + constructor.Name);
                        var itms = constructor.GetParameters();
                        foreach (var itm in itms)
                        {
                            Console.WriteLine("\t\t\t\t\t\tParameter: " + itm.Name);
                        }
                    }    
                }
            }
        }
    }
    public class Cookie
    {
        public Cookie()
        {

        }
        public Cookie(string name, string? value)
        {

        }
        public Cookie(string name, string? value, string? path)
        {

        }
        public Cookie(string name, string? value, string? path, string? domain)
        {

        }

        public DateTime TimeStamp { get; }
        public bool Secure { get; set; }
        public string Port { get; set; }
        public string Path { get; set; }
        public string Name { get; set; }
        public bool HttpOnly { get; set; }
        public DateTime Expires { get; set; }
        public string Domain { get; set; }
        public string Value { get; set; }
        public bool Discard { get; set; }
        public Uri? CommentUri { get; set; }
        public string Comment { get; set; }
        public bool Expired { get; set; }
        public int Version { get; set; }

        public bool Equals(object? comparand) 
        { 
            return Equals(comparand, null);
        }
        public int GetHashCode() 
        {
            return 5; 
        }
        public string ToString()
        {
            return "string";
        }
    }
}

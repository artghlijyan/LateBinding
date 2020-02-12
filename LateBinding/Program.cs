using System;
using System.IO;
using System.Reflection;

namespace LoadAssambly
{
    class Program
    {
        static void Main(string[] args)
        {
            Assembly assembly = null;

            try
            {
                assembly = Assembly.LoadFrom(@"C:\Users\decku\Desktop\Code\LateBinding\CarLibrary\bin\Debug\CarLibrary.dll");
                Console.WriteLine("Class Library Loaded");
            }
            catch (FileNotFoundException ex)
            {
                Console.WriteLine(ex.Message);
            }

            ListAllTypes(assembly);

            ListAllMembers(assembly);

            GetParams(assembly);

            Console.ReadKey();
        }

        private static void ListAllTypes(Assembly assembly)
        {
            Console.WriteLine(new string('_', 60));
            Console.WriteLine("\n Types in: {0} \n", assembly.FullName);

            Type[] types = assembly.GetTypes();

            foreach (Type t in types)
            {
                Console.WriteLine("Type: {0}", t);
            }
        }

        private static void ListAllMembers(Assembly assembly)
        {
            Console.WriteLine(new string('_', 60));

            Type type = assembly.GetType("CarLibrary.RegularCar");

            Console.WriteLine("\n Class members: {0} \n", type);

            MemberInfo[] members = type.GetMembers();

            foreach (MemberInfo mi in members)
            {
                Console.WriteLine("{0}: {1}", mi.MemberType, mi);
            }
        }

        private static void GetParams(Assembly assembly)
        {
            Console.WriteLine(new string('_', 60));

            Type type = assembly.GetType("CarLibrary.SportCar");

            MethodInfo method = type.GetMethod("Driver");

            Console.WriteLine("\n Information about method parameters: {0} \n", method.Name);

            ParameterInfo[] parameters = method.GetParameters();

            Console.WriteLine("Method has {0} parameters", parameters.Length);

            foreach (ParameterInfo pi in parameters)
            {
                Console.WriteLine("Parameter Name: {0}", pi.Name);
                Console.WriteLine("Parameter Position: {0}", pi.Position);
                Console.WriteLine("Parameter Type: {0}", pi.ParameterType);
            }
        }
    }
}

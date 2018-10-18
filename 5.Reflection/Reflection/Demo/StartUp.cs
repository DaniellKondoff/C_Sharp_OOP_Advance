using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    class StartUp
    {
        static void Main(string[] args)
        {

            Console.WriteLine(typeof(int));
            //Type listYpe = typeof(List<>);
            //Console.WriteLine(listYpe.Name);
            //Console.WriteLine(listYpe.FullName);
            //Console.WriteLine(listYpe.Namespace);

            //Assembly currentAssembly = Assembly.GetExecutingAssembly();
            //Type[] allTypes = currentAssembly.GetTypes();

            //foreach (var type in allTypes)
            //{
            //    Console.WriteLine(type.Name);
            //    Type[] interfaces = type.GetInterfaces();
            //    foreach (var interfacee in interfaces)
            //    {
            //        Console.WriteLine(interfacee.FullName);
            //    }
            //}

            //Creating Instace

            Type simpleClassType = typeof(SimpleClass);
            SimpleClass scInstance = (SimpleClass)Activator.CreateInstance(simpleClassType, "ThisText"); // Like Params
            //scInstance.Name = "Text";
            //Console.WriteLine(scInstance.Name);

            //Fields
            //FieldInfo fieldInt = simpleClassType.GetField("simpleInt",BindingFlags.Instance | BindingFlags.NonPublic);
            FieldInfo[] fields = simpleClassType.GetFields(BindingFlags.Instance | BindingFlags.NonPublic | BindingFlags.Public);

            //foreach (FieldInfo field in fields)
            //{
            //    if (field.IsPrivate)
            //    {
            //        Console.WriteLine(field.Name);
            //        Console.WriteLine(field.FieldType);
            //        Console.WriteLine(field.Attributes);
            //    }
            //}

            //foreach (FieldInfo field in fields)
            //{
            //    if (field.Name == "name")
            //    {
            //        field.SetValue(scInstance, "teststr");
            //    }
            //    Console.WriteLine(field.GetValue(scInstance));
            //}

            //Constructors
            Type[] ctorParamsTypes = { typeof(string) };
            ConstructorInfo ctorStr = simpleClassType.GetConstructor(new Type[] { typeof(string) });
            ConstructorInfo[] ctors = simpleClassType.GetConstructors();
            SimpleClass scSecondInstance = (SimpleClass)ctorStr.Invoke(new object[] { "SecondText" });

            Console.WriteLine(scSecondInstance.Name);

            //foreach (ConstructorInfo ctor in ctors)
            //{
            //    ParameterInfo[] ctorParams = ctor.GetParameters();
            //    if (ctorParams.Length == 1)
            //    {
            //        ParameterInfo param = ctorParams.First();
            //    }
            //}

            //Methods
            MethodInfo[] allmethots = simpleClassType.GetMethods(BindingFlags.Instance | BindingFlags.NonPublic);

            foreach (var method in allmethots)
            {
                Console.WriteLine(method.Name);
            }
            

        }
    }
}

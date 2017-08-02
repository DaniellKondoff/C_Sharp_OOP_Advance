using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;


public class Spy
{
    public string StealFieldInfo(string investigatedClass, params string[] strArr)
    {
        Type classType = Type.GetType(investigatedClass);
        FieldInfo[] classFielss = classType.GetFields(BindingFlags.Instance | BindingFlags.NonPublic | BindingFlags.Static | BindingFlags.Public);
        StringBuilder stringBuilder = new StringBuilder();

        Object classIntance = Activator.CreateInstance(classType, new object[] { });

        stringBuilder.AppendLine($"Class under investigation: {investigatedClass}");

        foreach (FieldInfo field in classFielss.Where(f => strArr.Contains(f.Name)))
        {
            stringBuilder.AppendLine($"{field.Name} = {field.GetValue(classIntance)}");
        }
        return stringBuilder.ToString().Trim();
    }

    public string AnalyzeAcessModifiers(string investigatedClass)
    {
        Type classType = Type.GetType(investigatedClass);
        FieldInfo[] classFields = classType.GetFields(BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public);
        MethodInfo[] classPublishMethods = classType.GetMethods(BindingFlags.Instance | BindingFlags.Public);
        MethodInfo[] classNonPublishMethods = classType.GetMethods(BindingFlags.Instance | BindingFlags.NonPublic);

        StringBuilder stringBuilder = new StringBuilder();

        foreach (FieldInfo field in classFields)
        {
            stringBuilder.AppendLine($"{field.Name} must be private!");
        }
        foreach (MethodInfo method in classNonPublishMethods.Where(m=>m.Name.StartsWith("get")))
        {
            stringBuilder.AppendLine($"{method.Name} have to be public!");
        }
        foreach (MethodInfo method in classPublishMethods.Where(m => m.Name.StartsWith("set")))
        {
            stringBuilder.AppendLine($"{method.Name} have to be private!");
        }
        return stringBuilder.ToString().Trim();
    }

    public string RevealPrivateMethods(string investigatedClass)
    {
        Type classType = Type.GetType(investigatedClass);
        MethodInfo[] classMethods = classType.GetMethods(BindingFlags.Instance | BindingFlags.NonPublic);
        StringBuilder stringBuilder = new StringBuilder();

        stringBuilder.AppendLine($"All Private Methods of Class: {investigatedClass}");
        stringBuilder.AppendLine($"Base Class: {classType.BaseType.Name}");

        foreach (MethodInfo method in classMethods)
        {
            stringBuilder.AppendLine(method.Name);
        }

        return stringBuilder.ToString().Trim();
    }

    public string CollectGettersAndSetters(string investigatedClass)
    {
        Type classType = Type.GetType(investigatedClass);
        MethodInfo[] classMethods = classType.GetMethods(BindingFlags.Instance | BindingFlags.NonPublic | BindingFlags.Public);
        StringBuilder stringBuilder = new StringBuilder();

        foreach (MethodInfo method in classMethods.Where(m => m.Name.StartsWith("get")))
        {
            stringBuilder.AppendLine($"{method.Name} will return {method.ReturnType}");
        }

        foreach (MethodInfo method in classMethods.Where(m => m.Name.StartsWith("set")))
        {
            stringBuilder.AppendLine($"{method.Name} will set field of {method.GetParameters().First().ParameterType}");
        }

        return stringBuilder.ToString().Trim();
    }
}


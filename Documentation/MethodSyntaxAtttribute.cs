using System;

namespace Documentation
{
  [AttributeUsage(AttributeTargets.Method,AllowMultiple=false,Inherited=true)]
  public class MethodSyntaxAtttribute : Attribute
  {
    protected virtual bool IsExtensionMethod { get => false; }
    public MethodSyntaxAtttribute(string methodName, Type returnType, params Type[] Parameters)
    {
      MethodName = methodName;
      ReturnType = returnType;
      ParameterTypes = Parameters;
    }
    public string MethodName { get; }
    public Type ReturnType { get; }
    public Type[] ParameterTypes { get; }
    protected virtual string GenerateTypeInfo()
    {
      return ParameterTypes.Pull((t) => t.ToString()).GetSum(",\n");
    }
    public  void Display()
    {
      for(int i = 0; i < Console.BufferWidth; i++)
      {
        Console.Write("=");
      }
      Console.WriteLine("");
      Console.WriteLine($"{(IsExtensionMethod ? "ExtensionMethod: " : "Method: ")} {MethodName}");
      Console.WriteLine($"Return Type: {ReturnType}");
      Console.WriteLine($"Parameters: {GenerateTypeInfo()}");
    }
  }
}
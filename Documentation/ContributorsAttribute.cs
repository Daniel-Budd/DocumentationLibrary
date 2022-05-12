using System;

namespace Documentation
{
    [AttributeUsage(AttributeTargets.All,AllowMultiple=false,Inherited=false)]
    public sealed class ContributorsAttribute : Attribute
    {
        public string[] Contributors { get; }
        public ContributorsAttribute(params string[] contributors)
        {
          Contributors = contributors;
        }
        public void Display()
        {
          Console.WriteLine(Contributors.GetSumWithLines("\n","\n\n"));
        }
    }
}
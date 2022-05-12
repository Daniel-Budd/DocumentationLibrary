using System;

namespace Documentation
{
    [AttributeUsage(AttributeTargets.All, AllowMultiple=true, Inherited=false)]
    public class PatchNotesAttribute : Attribute
    {
        public string Date { get; }
        public string Version { get; }
        public string Notes { get; }
        public PatchNotesAttribute(string date, string version, string notes)
        {
          Date = date;
          Version = version;
          Notes = notes;
        }
        public void Display()
        {
          Console.WriteLine($"Date: {Date}");
          Console.WriteLine($"Version: {Version}");
          Console.WriteLine($"Notes:\n {Notes.SumLines()}");
        }
    }
}
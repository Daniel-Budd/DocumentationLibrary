using System;

namespace Documentation
{
/**
<summary>Provides a version name for the element.</summary>
*/
    [AttributeUsage(AttributeTargets.All, AllowMultiple=false, Inherited=false)]
    public class VersionAttribute : Attribute
    {
        public string VersionName { get;}
        public VersionAttribute(string versionName)
        {
          VersionName = versionName;
        }
    }
}
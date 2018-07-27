using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorTest.App.Services
{
    [AttributeUsage(AttributeTargets.All)]
    public sealed class NameAttribute : Attribute
    {
        private readonly string _name;

        public string Name
        {
            get { return _name; }
        }

        public NameAttribute(string name)
        {
            _name = name;
        }
    }
}

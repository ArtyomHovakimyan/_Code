using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace Mic.Volo.CodeRepeat
{
    public class class1
    {
        public virtual string DoSomething()
        {
            return "class1";
        }
    }

    public class class2 : class1
    {
        public override string DoSomething()
        {
            return "class2";
        }
    }

    public class class3 : class2
    {
        public new string DoSomething()
        {
            return "Class3";
        }
    }

    class Base
    {
        public virtual string GetName() => "BaseName";
    }
    class Child:Base
    {
        public override string GetName()
        {
            return "ChildName";
        }
    }
    class Other:Child
    {
        public override string GetName()
        {
            return "Other Name";
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            //class1 a = new class3();
            //Console.WriteLine(a.DoSomething());

            Base @base = new Other();
            Console.WriteLine(@base.GetName());
        }
    }
}

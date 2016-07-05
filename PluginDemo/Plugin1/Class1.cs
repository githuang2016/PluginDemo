using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Reflection.Com.Demo;

namespace Plugin1
{
    public class Class1 : IPlugin
    {
        public void Excute()
        {
            Console.WriteLine("插件1已经安装成功");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Reflection.Com.Demo;

namespace Plugin2
{
    public class Class2 : IPlugin 
    {
        public void Excute()
        {
            Console.WriteLine("插件2已经安装成功");
        }
    }
}

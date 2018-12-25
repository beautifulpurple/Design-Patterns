using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
    /// <summary>
    /// C#中经典的单例模式使用方式
    /// </summary>
    class DemoOne
    {
        public static readonly DemoOne Instance = new DemoOne();

        private DemoOne()
        {
        }
    }
    /// <summary>
    ///上面的代码  相当于下面这种
    /// </summary>
    class DemoOneExt
    {
        public static readonly DemoOneExt Instance;

        static DemoOneExt()
        {
            Instance = new DemoOneExt();
        }

        private DemoOneExt()
        {
        }
    }
}

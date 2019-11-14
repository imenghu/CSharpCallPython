using IronPython.Hosting;
using Microsoft.Scripting.Hosting;
using System;

namespace CSharpCallPython
{
    class Program
    {
        static void Main(string[] args)
        {
            ScriptEngine pyEngine = Python.CreateEngine();//创建Python解释器对象
            dynamic py = pyEngine.ExecuteFile(@"test.py");//读取脚本文件
            int[] array = new int[9] { 9, 3, 5, 7, 2, 1, 3, 6, 8 };
            string reStr = py.main(array);//调用脚本文件中对应的函数
            Console.WriteLine(reStr);

            Console.ReadKey();
        }
    }
}
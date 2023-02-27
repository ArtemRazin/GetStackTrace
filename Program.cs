[assembly: ArmDot.Client.ObfuscateNames()]

[assembly: ArmDot.Client.VirtualizeCode()]

[assembly: ArmDot.Client.ObfuscateControlFlow()]

namespace GetStackTrace;
class Program
{
    static void Main(string[] args)
    {
        function1();
    }

    static void function1()
    {
        function2();
    }

    static void function2()
    {
        throw new Exception("hi");
    }
}

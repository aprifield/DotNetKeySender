using System;
using System.Windows.Forms;

namespace DotNetKeySender
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length == 0)
            {
                Console.Error.WriteLine(
                    "Usage: DotNetKeySender keys\n" +
                    "Paste: DotNetKeySender \"^v\"\n" +
                    "SendKeys.Send online help: https://docs.microsoft.com/dotnet/api/system.windows.forms.sendkeys.send");
                Environment.Exit(1);
            }

            SendKeys.SendWait(args[0]);
        }
    }
}

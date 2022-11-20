using CommandPattern.Core.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;

namespace CommandPattern
{
    public class CommandInterpreter : ICommandInterpreter
    {
        public string Read(string args)
        {
            string[] cmdArg = args.Split(' ');
            string cmdName = cmdArg[0];
            string[] invokeArgs = cmdArg.Skip(1).ToArray();
            Assembly assembly = Assembly.GetEntryAssembly();
            Type CmdType = assembly.GetTypes().FirstOrDefault(t =>t.Name==$"{cmdName}Command");
            MethodInfo methodInfo = CmdType.GetMethods(BindingFlags.Instance | BindingFlags.Public)
            .FirstOrDefault(m => m.Name == "Execute");
            object CmdInstance = Activator.CreateInstance(CmdType);
            string result = (string)methodInfo.Invoke(CmdInstance, new object[] { invokeArgs });
            return result;
        }
    }
}

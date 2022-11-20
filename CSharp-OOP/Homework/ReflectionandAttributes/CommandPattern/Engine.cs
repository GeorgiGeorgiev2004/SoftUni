using CommandPattern.Core.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace CommandPattern
{
    public class Engine : IEngine
    {
        private readonly ICommandInterpreter cmdInterpreter;
        public Engine(ICommandInterpreter cmdInterpreter)
        {
            this.cmdInterpreter = cmdInterpreter;
        }
        public void Run()
        {
            while (true)
            {
                string input = Console.ReadLine();
                string result = this.cmdInterpreter.Read(input);
                Console.WriteLine(result);
            }
        }
    }
}

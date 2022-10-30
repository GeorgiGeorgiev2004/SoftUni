using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace ComputerArchitecture
{
    public class Computer
    {
        public Computer(string model, int capacity)
        {
            Model = model;
            Capacity = capacity;
            Multiprocessor = new List<CPU>();
        }

        public  string Model { get; set; }

        public int Capacity { get; set; }

        public List<CPU> Multiprocessor  { get; set; }

        public int Count => Multiprocessor.Count; 
        public void Add(CPU cpu) 
        {
            if (Multiprocessor.Count<Capacity)
            {
                Multiprocessor.Add(cpu);
            }
        }
        public bool Remove(string brand)
        {
            for (int i = 0; i < Multiprocessor.Count; i++)
            {
                if (Multiprocessor[i].Brand ==brand)
                {
                    Multiprocessor.RemoveAt(i);
                    return true;
                }
            }
            return false;
        }
        public CPU MostPowerful() 
        {
            CPU bestCPU = new CPU("",1,0);
            for (int i = 0; i < Multiprocessor.Count; i++)
            {
                if (Multiprocessor[i].Frequency>bestCPU.Frequency)
                {
                    bestCPU = Multiprocessor[i];
                }
            }
            return bestCPU;
        }
        public CPU GetCPU(string brand) 
        {
            CPU match = null;
            for (int i = 0; i < Multiprocessor.Count; i++)
            {
                if (Multiprocessor[i].Brand == brand)
                {
                    match= Multiprocessor[i];
                }
            }
            return match;
        }
        public string Report() 
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"CPUs in the Computer {Model}");
            for (int i = 0; i < Multiprocessor.Count; i++)
            {
                sb.AppendLine(Multiprocessor[i].ToString());
            }
            return sb.ToString().TrimEnd();
        }
    }
}
using System;
using System.Collections.Specialized;

namespace OOP_Ex02_Constructors
{
    class Doctor //Classe
    {
        public string Name;
        public string Specialty;

        public Doctor(string name, string specialty) //Constructor
        {
            Name = name;
            Specialty = specialty;
        }

        public void Introduce()
        {
            Console.WriteLine($"\nOlá, sou o/a  Dr/a. {Name}, especialista em {Specialty}.\n");
        }
    }
}

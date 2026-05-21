using System;

namespace OOP_Ex01_ClassesAndMembers
{
    class Patient
    {
        public string name;
        public int age;

        public void ShowInfo()
        {
            Console.WriteLine($"\nPaciente: {name} | Idade: {age} anos.\n");
        }
    }
}

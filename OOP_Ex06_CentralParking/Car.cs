using System;

namespace OOP_Ex06_CentralParking
{
    class Car
    {
        private string licensePlate;
        private string carBrand;

        public Car(string licensePlate, string carBrand)
        {
            this.licensePlate = licensePlate;
            this.carBrand = carBrand;
        }

        public string GetPlate()
        {
            return licensePlate; //Criado para ler e devolver a variavel privada
        }
    }
}

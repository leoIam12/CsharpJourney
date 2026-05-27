using System;

namespace OOP_Ex07_TechFix
{
    class Equipment
    {
        private string nameCustomer;
        private string nameEquipment;

        public Equipment(string nameCustomer, string nameEquipment)
        {
            this.nameCustomer = nameCustomer;
            this.nameEquipment = nameEquipment;
        }

        public string GetNameCustomer()
        {
            return nameCustomer;
        }

        public string GetNameEquipment()
        {
            return nameEquipment;
        }
    }
}

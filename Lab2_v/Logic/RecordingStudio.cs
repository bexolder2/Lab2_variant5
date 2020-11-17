using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    class RecordingStudio : ICloneable
    {
        public int NumberOfEmployee { get; set; }
        public string Adress { get; set; }
        public double PricePerTrack { get; set; }
        private int RecordTimeMinutes { get; set; }
        private double Salary { get; set; }
        private double SumSalary { get; set; }
        public double CashRegister { get; set; }
        public int NumberOfInstruments { get; set; }
        public int NumberOfRooms { get; set; }

        public RecordingStudio()
        {
            Adress = "Ivanovo street, 228/1488";
            PricePerTrack = 22.8;
            Salary = 500.0;
            CashRegister = 150;
        }

        public void AddRoom()
        {
            NumberOfInstruments += 2;
            NumberOfEmployee += 2;
            NumberOfRooms++;
            SumSalary = CountSumSalary();
        }

        public void DeleteRoom()
        {
            NumberOfInstruments -= 2;
            NumberOfEmployee -= 2;
            NumberOfRooms--;
            SumSalary = CountSumSalary();
        }

        public void AddEmployee(int number = 1)
        {
            NumberOfEmployee += number;
            SumSalary = CountSumSalary();
        }

        public void DeleteEmployee(int number = 1)
        {
            NumberOfEmployee -= number;
            SumSalary = CountSumSalary();
        }

        public object Clone()
        {
            RecordingStudio clone = new RecordingStudio();
            clone = this;
            return clone;
        }

        public static RecordingStudio operator ++(RecordingStudio obj)
        {
            obj.NumberOfInstruments += 2;
            obj.NumberOfRooms++;
            obj.CashRegister -= 10;
            return obj;
        }

        public static RecordingStudio operator -(RecordingStudio obj)
        {
            obj.NumberOfRooms--;
            return obj;
        }

        private double CountSumSalary()
        {
            return Salary * NumberOfEmployee;
        }

        public double this[int index]
        {
            get
            {
                if(index == 1)
                {
                    return Salary;
                }
                else if(index == 2)
                {
                    return SumSalary;
                }
                else if(index == 3)
                {
                    return CashRegister;
                }
                return 0;
            }
            set
            {
                Salary = value;
                SumSalary = value;
                CashRegister = value;
            }
        }
    }
}

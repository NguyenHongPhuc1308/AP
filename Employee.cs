using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
 
namespace As2
{
    public class Employee
    {
        public string id, name, position;
        public int baseSalary;

        public Employee()
        {
            id = "Null";
            name = "No Name";
            position = "Null";
            baseSalary = 0;
        }

        public Employee(string id, string name, string position, int baseSalary)
        {
            this.id = id;
            this.name = name;
            this.position = position;
            this.baseSalary = baseSalary;
        }

        public void input()
        {
            Console.Write("Nhap id: "); id = Console.ReadLine().Trim();
            Console.Write("Nhap ten: "); name = Console.ReadLine().Trim();
            Console.Write("Nhap chuc vu: "); position = Console.ReadLine().Trim();

            while (true)
            {
                try
                {
                    Console.Write("Nhap luong (100-2000):");
                    baseSalary = int.Parse(Console.ReadLine().Trim());
                    if (baseSalary >= 100 && baseSalary <= 2000) break;
                }
                catch (Exception e)
                {
                    Console.WriteLine("Loi " + e.Message);
                }
            }
        }

        public void print()
        {
            Console.WriteLine("*Danh sach nhan vien*");
            Console.WriteLine($"-Id: {id}");
            Console.WriteLine($"-Ten nhan vien: {name}");
            Console.WriteLine($"-Chuc vu: {position}");
            Console.WriteLine($"-Luong : {baseSalary}");
        }
    }
}

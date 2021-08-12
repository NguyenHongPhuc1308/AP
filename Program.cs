using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace As2
{
    class Program
    {
        static void Main(string[] args)
        {
            Program p = new Program();

            string op = "";
            while (true)
            {
                Console.WriteLine("\n === MENU ===");
                Console.WriteLine("1. Them nhan vien");
                Console.WriteLine("2. In danh sach nhan vien");
                Console.WriteLine("3. In danh sach nhan vien theo ten");
                Console.WriteLine("4. In danh sach nhan vien theo luong");
                Console.WriteLine("5. Ket thuc ");
                Console.Write(" >> nhap ma so chuc nang [1-5]: ");

                op = Console.ReadLine().Trim();
                switch (op)
                {
                    case "1":
                        p.add(); break;
                    case "2":
                        p.display(); break;
                    case "3":
                        
                        p.display(); break;
                    case "4":
                        int m = 0;
                        while (true)
                        {
                            try
                            {
                                Console.Write("--> Nhap luong can tim : ");
                                m = int.Parse(Console.ReadLine().Trim());
                                if (m >= 0) break;
                            }
                            catch (Exception e)
                            {
                                Console.WriteLine("Loi : " + e.Message);
                            }
                        }
                        p.display(m);

                        break;

                    case "5":
                        return;
                    default:
                        break;
                }


            }
        }


        List<Employee> ds = new List<Employee>();

        public void add()
        {
            Employee emp = new Employee();
            emp.input();
            ds.Add(emp);
            Console.WriteLine("Da them nhan vien thanh cong !");
        }

        public void display()
        {
            if (ds.Count == 0)
            {
                Console.WriteLine("He thong chua co du lieu !!!");
                return;
            }

            Console.WriteLine("\n\t>>Danh sach nhan vien<<");
            foreach(var nv in ds)
            {
                Console.WriteLine(nv);
            }
        }


        public void display(string sName)
        {
            if (ds.Count == 0)
            {
                Console.WriteLine("He thong chua co du lieu !!!");
                return;
            }

            Console.WriteLine("\n>>Danh sach nhan vien co ten "+ (sName));
            int cntName = 0;

            foreach (var item in ds.FindAll(nv => nv.name == sName))
            {
                Console.WriteLine(item);
                cntName++;
            }

            if (cntName == 0)
            {
                Console.WriteLine("\nKhong tim thay ten "+ (sName) + "!!!");
            }
        }

        public void display(int luong)
        {
            if (ds.Count == 0)
            {
                Console.WriteLine("He thong chua co du lieu !!!");
                return;
            }

            Console.WriteLine("\n>>Danh sach nhan vien co luong : " + (luong));
            int cntLuong = 0;

            foreach (var item in ds.FindAll(l => l.baseSalary == luong))
            {
                Console.WriteLine(item);
                cntLuong++;
            }

            if (cntLuong == 0)
            {
                Console.WriteLine("\nKhong tim thay nhan vien co muc luong la : " + (luong) + "!!!");
            }
        }



    }
}

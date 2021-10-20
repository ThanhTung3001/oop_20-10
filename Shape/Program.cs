using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymophism_demo2
{
    public abstract class Hinh
    {
        protected int x1;//tọa độ x của điểm góc trên bên trái
        protected int y1;//tọa độ y của điểm góc trên bên trái
        protected int x2;//tọa độ x của điểm góc dưới bên phải
        protected int y2;//tọa độ y của điểm góc dưới bên phải

         public Hinh (int x1,int y1 ,int x2,int y2)
        {
             this.x1 = x1;
            this.y1 = y1;
                this.x2 = x2;
             
            this.y2 = y2;
        }
        public Hinh()
        {

        }
        public abstract void Ve();
        public abstract void input();   
        public abstract void output();
    }

    public class DoanThang : Hinh
    {
      
        public DoanThang(int x1, int y1, int x2, int y2) : base(x1, y1, x2, y2)
        {
        }

        public DoanThang()
        {
        }

        public override void Ve()
        {
            Console.WriteLine("Ve Doan thang");
            Console.WriteLine("Ve khung hinh");
            Console.WriteLine();
        }

        public override void input()
        {
            Console.Write("Input x1 :");
            x1 = Int32.Parse(Console.ReadLine());
            Console.Write("Input y1 : ");
            y1 = Int32.Parse(Console.ReadLine());
            Console.Write("Input x2 :");
            x2 = Int32.Parse(Console.ReadLine());
            Console.Write("Input y2: ");
            y2 = Int32.Parse(Console.ReadLine());
        }

        public override void output()
        {
            Console.WriteLine(" x1 {1} y1 {2} x2{3} ,y2{4}", x1, y1, x2, y2);
        }
    }

    public class HinhChuNhat : Hinh
    {
        protected int iChieudai;
        protected int iChieurong;

        public HinhChuNhat()
        {
        }

        public HinhChuNhat(int x1, int y1, int x2, int y2) : base(x1, y1, x2, y2)
        {
        }

        public override void input()
        {
            Console.Write("Width: ");iChieurong = Int32.Parse(Console.ReadLine());

            Console.Write("Heigth: "); iChieudai = Int32.Parse(Console.ReadLine());
        }

        public override void output()
        {
            Console.Write("Width:{1}  Height:{2}", iChieurong, iChieudai);
        }

        public override void Ve()
        {
            Console.WriteLine("Ve hinh chu nhat");
            Console.WriteLine("Ve khung hinh");
            Console.WriteLine();
        }
    }

    public class HinhTron : Hinh
    {
        protected int iBanKinh;

        public HinhTron()
        {
        }

        public HinhTron(int x1, int y1, int x2, int y2) : base(x1, y1, x2, y2)
        {
        }

        public override void input()
        {
            Console.WriteLine("Input bk: "); iBanKinh = Int32.Parse(Console.ReadLine());
        }

        public override void output()
        {
            Console.WriteLine("Input bk: ",iBanKinh); 
        }

        public override void Ve()
        {
            Console.WriteLine("Ve hinh tron");
            Console.WriteLine("Ve khung hinh");
            Console.WriteLine();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            //Please, run in debugging mode 5 times
            DoanThang h1 = new DoanThang();
            HinhChuNhat h2 = new HinhChuNhat();
            HinhTron h3 = new HinhTron();

            List<Hinh> lHinh = new List<Hinh>();
            lHinh.Add(h1);
            lHinh.Add(h2);
            lHinh.Add(h3);

            foreach (Hinh h in lHinh)
            {
                h.Ve();
            }

            //Get a object from the list
            DoanThang dt = (DoanThang)lHinh[0];
            dt.Ve();
        }
    }
}

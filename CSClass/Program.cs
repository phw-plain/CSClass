using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSClass
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car();
            car.SetInTime();
            car.SetOutTime();
            
            Random random = new Random();
            Console.WriteLine(random.Next(10, 100));
            Console.WriteLine(random.Next(10, 100));
            Console.WriteLine(random.Next(10, 100));
            Console.WriteLine(random.Next(10, 100));
            Console.WriteLine(random.Next(10, 100));

            Console.WriteLine(random.NextDouble());
            Console.WriteLine(random.NextDouble());
            Console.WriteLine(random.NextDouble());
            Console.WriteLine(random.NextDouble() * 10);

            /* 
            List<int> list = new List<int>();
            list.Add(11);
            list.Add(22);
            list.Add(33);
            list.Add(44);
            */ 

            List<int> list = new List<int>() { 52, 273, 32, 42 };
            list.Remove(42);
            list.RemoveAt(0);

            foreach (var item in list)
            {
                Console.WriteLine("Count : " + list.Count + "\t" + item);
            }

            Console.WriteLine(Math.Abs(-52273));
            Console.WriteLine(Math.Ceiling(52.273));
            Console.WriteLine(Math.Floor(52.273));
            Console.WriteLine(Math.Round(52.273));
            Console.WriteLine(Math.Max(52, 273));
            Console.WriteLine(Math.Min(52, 273));
            Console.WriteLine(Math.PI);
            /*
                        Product product = new Product();
                        product.name = "고구마";
                        product.price = 6000;
            */
            Product productA = new Product() { name = "감자", price = 2000 };
            Product productB = new Product() { price = 1000, name = "고구마" };
            Product productC = new Product() { name = "옥수수" };

            Console.WriteLine(productA);
            Console.WriteLine(productB);
            Console.WriteLine(productC);

            List<Student> students = new List<Student>()
            {
                new Student() { name = "함기훈", grade = 100 },
                new Student() { name = "가연우", grade = 100 },
                new Student() { name = "김유진", grade = 89 },
                new Student() { name = "김하진", grade = 80 },
                new Student() { name = "박수연", grade = 101 },
                new Student() { name = "박혜원", grade = 77 },
                new Student() { name = "심이진", grade = 100 },
                new Student() { name = "유예영", grade = 33 },
                new Student() { name = "윤주희", grade = 22 },
                new Student() { name = "윤채원", grade = 88 }
            };

/*
            students.Add(new Student() { name = "함기훈", grade = 100 });
            students.Add(new Student() { name = "가연우", grade = 100 });
            students.Add(new Student() { name = "김유진", grade = 89 });
            students.Add(new Student() { name = "김하진", grade = 80 });
            students.Add(new Student() { name = "박수연", grade = 101 });
            students.Add(new Student() { name = "박혜원", grade = 77 });
            students.Add(new Student() { name = "심이진", grade = 100 });
            students.Add(new Student() { name = "유예영", grade = 33 });
            students.Add(new Student() { name = "윤주희", grade = 22 });
            students.Add(new Student() { name = "윤채원", grade = 88 });
*/
/*
            foreach (var student in students)
            {
                if(student.grade > 60)
                {
                    students.Remove(student);
                }
            }
*/
/*
            for(int i=0; i<students.Count; i++)
            {
                if(students[i].grade > 60)
                {
                    students.RemoveAt(i);
                }
            }
*/

            for(int i=students.Count-1; i>=0; i--)
            {
                if(students[i].grade > 60)
                {
                    students.RemoveAt(i);
                }
            }

            foreach (var item in students)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine(MyMath.Abs(52));
            Console.WriteLine(MyMath.Abs(-52));
            Console.WriteLine(MyMath.Abs(-52.3));
            Console.WriteLine(MyMath.Abs(52f));
            Console.WriteLine(MyMath.Abs(52l));

            Product productX = new Product("감자", 2000);
            Product productY = new Product("고구마", 3000);

            Console.WriteLine(productX);
            Console.WriteLine(productY);
            Console.WriteLine(Product.counter + "개가 생성되었습니다.");

            SingleTon mySingle = SingleTon.getInstance();

            Console.WriteLine("첫 번째 위치");
            Sample sample = new Sample();
            Console.WriteLine("두 번째 위치");
            Console.WriteLine(Sample.value);
            Console.WriteLine("세 번째 위치");
        }
    }
}

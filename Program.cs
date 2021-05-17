using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proje1
{
    class Point
    {
        private double width;
        private double height;

        public double Width
        {
            get { return width; }
            set { width = value; }
        }

        public double Height
        {
            get { return height; }
            set { height = value; }
        }
        public Point(double w, double h)
        {
            this.width = w;
            this.height = h;
        }
        public static Point createPoint(double width, double height)//nokta oluşturuluyor
        {
            Point newPoint = new Point(width, height);
            return newPoint;
        }
        public static double findDistance(Point point1, Point point2)//uzaklık bulunuyor
        {
            return Math.Sqrt(Math.Pow(point1.width - point2.width, 2) + Math.Pow(point1.height - point2.height, 2));
        }
    }
    class Program
    {
        static Random randomDouble = new Random();//random nesnesi oluşturuldu
        static void Main(string[] args)
        {
            String numberOfPoints;//kullanıcıdan rastgele oluşturulacak olan nokta sayısı alınıyor
            Console.WriteLine("Kaç nokta oluşturmak istiyorsunuz?");
            numberOfPoints = Console.ReadLine();
            int n = Int32.Parse(numberOfPoints);//alınan sayı integer değere çevriliyor
            Console.WriteLine(n + " tane nokta oluşturuluyor...");
            Point[] point;//nokta nesnesi oluşturulup noktalar içine yazdırılıyor
            point = new Point[n];
            for (int tekrar = 0; tekrar < n; tekrar++)
            {
                Double width = randomDouble.Next(99) + randomDouble.NextDouble();//random x değeri oluşturuluyor
                Double height = randomDouble.Next(99) + randomDouble.NextDouble();//random y değeri oluşturuluyor
                Point nPoint = Point.createPoint(width, height);
                point[tekrar] = nPoint;
            }
            Console.WriteLine("x" + "\t" + "\t" + "\t" + "y");
            foreach (Point currentPoint in point)
            {

                Console.WriteLine(currentPoint.Height + "\t" + currentPoint.Width);//tüm noktalar yazdırılıyor

            }
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {

                    Console.Write("{0:0.00} \t ", Point.findDistance(point[i], point[j]));//bütün noktaların birbiri arasındaki uzaklıklar bulunuyor ve yazdırılıyor
                }
                Console.WriteLine("");
            }
            Console.ReadKey();
        }
    }
}
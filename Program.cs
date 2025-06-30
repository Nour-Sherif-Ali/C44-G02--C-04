using System.Linq;
using System.Text;
namespace assignment__4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Question1
            //double[] x = new double[3];
            //double[] y = new double[3];
            //Console.WriteLine("Enter the coordinates for the three points :");
            //for(int i = 0;i<3;i++)
            //{
            //    Console.WriteLine($"point x{i + 1} :");
            //    x[i] = Convert.ToDouble(Console.ReadLine());

            //    Console.WriteLine($"point y{i + 1} :");
            //    y[i] = Convert.ToDouble(Console.ReadLine());

            //}

            //double area =0.5 *  Math.Abs((x[0] * (y[1] - y[2]) + x[1] * (y[2] - y[0]) + x[2] * (y[0] - y[1]))); 
            //Console.Clear();
            //for(int i=0; i<3; i++)
            //{
            //    Console.WriteLine("Your Points are :- ");
            //    Console.WriteLine($"x{i + 1}" + x[i]);
            //    Console.WriteLine($"y{i + 1}" + y[i]);
            //}
            //Console.WriteLine($"Your Area is {area}");
            //if(area == 0)
            //{
            //    Console.WriteLine("The points are collinear");
            //}
            //else
            //{
            //    Console.WriteLine("The points are not collinear");
            //}
            #endregion

            #region Question2 

            //Console.WriteLine("Enter the your effieciency Time in hours :");
            //bool success = float.TryParse(Console.ReadLine(), out float efficiencyTime);

            //if (!success)
            //{
            //    Console.WriteLine("Invalid input. Please enter a number.");
            //    return;
            //}

            //if (efficiencyTime <= 2)
            //{
            //    Console.WriteLine("Highly efficient");
            //}
            //else if (efficiencyTime > 2 && efficiencyTime <= 3)
            //{
            //    Console.WriteLine("Increase their speed.");
            //}
            //else if (efficiencyTime > 3 && efficiencyTime <= 4)
            //{
            //    Console.WriteLine("Enhance your speed.");
            //}
            //else if (efficiencyTime > 4 && efficiencyTime <= 5)
            //{
            //    Console.WriteLine("Need serious improvement.");
            //}
            //else if (efficiencyTime > 5)
            //{
            //    Console.WriteLine("Leave the company.");
            //}
            //else
            //{
            //    Console.WriteLine("Enter your efficiency time.");
            //}
            #endregion

            #region Question3
         //   string[] s = 
         //"this is a test ".Split(' ');
         //   string ans = "";
         //   for (int i = s.Length - 1;
         //            i >= 0; i--)
         //   {
         //       ans += s[i] + " ";
         //   }
         //   Console.Write(
         //   "Reversed String:");
         //   Console.Write(ans.Substring(0,
         //                 ans.Length - 1));


            #endregion

            #region Question4
            //Console.WriteLine("Enter a string to split into substrings: ");
            //string ? s =Console.ReadLine() ;

            //string[] subs = s.Split(' ');

            //foreach (var sub in subs)
            //{
            //    Console.WriteLine($"Substring: {sub}");
            //}
            #endregion
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace domashna1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Vuvedi spisuk ot drobni chisla ");
            string[] masiv = Console.ReadLine().Split(' ');
            List<double> numbers = new List<double>();
            for (int i = 0; i < masiv.Length; i++)
            {
                numbers.Add(double.Parse(masiv[i]));
            }
            Console.WriteLine("Vuvedi 3 chisla: ");
            string[] masiv2 = Console.ReadLine().Split(' ');
            int n = int.Parse(masiv2[0]);
            int m = int.Parse(masiv2[1]);
            double target = double.Parse(masiv2[2]);
            List<double> nums = numbers.GetRange(0, n);
            double average = 0;
            foreach (double num in nums)
            {
                average += num;
            }
            average /= nums.Count;
            int removedCount = 0;
            while (removedCount < m && nums.Count > 0 && nums[nums.Count - 1] < average)
            {
                nums.RemoveAt(nums.Count - 1);
                removedCount++;
            }
            Console.WriteLine("Yes Uspqh!");
            Console.WriteLine($"{numbers.Count} e broqt chisla");
            int countBelowAverage = 0;
            foreach (var num in nums)
            {
                if (num < average)
                {
                    countBelowAverage++;
                }
            }
            Console.WriteLine($"{countBelowAverage} sa chisla, koito sa pod tri to e srednoto");
            Console.WriteLine("Ostavat " + string.Join(" ", nums + " koeto e " + nums.Count + " broq ostavat sled vadeneto"));
            if (nums.Contains(target))
            {
                Console.WriteLine("PROOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOO!");
            }
            else
            {
                Console.WriteLine("BOTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTT!");
            }
        }
    }
}

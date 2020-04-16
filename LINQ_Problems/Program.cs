using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_Problems
{
    class Program
    {
        static void Main(string[] args)
        {
            //1. th checker
            //***********************************************************************************
            //var words = new List<string>() { "the", "bike", "this", "it", "tenth", "mathematics" };
            //var thWords = words.Where(m => m.Contains("th"));
            //foreach (string word in thWords)
            //{
            //    Console.WriteLine(word);
            //}

            ////2. duplicate remover
            ////***********************************************************************************
            //var names = new List<string>() { "Mike", "Brad", "Nevin", "Ian", "Mike" };
            //var noDoubleNames = names.Distinct();
            //foreach (string name in noDoubleNames)
            //{
            //    Console.WriteLine(name);
            //}

            ////3. grade calculator
            ////***********************************************************************************
            //List<string> allGrades = new List<string>()
            //{
            //    "80,100,92,89,65", //85.2
            //    "93,81,78,84,69", //81
            //    "73,88,83,99,64", //81.4
            //    "98,100,66,74,55" //78.7
            //};
            //List<double> averageCourseGrades = new List<double>();
            //foreach(string courseGrades in allGrades)
            //{
            //    string[] separators = {","};
            //    string[] individualGradesString = courseGrades.Split(separators, StringSplitOptions.RemoveEmptyEntries);
            //    List<double> individualGradesList = new List<double>();                               
                
            //    foreach(string grade in individualGradesString)
            //    {
            //        individualGradesList.Add(Convert.ToDouble(grade));                    
            //    }
            //    individualGradesList.Remove(individualGradesList.Min());
            //    double ave = individualGradesList.Average();
            //    averageCourseGrades.Add(ave);                
            //}
            //Console.WriteLine(averageCourseGrades.Average());
            //Console.ReadLine();

            //4. alphabet frequency
            //Console.WriteLine("GIVE ME A WORD!");           
            //string input = Console.ReadLine().ToUpper();
            //char[] inputArray = input.ToCharArray();
            //Array.Sort(inputArray);            
            //int count = 1;
            //for (int i = 0; i < inputArray.Count()-1; i++)
            //{                       
            //    if(inputArray[i] == inputArray[i + 1])
            //    {
            //        count++;
            //    }
            //    else
            //    {
            //        Console.Write($"{inputArray[i]}{count}");
            //        count = 1;
            //    }
            //}
            //if(inputArray[inputArray.Count()-1] != inputArray[inputArray.Count()-2])
            //{
            //    count = 1;
            //}
            //Console.Write($"{inputArray[inputArray.Count()-1]}{count}");
            //Console.ReadLine();

        }
    }
}

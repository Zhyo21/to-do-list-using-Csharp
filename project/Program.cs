using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace project
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("welcome to the to do list program.");
            List<String> taskList = new List<string>();
            String option = "";

            while(option != "Exit" || option != "exit")
            {
                Console.WriteLine("what would you like to do?");
                Console.WriteLine("enter 1 to add task to the list");
                Console.WriteLine("enter 2 to remove task to the list");
                Console.WriteLine("enter 3 to view the list");
                Console.WriteLine("enter exit/Exit to close the program");

                option = Console.ReadLine();

                if (option == "1")
                {
                    Console.WriteLine("please enter the name of the task to add to the list.");
                    String task = Console.ReadLine();
                    taskList.Add(task);
                    Console.WriteLine("Task added to the list.");


                }


                else if(option == "2")
                {
                    for (int i = 0; i < taskList.Count; i++)
                    {

                        Console.WriteLine(i+ " : "+ taskList[i]);
                    }

                    Console.WriteLine("enter the number of tasks you want to remove");
                    int taskNumber = Convert.ToInt32(Console.ReadLine());
                    taskList.RemoveAt(taskNumber);
                }


                else if(option == "3")
                {
                    for (int i = 0; i < taskList.Count; i++)
                    {

                        Console.WriteLine(taskList[i]);
                    }





                }
                else if (option != "Exit" || option != "exit")
                {
                    Console.WriteLine("exiting program");





                }
                else
                {

                    Console.WriteLine("invalid!!");

                }
            }

            Console.WriteLine("Thank you");
        }
    }
}

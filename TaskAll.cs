using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class TaskAll
    {
        public void TaskWatiaAll()
        {
            var tasks = new List<Task>();

            for (int i = 0; i < 10; i++)
            {
                int taskIndex = i;
                tasks.Add(Task.Run(() => DoWork(taskIndex)));
            }

            Task.WaitAll(tasks.ToArray());

        }

        static void DoWork(int i)
        {
            Console.WriteLine($"Task {i} is running");
        }
    }


}

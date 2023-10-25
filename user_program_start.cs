using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace shambala_sistem_programming_24_10_2023
{
    // ЗАДАНИЕ:
    // пользователь вводит название программы, которую необходимо запустить
    // наша программа создает и запускает процесс исполнения этой программы
    // после запуска выводится информация о запущенном процессе и далее в цикле
    // предлагается:
    // 1) убить процесс (цикл завершается)
    // 2) проверить работает ли еще процесс, если нет, то завершить цикл

    // после выхода из цикла вывести код завершения процесса и время завершения

    internal class user_program_start
    {
        static void Main(string[] args)
        {
           // C:\Users\Fishman_1\Documents\GitHub\practica_ADONET_WPF_product_-11-10-2023\bin\Debug\practica_ADONET_WPF_product_-11-10-2023.exe
            Process[] processes = Process.GetProcesses();
            Process process = new Process();
            try
            {
                Console.WriteLine("напишите имя процесса для запуска:  ");
                string procstart = "notepad.exe";
                process.StartInfo.FileName = procstart;
                process.Start();
                Console.WriteLine("процесс запущен");
                 Console.WriteLine($"{process.Id} - " + "\n"+
                     $"{process.ProcessName} - " + "\n" +
                     $"{process.BasePriority}");
                Console.Write("");
                Console.Read();
                Console.Write("выбираем что делать: 1 - убить  2 - пожалеть");
                Console.Write("");
                //string chouse = Console.ReadLine();
                // Console.Read();
                // chrome.exe
                // notepad.exe
                while (process.HasExited)
                {
                    Console.Write("выбираем что делать: 1 - убить  2 - пожалеть");
                    Console.WriteLine("");
                    string chouse = Console.ReadLine();
                    if  ( chouse == "1")
                    {
                        Console.WriteLine("процесс завершен");
                        process.Kill();
                        Console.WriteLine(process.ExitCode);
                    }
                    
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message.ToString());
            }

        }
    }
}

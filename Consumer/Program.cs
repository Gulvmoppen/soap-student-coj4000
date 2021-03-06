﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WcfStudentService;

namespace Consumer
{
    class Program
    {
        static void Main(string[] args)
        {
            Service1 service = new Service1();
            String line = Console.ReadLine();
            String myline = Console.ReadLine();
            while (!line.Trim().ToLower().Equals("stop"))
            {
                Console.WriteLine("Hvilken funktion vil du have? opret, edit, remove, find, getall. eller skriv stop for at stoppe");
                myline = Console.ReadLine().Trim() ?? "";
                if (myline.ToLower().Equals("opret"))
                {
                    Console.WriteLine("Skriv id og navn");
                    int a = 0;
                    string b = "";
                    for (int i = 0; i < 2; i++)
                    {
                        if (a == 0)
                        {
                            Console.WriteLine("Skriv ID");
                            a = int.Parse(Console.ReadLine());
                        }
                        if (a != 0 && b == "")
                        {
                            Console.WriteLine("Skriv navn");
                            b = Console.ReadLine();
                        }
                    }
                    service.AddStudent(a, b);
                }
                if (myline.ToLower().Equals("edit"))
                {
                    string a = "";
                    string b = "";
                    for (int i = 0; i < 2; i++)
                    {
                        
                        if (a != "")
                        {
                            Console.WriteLine("Skriv nyt navn");
                            b = Console.ReadLine();
                        }
                        if (a == "")
                        {
                            Console.WriteLine("Skriv navn");
                            a = Console.ReadLine();
                        }
                     
                    }
                    service.EditStudent(a, b);
                }
                
                if (myline.ToLower().Equals("remove"))
                {
                    
                    Console.WriteLine("Skriv navn på studerende du vil have fjernet");
                    service.RemoveStudent(Console.ReadLine());
                }
                if (myline.ToLower().Equals("find"))
                {
                    Console.WriteLine("Skriv navn på student du vil have vist:");
                    Console.WriteLine(service.FindStudent(int.Parse(Console.ReadLine())).ToString());
                    
                }
                if (myline.ToLower().Equals("getall"))
                {
                    Console.WriteLine("Alle studerende:");
                    foreach (var s in service.GetAllStudents())
                    {
                        Console.WriteLine("Student:" + s);
                    }
                }
                if (myline.ToLower().Equals("stop"))
                {
                    line = "stop";
                }
            }
        }
    }
}

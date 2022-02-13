using System;

using System.Collections.Generic;

using System.Linq;

using System.Text;

using System.IO;

namespace records

{

    

    class patient

    {

        

        public int num;

        public string name;

        public int balance;

    }

    

    class Program

    {

        

        static void Main(string[] args)

        {

            

            using (StreamWriter sw = new StreamWriter("PatientRecords.txt"))

            {

                

                patient pat = new patient();

                

                Console.WriteLine("Enter patient ID (0 to exit): ");

                pat.num = Convert.ToInt32(Console.ReadLine());

                

                while (pat.num != 0)

                {

                    

                    sw.Write(pat.num + " ");

                    

                    Console.WriteLine("Enter patient name: ");

                    pat.name = Console.ReadLine();

                    sw.Write(pat.name + " ");

                    

                    Console.WriteLine("Enter patient balance: ");

                    pat.balance = Convert.ToInt32(Console.ReadLine());

                    sw.WriteLine(pat.balance);

                    

                    Console.WriteLine("Enter patient ID (0 to exit): ");

                    pat.num = Convert.ToInt32(Console.ReadLine());

                }

            }
            

            string line = "";

            

            try

            {

                

                using (StreamReader sr = new StreamReader("PatientRecords.txt"))

                {

                    while ((line = sr.ReadLine()) != null)

                    {

                        Console.WriteLine(line);

                    }

                }

            }

            

            catch { }
            


            int id;

            Console.WriteLine("Enter ID to be searched:");

            id = Convert.ToInt32(Console.ReadLine());

            

            try

            {

                

                using (StreamReader sr = new StreamReader("PatientRecords.txt"))

                {

                    while ((line = sr.ReadLine()) != null)

                    {


                        string[] tokens = line.Split(' ');

                       

                        if (Convert.ToInt32(tokens[0]) == id)

                            Console.WriteLine(line);

                    }

                }

            }

            

            catch { }

            Console.WriteLine("Enter minimum balance:");

            id = Convert.ToInt32(Console.ReadLine());

           

            try

            {

               

                using (StreamReader sr = new StreamReader("PatientRecords.txt"))

                {

                    while ((line = sr.ReadLine()) != null)

                    {

                       

                        string[] tokens = line.Split(' ');

                       

                        if (Convert.ToInt32(tokens[2]) >= id)

                            Console.WriteLine(line);

                    }

                }
                {

                    

                }

                Console.ReadKey();

            }
            catch{ }
        }

        }
    }





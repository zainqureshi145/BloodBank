using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BloodBank
{
    class Program : Manager
    {
        static void Main(string[] args)
        {
            Manager MO = new Manager();
            string choice;
            int x = 100;
            while (x == 100)///////Always True, Always Runs Until Exit
            {
                Console.WriteLine("Enter Your Choice...\n");
                Console.WriteLine("Press 1 For Register Donor\nPress 2 To Search Donor By Name\nPress 3 to Search Donor By Blood Group");
                Console.WriteLine("Press 4 to Display All Donors\nPress 5 to Display Amount Of Blood\nType Exit to Exit");
                choice = Console.ReadLine();
                switch (choice)
                {
                    case "1":
                        {
                            MO.Register();
                            break;
                        }
                    case "2":
                        {
                            MO.SearchByName();
                            break;
                        }
                    case "3":
                        {
                            MO.MatchingBGroup();
                            break;
                        }
                    case "4":
                        {
                            MO.DisplayDonors();
                            break;
                        }
                    case "5":
                        {
                            MO.DisplayDonors();
                            break;
                        }
                    case "Exit":
                            {
                                return;
                            }
                    default:
                        {
                            Console.WriteLine("Enter Choices As Described...");
                            break;
                        }
                }
            }
        }
    }
}

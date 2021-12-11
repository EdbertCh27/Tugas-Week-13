using System;
using System.Collections.Generic;
using System.Linq;
namespace Tugas_Week_13
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> scrolls = new List<string>() { "Book of Peace", "Scroll of Swords", "Silence Guide Book" }; //Declare LIST
            while (true)
            {
                Console.WriteLine("1. My Scroll List \n2. Add Scroll \n3. Search Scroll \n4. Remove Scroll");
                Console.Write("Choose What to do : ");
                int pilihan = Convert.ToInt32(Console.ReadLine());
                int count = 0; //Declare variabel untuk penomoran
                if (pilihan == 1)
                {
                    Console.WriteLine("\nScroll to Learn List : ");
                    foreach (string scrollList in scrolls)
                    {
                        count++; //penomoran
                        Console.WriteLine($"Scroll {count} : {scrollList} ");
                    }
                }
                if (pilihan == 2)
                {
                    Console.WriteLine("How many scroll to add ?");
                    int jumlahTambahBuku = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("In what number of queue ?");
                    int padaIndexKe = Convert.ToInt32(Console.ReadLine()) - 1;
                    if (padaIndexKe < 1)
                    {
                        padaIndexKe = 0;
                    }
                    if (padaIndexKe > scrolls.Count)
                    {
                        padaIndexKe = scrolls.Count;
                    }
                    for (int i = 0; i < jumlahTambahBuku; i++)
                    {
                        Console.WriteLine("Scroll " + (i + 1) + " Name : ");
                        scrolls.Insert(padaIndexKe + i, Console.ReadLine());
                    }
                }
                if (pilihan == 3)
                {
                    Console.WriteLine("Insert Scroll Name : ");
                    var FindScroll = "";
                    int counter = 0;
                    var Missing = true;
                    FindScroll = Console.ReadLine();
                    foreach (var ofScroll in scrolls)
                    {
                        if (ofScroll.ToLower() == FindScroll.ToLower())
                        {
                            Console.Write("Book Found. ");
                            Console.WriteLine("Queue Number : " + (counter + 1));
                            Missing = false;
                        }
                        counter++;
                    }
                    if (Missing == true)
                    {
                        Console.WriteLine("Book Not Found");
                    }
                }
                if (pilihan == 4)
                {
                    Console.WriteLine("Remove From Scroll List by Scroll Name ? (y/n) ");
                    string input = Console.ReadLine();
                    string FindRemoveScroll = "";
                    while (input != "y" && input != "n")
                    {
                        Console.WriteLine("Wrong Selection, Choose Again ! ");
                        Console.WriteLine("Remove From Scroll List by Scroll Name ? (y/n) ");
                        input = Console.ReadLine();
                    }
                    if (input == "y")
                    {
                        Console.WriteLine("Input Scroll Name : ");
                        FindRemoveScroll = Console.ReadLine();
                        var Missing = true;
                        for (int IndexHapus = 0; IndexHapus < scrolls.Count; IndexHapus++)
                        {
                            if (FindRemoveScroll.ToLower() == scrolls[IndexHapus].ToLower())
                            {
                                scrolls.RemoveAt(IndexHapus);
                                Console.WriteLine("Book Removed!");
                                Missing = false;
                            }
                        }
                        if (Missing == true)
                        {
                            Console.WriteLine("Book Not Found");
                        }
                    }
                    else if (input == "n")
                    {
                        int totalIndexList = scrolls.Count;
                        Console.WriteLine("Input Scroll Queue : ");
                        int InputIndexRemove = Convert.ToInt32(Console.ReadLine());
                        while (InputIndexRemove > totalIndexList || InputIndexRemove <= 0)
                        {
                            Console.WriteLine("Queue Not Found. Insert Scroll Queue : ");
                            InputIndexRemove = Convert.ToInt32(Console.ReadLine());
                        }
                        if (InputIndexRemove <= totalIndexList && InputIndexRemove > 0)
                        {
                            int IndexRemove = (InputIndexRemove - 1); //KENAPA -1? KARENA JIKA INPUT = 1, MAKA AKAN MENGHAPUS INDEX KE 1, SEDANGKAN LIST URUTAN PERTAMA DIMULAI DARI 0
                            scrolls.RemoveAt(IndexRemove);
                            Console.WriteLine("Book Removed!");
                            totalIndexList = totalIndexList - 1; // Setelah dihapus 1, maka indexnya otomatis berkurang 1 juga
                        }
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
// Program 4
// CIS 200-01
// Fall 2018
// Due: 11/26/2018
// By: D7184

// File: TestParcels.cs
// This is a simple, console application designed to exercise the Parcel hierarchy.
// It creates several different Parcels and prints them.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Prog1
{
    class TestParcels 
    {
        // Precondition:  None
        // Postcondition: Parcels have been created and displayed
        static void Main(string[] args)
        {
            // Test Data - Magic Numbers OK
            Address a1 = new Address("  John Smith  ", "   123 Any St.   ", "  Apt. 45 ",
                "  Louisville   ", "  KY   ", 12345); // Test Address 1
            Address a2 = new Address("Jane Doe", "987 Main St.",
                "Beverly Hills", "CA", 23456); // Test Address 2
            Address a3 = new Address("James Kirk", "654 Roddenberry Way", "Suite 321",
                "El Paso", "TX", 34567); // Test Address 3
            Address a4 = new Address("John Crichton", "678 Pau Place", "Apt. 7",
                "Portland", "ME", 01234); // Test Address 4
            Address a5 = new Address("Nicholas Goodridge", "1234 1st Street", "Apt #207", "Louisville", "KY", 45678);
            Address a6 = new Address("Derrek Baxter", "5678 2nd Street", "Cinncinatti", "OH", 56789);
            Address a7 = new Address("Eric Hoeweler", "0987 3rd Street", "Chicago", "IL", 67890);
            Address a8 = new Address("Lynnzee Kazee", "6543 4th Street", "Apt #456", "Panama", "KY", 78901);

            Letter letter1 = new Letter(a1, a2, 3.95M);                            // Letter test object
            Letter letter2 = new Letter(a3, a4, 1.00M);
            Letter letter3 = new Letter(a5, a6, 3.00M);                             // Letter test object
            GroundPackage gp1 = new GroundPackage(a7, a8, 14, 10, 5, 12.5);        // Ground test object
            GroundPackage gp2 = new GroundPackage(a1, a8, 5, 5, 5, 5);        // Ground test object
            NextDayAirPackage ndap1 = new NextDayAirPackage(a2, a7, 25, 15, 15,    // Next Day test object
                85, 7.50M);
            NextDayAirPackage ndap2 = new NextDayAirPackage(a3, a6, 10, 15, 20,    // Next Day test object
               53, 4.00M);
            NextDayAirPackage ndap3 = new NextDayAirPackage(a4, a5, 20, 30, 40,    // Next Day test object
                 50, 5.00M);
            TwoDayAirPackage tdap1 = new TwoDayAirPackage(a5, a2, 46.5, 39.5, 28.0, // Two Day test object
                80.5, TwoDayAirPackage.Delivery.Saver);
            TwoDayAirPackage tdap2 = new TwoDayAirPackage(a7, a3, 12, 24, 36, // Two Day test object
                90, TwoDayAirPackage.Delivery.Saver);

            List<Parcel> parcels;      // List of test parcels

            parcels = new List<Parcel>();

            parcels.Add(letter1); // Populate list
            parcels.Add(letter2);
            parcels.Add(letter3);
            parcels.Add(gp1);
            parcels.Add(gp2);
            parcels.Add(ndap1);
            parcels.Add(ndap2);
            parcels.Add(ndap3);
            parcels.Add(tdap1);
            parcels.Add(tdap2);

            Console.WriteLine("Original List:");
            Console.WriteLine("====================");
            foreach (Parcel p in parcels)
            {
                Console.WriteLine(p);
                Console.WriteLine("====================");
            }
            Pause();

            parcels.Sort();
            Console.WriteLine("Sorted List (Ascending Cost Order):");
            Console.WriteLine("====================");
            foreach (Parcel p in parcels)
            {
                Console.WriteLine(p);
                Console.WriteLine("====================");
            }
            Pause();

            parcels.Sort(new DescendingZipOrder());
            Console.WriteLine("Sorted List (Descending Zip Order:");
            Console.WriteLine("====================");
            foreach (Parcel p in parcels)
            {
                Console.WriteLine(p);
                Console.WriteLine("====================");
            }
        }

        // Precondition:  None
        // Postcondition: Pauses program execution until user presses Enter and
        //                then clears the screen
        public static void Pause()
        {
            Console.WriteLine("Press Enter to Continue...");
            Console.ReadLine();

            Console.Clear(); // Clear screen
        }
    }
}

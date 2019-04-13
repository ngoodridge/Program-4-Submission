// Program 4
// CIS 200-01
// Fall 2018
// Due: 11/26/2018
// By: D7184

// File: DescnedingZipOrder.cs
// Extends the Comparer<T> class to sort parcels in descneding order by the destination Zip Code

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Prog1
{
    class DescendingZipOrder : Comparer<Parcel>
    {
        // Precondition:  None
        // Postcondition: returns the list in descending order by Zip Code
        public override int Compare(Parcel p1, Parcel p2)
        {
            if (p1 == null && p2 == null) // Both null?
                return 0;

            if (p1 == null) // only p1 is null?
                return -1;  // 

            if (p2 == null) // only p2 is null?
                return 1;   

            return (-1) * p1.DestinationAddress.Zip.CompareTo(p2.DestinationAddress.Zip); // Calls the Zip of the destination address of the Parcel class and compares them agains eachother and sorts them in descending order
        }
    }
}

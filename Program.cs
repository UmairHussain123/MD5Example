using System;
using System.Security.Cryptography;
using System.Text;

namespace ConsoleApp8
{
    class Program

    {
        static void Main(string[] args)
        {
            string val;
             static byte[] MD5Hash(string message)
            {
                return MD5.Create().ComputeHash(Encoding.UTF8.GetBytes(message));
            }

            val = MD5Hash("55").ToString();

            Console.WriteLine(val);
            string hash = BitConverter.ToString(MD5.Create().ComputeHash(Encoding.ASCII.GetBytes("60987"))).Replace("-", "");
            Console.WriteLine(hash);



        }
        //{
        //    DateTime dDate=new DateTime();
        //    Console.WriteLine(dDate);
        //    Console.WriteLine(DateTime.TryParse("08/26/2022", out dDate));
        //    Console.WriteLine(dDate.ToString("yyyy-MM-dd"));


        //    if (DateTime.TryParse("08/26/2022", out dDate))
        //    {
        //        //////String.Format("YYYY-MMM-DD", dDate);
        //       // Console.WriteLine(String.Format("{0:MM/dd/yyyy}", dDate));
        //       //Console.WriteLine(String.Format("{0:t}", dDate));  // "4:05 PM"                           ShortTime
        //       //Console.WriteLine(String.Format("{0:d}", dDate));  // "3/9/2008"                          ShortDate
        //       //Console.WriteLine(String.Format("{0:T}", dDate));  // "4:05:07 PM"                        LongTime
        //       //Console.WriteLine(String.Format("{0:D}", dDate));  // "Sunday, March 09, 2008"            LongDate
        //       //Console.WriteLine(String.Format("{0:f}", dDate));  // "Sunday, March 09, 2008 4:05 PM"    LongDate+ShortTime
        //       //Console.WriteLine(String.Format("{0:F}", dDate));  // "Sunday, March 09, 2008 4:05:07 PM" FullDateTime
        //       //Console.WriteLine(String.Format("{0:g}", dDate));  // "3/9/2008 4:05 PM"                  ShortDate+ShortTime
        //       //Console.WriteLine(String.Format("{0:G}", dDate));  // "3/9/2008 4:05:07 PM"               ShortDate+LongTime
        //       //Console.WriteLine(String.Format("{0:m}", dDate));  // "March 09"                          MonthDay
        //       //Console.WriteLine(String.Format("{0:y}", dDate));  // "March, 2008"                       YearMonth
        //       //Console.WriteLine(String.Format("{0:r}", dDate));  // "Sun, 09 Mar 2008 16:05:07 GMT"     RFC1123
        //       //Console.WriteLine(String.Format("{0:s}", dDate));  // "2008-03-09T16:05:07"               SortableDateTime
        //       //Console.WriteLine(String.Format("{0:u}","08/26/" +
        //       //    "2022"));  // "2008-03-09 16:05:07Z"              UniversalSortableDateTime
        //    }
        //    else
        //    {
        //        Console.WriteLine("Invalid"); // <-- Control flow goes here
        //    }
        //}
    }
}

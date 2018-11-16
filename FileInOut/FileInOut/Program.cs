using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FileInOut
{
    class Program
    {
        static void Main(string[] args)
        {
            
            string filePath2 = @"C:\\Users\\hktse\\source\\repos\\FileDrill.txt";//creating the file and its path
            FileInfo myFile = new FileInfo(filePath2);                           // getting the file
            BinaryWriter bw = new BinaryWriter(myFile.OpenWrite());              // opening the file for writing

            Console.WriteLine("Please enter your  zipcode  number.");           // asking the user for input
            int zipCod = int.Parse(Console.ReadLine());
            bw.Write(zipCod);                                                   // writing input data to the file
            bw.Close();

            BinaryReader br = new BinaryReader(myFile.OpenRead());              // opening file for reading
            Console.WriteLine(br.ReadInt32());                                  // outputing data back to the user
            br.Close();
            Console.ReadLine();

            
            

        }
    }
}

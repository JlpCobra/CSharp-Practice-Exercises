using System;
using static System.Console;
using System.Globalization;
using System.IO;
class FindPatientRecords2
{
   static void Main()
   {
      const string FILENAME = "Patients.txt";
      const char DELIM = ',';

      Write("Enter minimum balance >> ");
      double minBalance = Convert.ToDouble(ReadLine());

      if (!File.Exists(FILENAME))
        {
            WriteLine("The file does not exist.");
            return;
        }

        FileStream inFile = new FileStream(FILENAME, FileMode.Open, FileAccess.Read);
        StreamReader reader = new StreamReader(inFile);

        string recordIn;
        bool anyFound = false;

        WriteLine();
        WriteLine("ID Number Name                 Balance");

        while ((recordIn = reader.ReadLine()) != null)
        {
            string[] fields = recordIn.Split(DELIM);

            string id = fields[0];
            string name = fields[1];
            double balance = Convert.ToDouble(fields[2]);

            if (balance >= minBalance)
            {
                anyFound = true;

                WriteLine("{0,-10}{1,-20}{2}", id, name, balance.ToString("C", CultureInfo.GetCultureInfo("en-US")));

            }
        }

        if (!anyFound)
        {
            WriteLine("No records found with balance >= {0}", minBalance.ToString("C", CultureInfo.GetCultureInfo("en-US")));
        }

        reader.Close();
        inFile.Close();
   }
}
   

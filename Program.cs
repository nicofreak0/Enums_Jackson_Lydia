using System;
using System.IO;

namespace Enums_Jackson_Lydia
{
    internal class Program
    {
        // global enum called months with jan - dec, jan set as one so it counts up from there
        enum Months
        {
                Jan = 1,
                Feb,
                Mar,
                Apr,
                May,
                Jun,
                Jul,
                Aug,
                Sep,
                Oct,
                Nov,
                Dec,

        }
        static void Main(string[] args)
        {
            //ints called myBirthMonth myBirthDay myBirthYear with my birth dates set to them
            int myBirthMonth = (int)Months.Nov;
            int myBirthDay = 23;
            int myBirthYear = 2003;

            //a string that puts myBirthMonth myBirthDay myBirthYear in a sentence
            string myBirthDate = $"My Birthday is on {myBirthMonth}/{myBirthDay}/{myBirthYear}";

            // writes text to myFile.txt reads it and prints it to console
            File.WriteAllText("myFile.txt", "This is My Text File!\n");
            Console.WriteLine(File.ReadAllText("myFile.txt"));

            // appends the text from myFile.txt and the new text
            File.AppendAllText("myFile.txt", "More Text Added to File.\n");
            Console.WriteLine(File.ReadAllText("myFile.txt"));
            
            //if file does not exist copy myFile.txt to newFile.txt
            if(!File.Exists("newFile.txt"))
            {
                File.Copy("myFile.txt", "newFile.txt");
            }
            // if it does exist replace newFile.txt with myFile.txt also creates a backup of newFile.txt
            else
            {
                File.Replace("newFile.txt", "myFile.txt", "backupFile.txt");
            }

            // appends the content of myDirthDate to newFile.txt and prints the supdated content to console
            File.AppendAllText("newFile.txt", myBirthDate);
            Console.WriteLine(File.ReadAllText("newFile.txt"));
        }
    }
}
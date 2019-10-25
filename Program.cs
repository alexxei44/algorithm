using System;
using System.IO;
using System.Collections.Generic;
using Lab3A;
namespace Lab3A
{
    
    
    public abstract class Program 
    {
        static void Main(string [] args)
        {
            Console.WriteLine("1) List All Books");
            Console.WriteLine("2) List All Movies");
            Console.WriteLine("3) List All Songs");
            Console.WriteLine("4) List All Media");
            Console.WriteLine("5) Search by title");
            Console.WriteLine("6) Exit");
            int choice = int.Parse(Console.ReadLine());
            Media[] readervar = ReadData(choice); 
        }
        private static Media[] ReadData(int choice)
        {
            
            List<Media> result = new List<Media>(); // The final result that will be returned 
                                                    // Validate if there is a valid textfile in the specific directory and checks if the content of the file is valid 
            try
            {
                // Initialize variables 
                string file = @"Data.txt"; // The path and name of the file string line;
                                           // the current line of the stream 
                StreamReader reader = new StreamReader(file); // Used for reading the file
                                                              // Reads file until the end of the stream
                while (!reader.EndOfStream)
                {
                    // Initialize variables that will be used for reading data, and will reset every time a new line is read 
                    List<string> summary = new List<string>();
                    string line = reader.ReadLine();
                    string[] splitLine = line.Split('|');
                    // Makes sure the data being read is actually data, not a separator 
                    if (!line.Equals("-----"))
                    {
                        // Check the type of media, and if it is the selected option by the user, then add it to the list of media that will be displayed
                        if (splitLine[0].ToUpper() == "BOOK" && (choice == 4 || choice == 1))
                        {
                            // Reads multiple lines of summary, until the next separator 
                            while (!(line = reader.ReadLine()).Equals("-----")) { summary.Add(line); }
                            result.Add(new Book(splitLine[3], Convert.ToInt32(splitLine[2]) , splitLine[1], String.Join(' ', summary)));
                            foreach (var Book in result)
                            {

                                Console.WriteLine(Book.ToString());
                            }
                            
                            


                        }
                        
                        else  if (splitLine[0].ToUpper() == "SONG" && (choice == 4 || choice == 3))
                        {
                            // Reads multiple lines of summary, until the next separator 
                            while (!(line = reader.ReadLine()).Equals("-----")) { summary.Add(line); }
                            result.Add(new Song(splitLine[3], Convert.ToInt32(splitLine[2]) , splitLine[1], String.Join(' ', summary)));
                            foreach (var Song in result)
                            {

                                Console.WriteLine(Song.ToString());
                            }
                          


                        }
                        else if (splitLine[0].ToUpper() == "MOVIE" && (choice == 4 || choice == 2))
                        {
                            // Reads multiple lines of summary, until the next separator 
                            while (!(line = reader.ReadLine()).Equals("-----")) { summary.Add(line); }
                            result.Add(new Movie(splitLine[3],Convert.ToInt32(splitLine[2]), splitLine[1], String.Join(' ', summary)));
                            foreach (var Movie in result)
                            {

                                Console.WriteLine(Movie.ToString());
                            }


                        }
                        else if (choice == 6) { 
}
                    }
                }

                // Make the search case insensitive by treating strings as lowercase
                                    // Didn't find it
            
            }
            catch (Exception ex)
            {
                
            }
            return result.ToArray();

        }

        }

    }


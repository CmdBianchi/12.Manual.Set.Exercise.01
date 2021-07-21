using System;
using System.Collections.Generic;
using System.IO;
using Entities;
namespace _12.Manual.Set.Exercise._01 {
    class Program {
        static void Main(string[] args) {

            HashSet<LogRecord> set = new HashSet<LogRecord>();

            Console.WriteLine("Enter file full path: ");
            string path = @"c:\temp\in.txt"; // ou console.ReadLine(); && @ na frente do diretorio para funcionar o caminho.

            try {
                using (StreamReader sr = File.OpenText(path)) {
                    while (!sr.EndOfStream) {
                        string[] line = sr.ReadLine().Split(' ');
                        string name = line[0];
                        DateTime instant = DateTime.Parse(line[1]);
                        set.Add(new LogRecord {Username = name, Instant = instant });
                    }
                    Console.WriteLine("Total users: " + set.Count);
                }
            }
            catch(IOException e) {
                Console.WriteLine(e.Message);
            }
        }
    }
}

using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zhurkevich_lab8
{
    internal static class RecordsTable
    {
        private static string path = "records.json";

        public static void SaveRecord(string name, int count, Stopwatch sw)
        {
            Record record = new Record(name, Math.Round(count / sw.Elapsed.TotalMinutes, 1), Math.Round(count / sw.Elapsed.TotalSeconds, 1));
            string jsonString = JsonConvert.SerializeObject(record);
            File.AppendAllText(path,jsonString + "\n");
        }

        public static void PrintRecords()
        {
            Console.Clear();
            Console.Title = "Таблица рекордов";
            Console.WriteLine("Тест на скоропечатание\n-----------------------");
            Console.WriteLine("Таблица рекордов:");
            string[] records = File.ReadAllText(path).Split("\n");
            foreach (string recordData in records)
            {
                if (!string.IsNullOrEmpty(recordData))
                {
                    Record record = JsonConvert.DeserializeObject<Record>(recordData);
                    Console.Write(record.Name);
                    Console.SetCursorPosition(20, Console.CursorTop);
                    Console.Write($"{record.CharactersPerMinute} символов в минуту");
                    Console.SetCursorPosition(50, Console.CursorTop);
                    Console.Write($"{record.CharactersPerSecond} символов в секунду");
                    Console.WriteLine();
                }
            }
        }
    }
}

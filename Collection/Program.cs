using System;
using System.Collections;
using System.Collections.Generic;
using System.Reflection.Metadata;

namespace Collection
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region task1 : Əlaqə Siyahısı
            ////List<T> istifadə edərək obyekt kolleksiyalarını saxlamaq və
            ////manipulyasiya etməyi öyrənmək.

            ////Listi daxil etdim.
            //List<string> Contacts = new List<string>() {"Aishe","Tural","Murad","Gulnare"};
            ////sondan bir ad daxil etdim 
            //Contacts.Add("Musa");
            ////baslangicdaki adi sildi cunki 0ci indexsi vermisdim 
            //Contacts.RemoveAt(0);
            ////morterize daxilinde yazilan ad silmek ucundur
            //Contacts.Remove("Murad");
            ////siralamaga yarayir
            //Contacts.Sort();

            //List<String> Numbers = new List<String>() {"0773324567","0554567809","0507861298"};
            //foreach (string names in Contacts)
            //{
            //    Console.WriteLine(names);
            //    foreach (var nums in Numbers)
            //    {
            //        Console.WriteLine(nums);
            //        break;
            //    }
            //}
            #endregion

            #region task2 : "Söz Tezliyi Sayğacı"
            ////Məqsəd: Dictionary<TKey, TValue> istifadə edərək açar-dəyər cütlərini
            ////saxlamaq və manipulyasiya etməyi öyrənmək.
            //var dictionary = new Dictionary<string, int>();
            //dictionary.Add("Tural", 1);
            //dictionary.TryAdd("Elmir", 2);
            //dictionary.TryAdd("VasmoyMalish", 3);
            ////saygacimiz countdur
            //int count = 0;
            //foreach (var item in dictionary)
            //{
            //    //+  item.Value
            //    Console.WriteLine(item.Key );
            //    count++;
            //    Console.WriteLine(count);
            //}
            #endregion

            #region task3 : "Ləğv et/Geri qaytar Yığını"
            ////Məqsəd: Stack<T> istifadə edərək geri alma / geri qaytarma funksiyasını
            ////həyata keçirməyi öyrənmək.

            //string[] arr = new string[] { "Baki ", "Gence ", "Tovuz " ,"Sumqayit " };
            //Stack<string> myStack = new Stack<string>(arr);

            //string choice = Console.ReadLine();

            //if (choice == "1")
            //{
            //    string el = Console.ReadLine();
            //    myStack.Push(el);
            //    foreach (var item in myStack)
            //    {
            //        Console.Write(item + ",");
            //    }
            //}
            //else if (choice == "2")
            //{
            //    Console.WriteLine("silmek istediyiniz sheheri sechin");
            //    foreach (var item in myStack)
            //    {
            //        Console.Write(item + ",");
            //    }            
            //}
            #endregion

            #region task4 : "Printer Növbəsi"
            ////            Sənədin adı və səhifə sayı üçün xüsusiyyətlərə malik sadə bir
            ////Sənəd sinifini yaradın.Konsol tətbiqində, printer növbəsini təmsil etmək
            ////üçün Queue<Document> istifadə edin.Növbəyədə sənədləri əlavə etmək,
            ////növbədəki növbəti sənədi emal etmək(çap etmək) və cari növbə vəziyyətini
            ////göstərmək funksiyasını həyata keçirin.

            //Queue<string> Documents = new Queue<string>();
            //Documents.Enqueue("butun qruplar siyahisi 2 seyfe");
            //Documents.Enqueue("qayiblar siyaisi 10 seyfe");
            //Documents.Enqueue("gundelik qiymetler 10 seyfe");
            //Documents.Enqueue("kollekvium ballari 3 seyfe");
            //Documents.Enqueue("imtahan cavablari 2 seyfe");

            //Console.WriteLine("sened elave etmek ucun: 1 e basin");
            //Console.WriteLine("senedleri gostermek ucun 2 e basin");
            //Console.WriteLine("senedi silmek ucun 3 e basin");

            //string a = Console.ReadLine();
            //if (a == "1")
            //{
            //    string element = Console.ReadLine();
            //    Documents.Enqueue(element);
            //    foreach (var item in Documents)
            //    {
            //        Console.WriteLine(item);
            //    }
            //}
            //else if (a == "2")
            //{
            //    foreach (var item in Documents)
            //    {
            //        Console.WriteLine(item);
            //    }
            //}
            //else if (a == "3")
            //{
            //    Documents.Dequeue();
            //    foreach (var item in Documents)
            //    {
            //        Console.WriteLine(item);
            //    }
            //}
            #endregion

            #region task5 : "Anbar Sistemi"
            //yaza bilmedim
            #endregion
        }
    }
}

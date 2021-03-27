using System;

namespace MyDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<string, string> myDictionary = new MyDictionary<string, string>();
            myDictionary.Add("Book", "Kitap");
            myDictionary.Add("Table", "Masa");
            myDictionary.Add("Chair", "Sandalye");

            myDictionary.GetList();
        }
    }
}

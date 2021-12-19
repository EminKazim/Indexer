using Indexer.Models;
using System;

namespace Indexer
{
    class Program
    {
        static void Main(string[] args)
        {




            MyList<object> list = new MyList<object>();
            list.Add("Phyton");
            list.Add("Java Sctript");
            list.Add(26);
            list.Add("C#");

            list.AddRange(22);

            //list.Clear(list);


            //list.FindList("C#");



        }
    }
}
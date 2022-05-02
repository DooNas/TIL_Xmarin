using System.Collections;

namespace TestConSole
{
    class Program
    {
        static void Main(string[] args)
        {


            //CollectionStudy();
            #region Study_Collections, Dicitionary, SortedList
            void CollectionStudy()
            {
                ArrayList al = new ArrayList();
                al.Add("첫번째");
                al.Add("두번째");
                al.Add(1);
                al.Add(2);
                Console.WriteLine($"총 갯수 : {al.Count}");
                al.Remove("두번째");
                Console.WriteLine($"총 갯수 : {al.Count}");

                foreach (var item in al) Console.Write(item + "\n");

                Console.WriteLine("--------------스택--------------");
                Stack stack = new Stack();
                stack.Push("1스택");
                stack.Push("2스택");
                stack.Push("1");
                stack.Push("2");
                Console.WriteLine($"총 갯수 : {stack.Count}");
                foreach (var item in stack) Console.Write(item + "\n");

                Console.WriteLine("--------------큐--------------");
                int[] array = { 10, 20, 30, 40, 50, 60, 70 };
                Queue q = new Queue(array);
                foreach (var item in q) Console.Write(item + "\n");


                Console.WriteLine("--------------해쉬--------------");
                Hashtable ht = new Hashtable();
                ht.Add("이름", "핑크퐁");
                ht.Add("주소", "뉴욕");
                ht.Add("나이", 10);
                ht.Add("고향", "한국");
                foreach (var item in ht.Keys) Console.Write($"{item} : {ht[item]}\n");

                Console.WriteLine("--------------딕셔너리--------------");
                Dictionary<string, string> dict = new Dictionary<string, string>();
                dict.Add("이름", "타요타요");
                dict.Add("주소", "시카고");
                dict.Add("나이", "5");
                dict.Add("고향", "한국");
                foreach (var item in dict.Keys) Console.Write($"{item} : {dict[item]}\n");

                Console.WriteLine("--------------솔티드 리스트--------------");
                SortedList sl = new SortedList();
                sl.Add("이름", "뽀로로");
                sl.Add("주소", "런던");
                sl.Add("나이", "7");
                sl.Add("고향", "한국");
                foreach (var item in sl.Keys) Console.Write($"{item} : {sl[item]}\n");
                for (int index = 0; index < sl.Count; index++)
                {
                    Console.WriteLine($"인덱스 : {index}  값 : {sl.GetByIndex(index)}");
                }

                Console.ReadLine();
            }
            #endregion


        }
    }
}
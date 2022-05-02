using System.Collections;

namespace TestConSole
{
    class Program
    {
        #region Study_Lambda_forDelegate
        delegate int Calc(int x, int y);
        delegate void DelegateLambda();
        #endregion


        static void Main(string[] args)
        {

            //LingQStudy();
            #region Study_LingQ
            void LingQStudy()
            {
                ClassForLingQuStudy[] lingQlist =
                {
                    new ClassForLingQuStudy(){name = "핑크퐁", age = 10, address = "시카고"},
                    new ClassForLingQuStudy(){name = "뽀로로", age = 15, address = "뉴욕"},
                    new ClassForLingQuStudy(){name = "손오공", age = 20, address = "한국"},
                    new ClassForLingQuStudy(){name = "강힘찬", age = 50, address = "베를린"}
                };
                Console.WriteLine("ForEach를 통한 배열 출력");
                foreach(var item in lingQlist)
                {
                    if(item.age >= 15)Console.WriteLine($"이름 : {item.name}\t나이 : {item.age}\t주소 : {item.address}\t");
                    
                }
                Console.WriteLine("LingQ를 통한 배열 출력");
                var lingQ = from item in lingQlist where item.age >= 15 select item;
                foreach(var item in lingQ) Console.WriteLine($"이름 : {item.name}\t나이 : {item.age}\t주소 : {item.address}\t");
            }
            #endregion

            //LambdaStudy();
            #region Study_Lambda
            void LambdaStudy()
            {
                Calc cal = (int x, int y) => x + y;
                Console.WriteLine($"람다식 방식 : {cal(5,10)}");

                Calc cal2;
                cal2 = delegate(int x, int y) { return x + y; };
                Console.WriteLine($"익명메소드 방식 : {cal2(5, 10)}");

                DelegateLambda dl = () =>
                {
                    Console.WriteLine("문형식 람다입니다.");
                };
                dl();

            }
            #endregion
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

            }
            #endregion

            Console.ReadLine();
        }
    }
}
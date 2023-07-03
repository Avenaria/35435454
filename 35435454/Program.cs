using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;


namespace _35435454 {
    //{class Student
    //    {
    //        public string name { get; set; }
    //        public string suname { get; set; }
    //        public int id{ get; set; }

    //        public DateTime date { get; set; }
    //        public override string ToString()
    //        {
    //            return $"NAME {name}, Sunamw   {suname},  {id} , data {date}";
    //        }
    //    }
    //    class group
    //    {
    //        public string name { get; set; }
    //        public int id { get; set; }
    //    }
    interface IPropertyChanged
    {
        event PropertyEventHandler PropertyChanged;
    }
    public class ThresholdReachedEventArgs : IPropertyChanged
    // значания при создании события 
{
    public int Threshold { get; set; }
    public DateTime TimeReached { get; set; }

        public event PropertyEventHandler PropertyChanged;
    }
class Counter
{
    public event EventHandler ThresholdReached;

    protected virtual void OnThresholdReached(EventArgs e)
    {
        ThresholdReached?.Invoke(this, e);
    }


}
 public delegate void PropertyEventHandler (object sender, PropertyChangedEventArgs e);


    

    
internal class Program
    {static void c_ThresholdReached(object sender, EventArgs e)
    {
        Console.WriteLine("Порог был достигнут ");
    }

        static void Main(string[] args)
        {// линк запрос
         // результат = from имя_переменной  in источник select имя_пеерменной;


            //int[] arrayint = { 1, 2,24,68, 3,33,36, 4, 5, 6 };
            //IEnumerable<int> ints = from i in arrayint select i;
            // IEnumerable<int> ints = from i in arrayint where i%2==0  select i;
            //IEnumerable<int> ints = from i in arrayint where i % 2 == 0 orderby i select i;
            ///сортировка ^ ascending по возрастанию 
            ///descending по убыванию 
            ///
            //IEnumerable<int> ints = from i in arrayint where i%2==0  select i;
            //IEnumerable<IGrouping<int, int>> ints = from i in arrayint group i by i % 10;
            //group позволяет получить подмножество байт 
            // IEnumerable<int> ints = from i in arrayint where i%2==0  select i;
            // /where  всегда только логическое выражение 
            // into 
            //IEnumerable<IGrouping<int, int>> ints = from i in arrayint group i by i % 10 into 
            //                                        res where res.Count()>1 select res;
            //let новая переменная диапозона в качестве временого хранилища прмежуточных данных 
            //string[] stix = {"у ЛУКОМОРЬЯ дуб зеленый, злотая цепб на дубе том, ",
            //        " И днем, и ночью кот ученый всё ходит по цепии, кругом  "  };
            //IEnumerable<string> str = from p in stix let words = p.Split(" ,.-".ToCharArray()) 
            //                          from w in words
            //                          where w.Length >5 select w;// разбитьна слова
            //// выделить слова больше 5 букв исключая значи припенания
            //foreach(string s in str)
            //{
            //    Console.WriteLine(s);
            //}
            /// join -соеденить эелементы из двух источников элементов данных на основани равенства ключей
            /// 
            // List<group> groups = new List<group>
            //  {
            //      new group { name = " c#", id = 1 },
            //      new group { name =" c++", id = 2 }

            //  };

            // List<Student> S = new List<Student>
            // {
            //     new Student { name ="Ulya ",  suname = " gfjswef", id=2, date = new DateTime(12,05,1992) },
            //     new Student { name ="Artem ",  suname = " gf", id=1, date = new DateTime(18,08,1998) },
            //     new Student { name ="Ivan ",  suname = " gfdawwwww", id=2, date = new DateTime(26,05,1994) },
            //     new Student { name ="Prt ",  suname = " gfdaww78978www", id=2 ,date = new DateTime(12,05,1992) },
            //     new Student { name ="Masha ",  suname = " gfdaww524w", id=1, date = new DateTime(2,12,2000) },
            // };
            //// линк запросы 
            //// var query = S.Where(s => (DateTime.Now - s.date).Days / 365.25 > 30).Select(s => s);

            // var rty = from d in S where d.date ==
            //           (from d2 in S select d2.date).Max()select d;
            // foreach(var i in rty)
            // {
            //     Console.WriteLine(i);
            // } 

            //IEnumerable<Student> S2 = from g in groups
            //                          join st in S
            //         on g.id equals st.id into res
            //                          from r in res
            //                          select r;
            //var ga = from s in S where (DateTime.Now - s.date).Days / 365.25 > 30 select s;
            //foreach (var s in ga)
            //{
            //    Console.WriteLine(s);
            //}
            //foreach (Student s in S)
            //{
            //    Console.WriteLine(s.name);
            //}

            // ананимный тип 
            //
            //foreach (var i in ints)
            //{
            //    Console.WriteLine(i.Key + ": ");
            //    foreach (var j in i)
            //    {
            //        Console.WriteLine(j);
            //    }
            //}
            //foreach (int i in  ints){
            //    Console.WriteLine(i); 
            //}
            //arrayint[2] = 100;

            //foreach (int i in ints)//отложенное выполнение 
            //{
            //    Console.WriteLine(i);
            //}
            // ананимный тип 
            //var worker = new// элементы только для чтения не подерживпют наследования
            //{
            //    Ferstname = " Ivan",
            //    LastName = "Ivanov ",
            //    Salalry = 45684.36
            //};
            //Console.WriteLine(worker.Ferstname);
            //Console.WriteLine(worker.GetHashCode());
            //var qaru = from g in groups
            //           join st in S on g.id equals st.id into 
            //    on 
            // 

            var c = new Counter();
            c.ThresholdReached += c_ThresholdReached;
            
        }
    }
}

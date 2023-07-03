using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//namespace _35435454
//{
//    public class ThresholdReachedEventArgs : EventArgs// значания при создании события 
//    {
//        public int Threshold { get; set; }
//        public DateTime TimeReached { get; set; }
//    }
//    class Counter
//    {
//        public event EventHandler ThresholdReached;

//        protected virtual void OnThresholdReached(EventArgs e)
//        {
//            ThresholdReached?.Invoke(this, e);
//        }

        
//    }
//    class ProgramTwo///обработчика событий с именем 
//    {
//        static void Main()
//        {
//            var c = new Counter();
//            c.ThresholdReached += c_ThresholdReached;

//            // provide remaining implementation for the class
//        }

//        static void c_ThresholdReached(object sender, EventArgs e)
//        {
//            Console.WriteLine("The threshold was reached.");
//        }
//    }
//}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AC__ASS1
{
    internal class Range<T> where T : IComparable<T>
    {
        public Range(T max, T min)
        {               
           this. Max = max;
           this. Min = min;
        }

        public T Max {  get; set; }
        public T Min { get; set; }
        
        public  bool InRange(T Value)
        {
            return Value.CompareTo(Min)>0 && Value.CompareTo(Max)<=0;

        }
        public T Length()
        {
            dynamic minValue = Min;
            dynamic maxValue = Max;
            return maxValue - minValue;
        }

    }
}

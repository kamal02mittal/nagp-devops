using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication2
{
    public class Tutorial
    {
        public String Name;
        public float sum;
        public float count;
        public char size;
        public float value;

        public Tutorial()
        {
            Name = "Hello, This is a demo app";
        }


        public float Mean(int[] arr)
        {
            sum = arr.Sum();
            count = arr.Count();
            value = (sum / count);
            return (float)value;
        }

        public float Median(int[] arr)
        {
            Array.Sort(arr);
            size = (char)arr.Count();
            if (Convert.ToBoolean(size % 2))
            {
                return arr[size / 2];
            }
            else
            {
                return 0;
            }
        }
    }
}
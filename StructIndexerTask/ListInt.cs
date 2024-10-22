using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructIndexerTask
{
    internal class ListInt
    {
        private int[] array;
        public int Length
        {
            get { return array.Length; }


        }
        public int this[int index]
        {
            get
            {
                if (index >= array.Length)
                {
                    return array[array.Length - 1];
                }
                return array[index];

            }
            set
            {
                if (index < array.Length)
                {
                    array[index] = value;
                }
            }
        }
        public ListInt()
        {
            array = new int[Length];
        }

        public ListInt(int length)
        {
            array = new int[length];

        }



        public void Add(int value)
        {
            Array.Resize(ref array, array.Length + 1);
            array[array.Length - 1] = value;
        }

        public void AddRange(params int[] value)
        {
            int[] newarr = new int[array.Length + value.Length];
            for (int i = 0; i < array.Length; i++)
            {
                newarr[i] = array[i];
            }
            for (int i = 0; i < value.Length; i++)
            {
                newarr[array.Length + i] = value[i];
            }

            array = newarr;
        }
        public bool Contains(int value)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (value == array[i])
                {
                    return true;
                }
            }
            return false;
        }

        public void Sum()
        {
            int Sum = 0;
            for (int i = 0; i < array.Length; i++)
            {
                Sum += array[i];
            }
            Console.WriteLine(Sum);

        }

        public void Remove(int value)
        {
            int[] newarr = new int[array.Length - 1];
            int j = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] != value)
                {
                    newarr[j] = array[i]; j++;
                }
            }
            array = newarr;
        }

        //public void RemoveRange(params int[] nums)
        //{
        //    int[] newarr = new int[array.Length - nums.Length];
        //    for (int i = 0; array.Length > i; i++)
        //    {
        //        newarr[i] = array[i];
        //    }
        //    for (int i = 0; i < nums.Length; j++)
        //    {
        //        if (nums[i] != array[i])
        //        {
        //            newarr[i] -= array[i];
        //            break;
        //        }
        //    }

        //    array=newarr;

        //}

        public override string ToString()
        {
            return string.Join(",", array);

        }


    }
}

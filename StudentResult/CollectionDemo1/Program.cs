using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionDemo1
{
    class Program
    {
        static void Main(string[] args)
        {
            IntDynamicArray array = new IntDynamicArray();
            array.Add(10);
            array.Add(20);
            array.Add(30);
            array.Add(40);
            array.Add(10);
            array.Add(20);
            array.Add(30);
            array.Add(40);

            for (int i = 0; i < array.Length; i++)
                Console.WriteLine(array.Get(i));

            Console.ReadKey();
        }
    }

    public class IntDynamicArray
    {
        public int Length = 0;
        public int index = 0;        
        public int Capacity;        
        public int[] arr;

        public IntDynamicArray()
        {
            this.Length = 0;
            this.arr = new int[4];
        }

        public void Add(int v)
        {
            if(index < this.Capacity)
                this.arr[index] = v;            
            else
            {
                //this.Capacity = Length * 2;
                //int[] arr2 = new int[this.Capacity];
                //Array.Copy(this.arr, arr2, this.Length);                    
                //arr2[index] = v;
                //arr = arr2;

                Array.Resize(ref this.arr, this.arr.Length * 2);
                arr[index] = v;
            }
            index++;
            Length++;
        }

        public int Get(int v)
        {
            return this.arr[v];
        }
    }
}

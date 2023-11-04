using System;

namespace ConsoleApp7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DA2 array = new DA2(5);
            Console.WriteLine(array.a.Length);
            Console.WriteLine(array.Lastindexitem);
            array.add(1);
            array.add(2);
            array.add(3);
            array.add(4);
            Console.WriteLine(array.a.Length);
            Console.WriteLine(array.Storagelenght());
            Console.WriteLine("####################################");
            array.print();
        }
    }

    class DA2
    {
        public int[] a;
        public int Lastindexitem;
        public DA2(int size)
        {
            a = new int[size];
            Lastindexitem = -1;
        }
        public int this[int index]
        {
            get
            {
                if (index < 0 || index > Lastindexitem)
                {
                    throw new Exception("error");

                }
                else
                    return a[index];

            }
            set
            {

                if (index < 0 || index > Lastindexitem)

                {

                    throw new Exception("error");

                }
                else
                    a[index] = value;

            }
        }
        public void print()
        {
            for (int i = 0; i <= Lastindexitem; i++)
            {
                Console.WriteLine(a[i]);
            }
        }
        public int find(int item)
        {
            for

            (int i = 0; i <= Lastindexitem; i++)
            {

                if (a[i] == item)

                {

                    return i;

                }
            }
            return -1;

        }
        public void add(int item)
        {
            if (Lastindexitem == a.Length - 1)
            {
                expadstorage();
            }

            Lastindexitem++;
            a[Lastindexitem] = item;
        }
        public void expadstorage()
        {
            int[] newa = new int[a.Length + 1];
            Array.Copy(a, newa, a.Length);
            a = newa;
        }

        public int lenght()
        {
            return Lastindexitem + 1;
        }

        public int Storagelenght()
        {
            return a.Length;
        }
        public void insert(int index, int item)
        {
            if (index < 0 || index > Lastindexitem)
            {
                throw new Exception("error");
            }
            if (Lastindexitem == a.Length - 1)
            {
                expadstorage();
            }
            int segl = Lastindexitem - index + 1;
            Array.Copy(a, index, a, index + 1, segl);
            Lastindexitem++;
            a[index] = item;
        }
    }
}

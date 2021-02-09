using System;
using System.Collections.Generic;

namespace generation
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> sehirler = new List<string>();
            sehirler.Add("kayseri");
            sehirler.Add("izmir");
            Console.WriteLine(sehirler.Count); // kaç tane sehir varsa onun eleman sayısını verir

            

            MyList<int> numbers = new MyList<int>();
            numbers.Add(2 );
            numbers.Add(4);
            numbers.Add(6);
            
            Console.WriteLine(numbers.count+"??????");// elemena sayısı 0




        }

    }
    class MyList<T> //GENERİC CLASS t  tiplerin int string gibi olmasını saglar 
    {

        T[] _array;
        T[] _tempArray;
        public MyList()
        {
            _array = new T[0]; // yeni array olusturarak  
        }

        public void Add(T item)
        {
            _tempArray = _array; //eski veriler kaybolasın diye onları temp array adlı diziye aktardım , verileri tutuması için verdim
            _array = new T[_array.Length+1]; // dizi uzunlugunu artırdım 
            for (int i = 0; i < _tempArray.Length; i++)
            {
                _array[i] = _tempArray[i]; // elemanları tututugu diziden alıp teker teker attadım
            }
            _array[_array.Length-1]= item;

        }
        

        public int  count
        {
            get { return _array.Length; }
            
        }

    }

}

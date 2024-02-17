using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Workaround
{
	public class MyList<T>
	{
		private T[] items;
		private int count;
		public MyList() 
		{
			items = new T[4]; //Başlangıç array kapasitesi
			count = 0; //Eleman sayısı
		}

        public int Count 
		{ 
			get { return count; } 
		}

        public T this[int index]
		{
			get 
			{ 
				if (index < 0 || index >= count)
					throw new ArgumentOutOfRangeException();
				return items[index]; 
			}
			set 
			{
				if (index < 0 || index >= count)
					throw new ArgumentOutOfRangeException();
				items[index] = value; 
			}
		}

        public void Add(T item)
		{
			if (count == items.Length)  //Kapasite dolduysa kapasiteyi arttır.
			{
				Array.Resize(ref items, items.Length * 2); 
			}

			items[count] = item;
			count++;
		}
	}
}

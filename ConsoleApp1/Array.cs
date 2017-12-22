using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApp1
{
    public class Array
    {
        public int[] _Array;
        
        public int degree;
        public Array()
        {
            degree = 2;
            _size= 0;
            _Array = new int[_size];
        }
        public Array(int size,int _degree)
        {
            _size = size;
            _Array = new int[_size];
            degree = _degree;
        }
        public int _size { get; set; }
        public int this[int i]
        {
            get
            {
                return _Array[i];
            }
            set
            {
                _Array[i] = (int)Math.Pow((double)value, degree);
            }
            
          
        }
    }
}

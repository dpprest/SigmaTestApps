using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SigmaTestApp1
{
    public class MyArrayList<T>
    {
        private const int DefaultCapacity = 4;
        private T[] _items;
        private int _size;
        private int _capacity;

        public MyArrayList()
        {
            _items = new T[_capacity];
            _size = 0;

        }
        public MyArrayList(int capacity)
        {
            if (capacity < 0)
            {
                throw new ArgumentOutOfRangeException(nameof(capacity), " Емкость не может быть отрицательной. ");
            }
            _items = capacity == 0 ? new T[_capacity] : new T[capacity];
            _size = 0;
        }
        public int Count => _size;

        public int Capacity
        {
            get => _items.Length;
            set
            {
            
              if (value != _items.Length)
              {
                 if (value > 0)
                    {
                    T[] newItems = new T[value];
                    if (_size > 0)
                    {
                        Array.Copy(_items, newItems, _size);
                    }
                    _items = newItems;
                 }
                 else
                 {
                    _items = new T[DefaultCapacity];
                 }
              } 
        }
    }


        public T this[int index]
        {
            get
            {
                if (index < 0 || index >= _size)
                    throw new ArgumentOutOfRangeException(nameof(index));
                return _items[index];
            }
            set
            {
                if (index < 0 || index >= _size)
                    throw new ArgumentOutOfRangeException(nameof(index));
                _items[index] = value;
            }
        }
        public void Add(T item)
        {
            if (_size == _items.Length)
            {
                EnsureCapacity(_size + 1);
            }
            _items[_size++] = item;
        }
        public void Insert(int index, T item)
        {
            if (index < 0 || index > _size)
                throw new ArgumentOutOfRangeException(nameof(index));

            if (_size == _items.Length)
                EnsureCapacity(_size + 1);

            if (index < _size)
                Array.Copy(_items, index, _items, index + 1, _size - index);

            _items[index] = item;
            _size++;
        }
        public bool Remove(T item)
        {
            int index = IndexOf(item);
            if (index >= 0)
            {
                RemoveAt(index);
                return true;
            }
            return false;
        }
        public void RemoveAt(int index)
        {
            if (index < 0 || index >= _size)
            {
                throw new ArgumentOutOfRangeException(nameof(index));
            }
            _size--;
            if (index < _size)
            {
                //сдвигаем влево для заполнения пустоты
                Array.Copy(_items, index + 1, _items, index, _size - index);
            }
            _items[_size] = default; //обнуляем последний элемент
        }

        public void Clear()
        {
            if (_size > 0)
            {
                Array.Clear(_items, 0, _size);
                _size = 0;
            }
        }
        public bool Contains(T item)
        {
            return IndexOf(item) >= 0;
        }

        public int IndexOf(T item)
        {
            return Array.IndexOf(_items, item, 0, _size);
        }
        private void EnsureCapacity(int min)
        {
            if (_items.Length < min)
            {
                int newCapacity = _items.Length == 0 ? DefaultCapacity : _items.Length * 2;
                if (newCapacity < min) newCapacity = min;
                Capacity = newCapacity;
            }
        }
        public T[] ToArray()
        {
            T[] array = new T[_size];
            Array.Copy(_items, array, _size);
            return array;
        }


    }
}

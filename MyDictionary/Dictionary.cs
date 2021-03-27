using System;
using System.Collections.Generic;
using System.Text;

namespace MyDictionary
{
    class MyDictionary<Key, Value>
    {
        Key[] _key;
        Value[] _value;
        public MyDictionary()
        {
            _key = new Key[0];
            _value = new Value[0];
        }
        public void Add(Key key, Value value)
        {
            Key[] tempKey = _key;
            Value[] tempValue = _value;
            _key = new Key[_key.Length + 1];
            _value = new Value[_value.Length + 1];

            for (int i = 0; i < tempKey.Length; i++)
            {
                _key[i] = tempKey[i];
                _value[i] = tempValue[i];
            }
            _key[_key.Length - 1] = key;
            _value[_value.Length - 1] = value;
        }

        public void GetList()
        {
            for (int i = 0; i < _key.Length; i++)
            {
                Console.WriteLine(_key[i] + " : " + _value[i]);
            }
        }
    }
}

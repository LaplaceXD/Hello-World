using System;
using System.Collections.Generic;

namespace HelloWorld.Exercises
{
    public class Stack
    {
        private int _popCounter = 0;
        private readonly List<object> _objectList = new List<object>();
        public void Push(object obj)
        {
            if (obj == null)
                throw new InvalidOperationException("Can't store null objects.");

            _objectList.Add(obj);
        }

        public object Pop()
        {
            if (_objectList.Count == 0)
                throw new InvalidOperationException("Object list is empty.");

            _popCounter++;
            
            if (_objectList.Count < _popCounter)
                throw new InvalidOperationException("Object list is empty");

            return _objectList[_objectList.Count - _popCounter];
        }

        public void Clear()
        {
            _popCounter = 0;
            _objectList.Clear();
        }

    }
}
using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FizzBuzz.Test
{
    [TestClass]
    public class StackKataTests
    {
        //implementing basic stack
        //pop items off returns item
        //push items on and get lifo order
        //if empty dont throw exception when you pop
        //cant push invalid value onto stack


        [TestMethod]
        public void Can_pop_items_off()
        {
            var stack = new MyStack();
            stack.Push("Foo");
            var result = stack.Pop();
            Assert.AreEqual("Foo", result);

        }

        [TestMethod]
        public void Pushing_items_and_Popping_results_in_LIFO_action()
        {
            var stack = new MyStack();
            stack.Push("1");
            stack.Push("2");
            stack.Push("3");

            var result1 = stack.Pop();
            var result2 = stack.Pop();
            var result3 = stack.Pop();

            Assert.AreEqual("3", result1);
            Assert.AreEqual("2", result2);
            Assert.AreEqual("1", result3);
        }

        [TestMethod]
        public void Popping_from_empty_stack_doesnt_throw_exception()
        {
            var stack = new MyStack();
           var result= stack.Pop();
            Assert.IsNull(result);

        }

        [TestMethod]
        public void Pushing_invalid_value_throws_error()
        {
            var stack = new MyStack();
            Assert.ThrowsException<ArgumentException>(() => stack.Push(null));
        }
    }

    public class MyStack
    {
        string[] _array;
        int _index = -1;



        public MyStack()
        {
            _array = new string[2];
        }

        int StackCapacity => _array.Length;

        public void Push(string value)
        {
            if (value == null || value.GetType() != typeof(string))
                throw new ArgumentException("value must be of type string and not null.");
            CheckResize();
            _array[++_index] = value;
        }

        public string Pop()
        {
            if (_index == -1)
                return null;
            else
            {
                var result = _array[_index--];
                return result;
            }
        }
 
        private void CheckResize()
        {
            if (_index % StackCapacity == 0)
            {
                Array.Resize(ref _array, StackCapacity * 2);
            }
        }
    }
}

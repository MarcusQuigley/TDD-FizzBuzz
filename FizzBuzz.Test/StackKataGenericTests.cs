using System;
using System.Linq;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using FizzBuzz;

[TestClass]
public class StackKataGenericTests
{
    [TestMethod]
    public void Put_ints_into_stack()
    {
        var stack = new MyStack<int>();
        stack.Push(1);
        var result = stack.Pop();
        Assert.AreEqual(1, result);
        Assert.IsInstanceOfType(result, typeof(int));


    }

    [TestMethod]
    public void Put_doubles_into_stack()
    {
        var stack = new MyStack<double>();
        stack.Push(1.0);
        var result = stack.Pop();
        Assert.AreEqual(1.0, result);
        Assert.IsInstanceOfType(result, typeof(double));
    }
}

 
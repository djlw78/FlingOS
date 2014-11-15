﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kernel.FOS_System.Collections
{
    /// <summary>
    /// Represents a weakly typed stack of objects (which must be derived from FOS_System.Object) that can be accessed by 
    /// pushing and popping only. Provides methods to manipulate stacks.
    /// </summary>
    /// <remarks>
    /// The job of knowing which type of object is contained within the list is left to the developer. This is a 
    /// significant issue but one which we can't solve yet since generics aren't supported properly yet.
    /// </remarks>
    public class Stack : FOS_System.Object
    {
        //Note: For the sake of simplicity, this stack class simply reuses the List class internally

        /// <summary>
        /// The internal list that actually stores the items.
        /// </summary>
        private List internalList;

        /// <summary>
        /// Creates a new stack with initial capacity of 5.
        /// </summary>
        [Compiler.NoDebug]
        public Stack()
            : this(5)
        {
        }
        /// <summary>
        /// Creates a new stack with specified initial capacity. Use this to optimise memory usage.
        /// </summary>
        /// <param name="capacity">The initial capacity of the list.</param>
        [Compiler.NoDebug]
        public Stack(int capacity)
        {
            internalList = new List(capacity);
        }

        /// <summary>
        /// Pushes the specified object onto the stack.
        /// </summary>
        /// <param name="obj">The object to push.</param>
        public void Push(FOS_System.Object obj)
        {
            internalList.Add(obj);
        }
        /// <summary>
        /// Pops an item off the stack. If the stack is empty, it returns null.
        /// </summary>
        /// <returns>The popped item or null if the stack is empty.</returns>
        public FOS_System.Object Pop()
        {
            int lastIndex = internalList.Count - 1;

            if (lastIndex < 0)
            {
                return null;
            }

            FOS_System.Object result = internalList[lastIndex];
            internalList.RemoveAt(lastIndex);
            return result;
        }
    }

    //These stack class implementations work exactly the same as the 
    //  original except that:
    //  a) They are for specific value-types
    //  b) Not all methods have been ported from Stack

    /// <summary>
    /// Represents a strongly typed stack of UInt32s that can be accessed by 
    /// pushing and popping only. Provides methods to manipulate stacks.
    /// </summary>
    public class UInt32Stack : FOS_System.Object
    {
        //Note: For the sake of simplicity, this stack class simply reuses the List class internally

        /// <summary>
        /// The internal list that actually stores the items.
        /// </summary>
        private UInt32List internalList;

        /// <summary>
        /// Creates a new stack with initial capacity of 5.
        /// </summary>
        [Compiler.NoDebug]
        public UInt32Stack()
            : this(5)
        {
        }
        /// <summary>
        /// Creates a new stack with specified initial capacity. Use this to optimise memory usage.
        /// </summary>
        /// <param name="capacity">The initial capacity of the list.</param>
        [Compiler.NoDebug]
        public UInt32Stack(int capacity)
        {
            internalList = new UInt32List(capacity);
        }

        /// <summary>
        /// Pushes the specified object onto the stack.
        /// </summary>
        /// <param name="obj">The object to push.</param>
        public void Push(System.UInt32 obj)
        {
            internalList.Add(obj);
        }
        /// <summary>
        /// Pops an item off the stack. If the stack is empty, it returns UInt32.MaxValue.
        /// </summary>
        /// <returns>The popped item or UInt32.MaxValue if the stack is empty.</returns>
        public System.UInt32 Pop()
        {
            int lastIndex = internalList.Count - 1;

            if (lastIndex < 0)
            {
                return FOS_System.UInt32.MaxValue;
            }

            System.UInt32 result = internalList[lastIndex];
            internalList.RemoveAt(lastIndex);
            return result;
        }
    }
}

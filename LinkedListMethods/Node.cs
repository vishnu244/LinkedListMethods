﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListMethods
{
    public class Node
    {
        public int data;
        public Node next;

        public Node(int x)
        {
            data = x;
            next = null;
        }
    }
}

﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reto1
{
    internal class Node
    {
        public String data;
        public Node next;
        public Node previous;

        public Node(String data)
        {
            this.data = data;
        }
    }
}

using System.Collections.ObjectModel;
using System.Collections.Generic;
using System;

namespace Library
{
    public class Node<T> :INode
    {
        public T t{get;set;}

        private List<Node<T>> children = new List<Node<T>>();


        public ReadOnlyCollection<Node<T>> Children { 
            get
            {
                return this.children.AsReadOnly();
            }
        }

        public Node(T t)
        {   
            this.t=t;
        }
        public void AddChildren(Node<T> n)
        {
            this.children.Add(n);
        }
        public void Accept(Visitor<T> visitor)
        {
            visitor.Visit(this);
        }
        
    }
}

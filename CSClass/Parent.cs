﻿using System;

namespace CSClass
{
    internal class Parent
    {
        public int variable = 273;

        public void Method()
        {
            Console.WriteLine("부모의 메서드");
        }

        public Parent()
        {
            Console.WriteLine("Parent()");
        }

        public Parent(int param)
        {
            Console.WriteLine("Parent(int param)");
        }

        public Parent(string param)
        {
            Console.WriteLine("Parent(string param)");
        }

    }
}
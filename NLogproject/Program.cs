using System;

namespace NLogproject
{
    public class Program
    {
        static void Main(string[] args)
        {
            AddNumbers add = new AddNumbers();
            add.Sum(12, 23);
        }
    }
}
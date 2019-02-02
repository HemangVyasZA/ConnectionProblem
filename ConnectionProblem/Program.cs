using System;

namespace ConnectionProblem
{
    class Program
    {
        static void Main(string[] args)
        {
            //QuickFindDemo();
            QuickUnionDemo();

            Console.ReadLine();
        }

        private static void QuickFindDemo()
        {
            ConnectivityUsingQuickFind connectivityUsingQuickFind = new ConnectivityUsingQuickFind(10);
            connectivityUsingQuickFind.ConnectElements(4, 3);
            connectivityUsingQuickFind.ConnectElements(3, 8);
            connectivityUsingQuickFind.ConnectElements(6, 5);
            connectivityUsingQuickFind.ConnectElements(9, 4);
            connectivityUsingQuickFind.ConnectElements(2, 1);
            connectivityUsingQuickFind.ConnectElements(8, 9);
            connectivityUsingQuickFind.ConnectElements(5, 0);
            connectivityUsingQuickFind.ConnectElements(7, 2);
            connectivityUsingQuickFind.ConnectElements(6, 1);

            Console.WriteLine($" are 8 and 9 connected? {connectivityUsingQuickFind.IsConnected(8, 9)}");
            Console.WriteLine($" are 2 and 3 connected? {connectivityUsingQuickFind.IsConnected(2, 3)}");
            Console.WriteLine($" are 6 and 5 connected? {connectivityUsingQuickFind.IsConnected(6, 5)}");
            Console.WriteLine($" are 7 and 8 connected? {connectivityUsingQuickFind.IsConnected(7, 8)}");
        }

        private static void QuickUnionDemo()
        {
            ConnectivityUsingQuickUnion connectivityUsingQuickUnion = new ConnectivityUsingQuickUnion(10);
            connectivityUsingQuickUnion.ConnectElements(4, 3);
            connectivityUsingQuickUnion.ConnectElements(3, 8);
            connectivityUsingQuickUnion.ConnectElements(6, 5);
            connectivityUsingQuickUnion.ConnectElements(9, 4);
            connectivityUsingQuickUnion.ConnectElements(2, 1);
            connectivityUsingQuickUnion.ConnectElements(5, 0);
            connectivityUsingQuickUnion.ConnectElements(7, 2);
            connectivityUsingQuickUnion.ConnectElements(6, 1);

            Console.WriteLine($"Are 4 and 8 connected? {connectivityUsingQuickUnion.AreElementsConnected(4, 8)}");
            Console.WriteLine($"Are 2 and 3 connected? {connectivityUsingQuickUnion.AreElementsConnected(2, 3)}");
            Console.WriteLine($"Are 5 and 7 connected? {connectivityUsingQuickUnion.AreElementsConnected(5, 7)}");
            Console.WriteLine($"Are 6 and 9 connected? {connectivityUsingQuickUnion.AreElementsConnected(6, 9)}");



        }
    }
}

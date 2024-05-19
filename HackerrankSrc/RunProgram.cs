using System;

namespace Rackerrank
{
    public class RunProgram
    {
        static void Main(string[] args)
        {
            /*
            RegularExpresionMatch r = new RegularExpresionMatch();
            Console.WriteLine( r.IsMatch("aa", "a"));
            */

            /*
            FirstMissingPositiveNumber r = new FirstMissingPositiveNumber();

            var res = r.FirstMissingPositive(new int[] { 2147483646  }); //1, 2, 0
            */

            /*
            AddTwoNumberLC addTwoNumberLC = new AddTwoNumberLC();

            var l1 = new AddTwoNumberLC.ListNode() { val = 9 };
            l1.next = new AddTwoNumberLC.ListNode() { val = 9 };
            l1.next.next = new AddTwoNumberLC.ListNode() { val = 9 };

            var l2 = new AddTwoNumberLC.ListNode() { val = 9 };

            var res = addTwoNumberLC.AddTwoNumbers(l1, l2);
            */

            /*
            TreeMaxDepthLC treeMaxDepthLC = new TreeMaxDepthLC();

            var root = new TreeMaxDepthLC.TreeNode() { val = 3};
            var t1 = new TreeMaxDepthLC.TreeNode() { val = 9 };
            root.left = t1;

            var t2 = new TreeMaxDepthLC.TreeNode() { val = 20 };
            root.right = t2;

            var t3 = new TreeMaxDepthLC.TreeNode() { val = 15 };
            t2.left = t3;

            var t4 = new TreeMaxDepthLC.TreeNode() { val = 7 };
            t2.right = t4;

            var res = treeMaxDepthLC.MaxDepth(root);
            */

            /*

            ConvertIntToExcelTitleLC convertIntToExcelTitleLC = new ConvertIntToExcelTitleLC();

            Console.WriteLine(convertIntToExcelTitleLC.ConvertToTitle(1));
            Console.WriteLine(convertIntToExcelTitleLC.ConvertToTitle(25));
            Console.WriteLine(convertIntToExcelTitleLC.ConvertToTitle(26));
            Console.WriteLine(convertIntToExcelTitleLC.ConvertToTitle(27));
            Console.WriteLine(convertIntToExcelTitleLC.ConvertToTitle(701));
            Console.WriteLine(convertIntToExcelTitleLC.ConvertToTitle(702));

            Console.WriteLine(convertIntToExcelTitleLC.ConvertToTitle(75000));
            */

            /*
            convertNumberBase1 convertNumberBase1 = new convertNumberBase1();
            
            Console.WriteLine(convertNumberBase1.ConvertHex(9));
            Console.WriteLine(convertNumberBase1.ConvertHex(10));
            Console.WriteLine(convertNumberBase1.ConvertHex(15));
            Console.WriteLine(convertNumberBase1.ConvertHex(16));
            Console.WriteLine(convertNumberBase1.ConvertHex(100));
            */

            /*
            BubbleSort bubbleSort = new BubbleSort();
            bubbleSort.Sort(new int[] { 500, -500 , 25000, 0 , 5 });
            */

            /*
            SelectionSort selectionSort = new SelectionSort();
            selectionSort.Sort(new int[] { 10,9,8,7,6,5,100 });
            */

            /*
            MergeSort mergeSort = new MergeSort();
            var nums = new int[] { 10, 9, -8, 7, 0, 5, 100 };
            mergeSort.Sort(nums, 0, nums.Length-1);

            for (int i = 0; i < nums.Length; i++)
            {
                Console.Write(" " + nums[i]);
            }
            */

            /*
            ConfusingNumber confusingNumber = new ConfusingNumber();
            //confusingNumber.GetCount(100);
            var p = confusingNumber.Get180DegreeRotatedNumber(10);
            */

            /*
            MaximalSquareDP maximalSquareDP = new MaximalSquareDP();

            int[][] arr
        = new int[][] {     new int[] { 1, 1, 0, 1 },
                            new int[] { 0, 1, 1, 1 },
                            new int[] { 1, 1, 1, 1 },
                            new int[] { 1, 1, 1, 1 }
        };

            
            Console.WriteLine("Longest Increasing subsequence");
            var result = maximalSquareDP.MS(arr, 0, 0);

            */

            /*

            PostfixExpressionEvaluation postfixExpressionEvaluation = new PostfixExpressionEvaluation();
            Console.WriteLine(postfixExpressionEvaluation.PostfixEvaluation("12 10 * 12 / ?"));
            */

            /*

            int[][] m
        = new int[][] {     new int[] { 1, 2, 3 },
                            new int[] { 10, 11, 4 },
                            new int[] { 9, 12, 5 },
                            new int[] { 8, 7, 6 }
        };

            ShowMatrixInSpiralOrder spiral = new ShowMatrixInSpiralOrder();
            spiral.SpiralTravel(m);

            */

            /*
            NumberOfIslands numberOfIslands = new NumberOfIslands();
            int[][] m
                    = new int[][] {
                            new int[] { 1, 0, 1, 0 },
                            new int[] { 1, 0, 0, 1 },
                            new int[] { 0, 1, 0, 0 },
                            new int[] { 0, 0, 1, 1 }
                    };
            int[][] m2
                    = new int[][] {
                            new int[] { 1, 0, 1 },
                            new int[] { 0, 1, 0 }
                    };
            //numberOfIslands.CountNumberOfIslands(m);
            numberOfIslands.CountNumberOfIslands(m2);

            */
            /*
            CheckBalancedParenthesisExpression chk = new CheckBalancedParenthesisExpression();
            chk.CheckBalanced("(()({}[{}]))");
            chk.CheckBalanced("(()({}[{}]))[");

            */

            /*
            LongestValidParenthesis longest = new LongestValidParenthesis();
            longest.CheckLongest("(");
            */

            /*
             * The other question was with the Least significant number at the beginning, but here it is at the end
             * So need to reverse the list to use the existing solution
             */

            /*
            AddTwoNumberMostSignnificatnInTheBeginning addTwoNumberLC = new AddTwoNumberMostSignnificatnInTheBeginning();

            var l1 = new AddTwoNumberLC.ListNode() { val = 7 };
            l1.next = new AddTwoNumberLC.ListNode() { val = 2 };
            l1.next.next = new AddTwoNumberLC.ListNode() { val = 4 };
            l1.next.next.next = new AddTwoNumberLC.ListNode() { val = 3 };

            var l2 = new AddTwoNumberLC.ListNode() { val = 5 };
            l2.next = new AddTwoNumberLC.ListNode() { val = 6 };
            l2.next.next = new AddTwoNumberLC.ListNode() { val = 4 };

            l1 = addTwoNumberLC.Reverse(l1);
            l2 = addTwoNumberLC.Reverse(l2);
            var res = addTwoNumberLC.AddTwoNumbers(l1, l2);

            res = addTwoNumberLC.Reverse(res);
            */

            /*
            MergeTwoArray mergeTwoArray = new MergeTwoArray();
            var n1 = new int[] { 1, 2, 3, 9 };
            var n2 = new int[] { 2,5,6, 100, 200 };
            mergeTwoArray.Merge(n1, n2);

            */

            /*
            MaximumConsecutiveSubarrySumK maxk = new MaximumConsecutiveSubarrySumK();
            maxk.SubarrySum(2, new int[] { 2, 3, 4, 1, 5 });

            */

            /*

            FindTheMissingNumber missingNumber = new FindTheMissingNumber();
            missingNumber.MissingNumber(new int[] { 7, 3, 5, 2, 4, 6, 0, 1 });
            */

            /*

            ComplementBase10Number complementBase10 = new ComplementBase10Number();
            complementBase10.CalculateComplement(256);

            */

            /*
            ListNode listNode = new ListNode(5);
            listNode.next = new ListNode(4);
            listNode.next.next = new ListNode(3);
            listNode.next.next.next = new ListNode(2);
            listNode.next.next.next.next = new ListNode(1);

            LinkedListOperations op = new LinkedListOperations();
            op.Print(listNode);

            listNode = op.Reverse(listNode);
            op.Print(listNode);

            //listNode = op.RemoveItemAt(listNode, 5);

            ////listNode = op.InsertItemAt(listNode, 0,  100);
            ////listNode = op.InsertItemAt(listNode, 3, 200);
            //listNode = op.InsertItemAt(listNode, 8, 300);

            listNode = op.InsertItemAt(listNode, 20, 300);

            op.Print(listNode);
            */


            //GraphOperation go = new GraphOperation();

            /*
            Vertex v1 = new Vertex(0, new List<Edge>() { new Edge(1, 1)});
            Vertex v2 = new Vertex(1, new List<Edge>() { new Edge(2, 1), new Edge(3, 1) });
            Vertex v3 = new Vertex(2, new List<Edge>() { new Edge(3, 1) });
            Vertex v4 = new Vertex(3, new List<Edge>() { new Edge(0, 1) }) ;
            */

            /*
            Vertex v0 = new Vertex(0, new List<Edge>() { new Edge(1) });
            Vertex v1 = new Vertex(1, new List<Edge>() { new Edge(2) });
            Vertex v2 = new Vertex(2, new List<Edge>() { new Edge(3) });
            Vertex v3 = new Vertex(3, new List<Edge>() { new Edge(8) });

            Vertex v4 = new Vertex(4, new List<Edge>() { new Edge(5) });
            Vertex v5 = new Vertex(5, new List<Edge>() { new Edge(6) });
            Vertex v6 = new Vertex(6, new List<Edge>() { new Edge(4) });

            Vertex v7 = new Vertex(7, new List<Edge>() { new Edge(8) });
            Vertex v8 = new Vertex(8, new List<Edge>() { new Edge(9) });
            Vertex v9 = new Vertex(9, new List<Edge>() { new Edge(3) });

            List<Vertex> vertices = new List<Vertex>() { v0, v1, v2, v3, v4, v5, v6, v7 , v8, v9 };

            go.DFSCycleDetection(vertices.ToArray());

            go.PrintCycle(vertices.ToArray());
            */

            BitwiseOperation bo = new BitwiseOperation();
            //Console.WriteLine(bo.LeftShift(4,1));

            //Console.WriteLine(bo.RightShift(64, 8));

            /*
            Console.WriteLine(bo.IsPowerOfTwo(0));
            Console.WriteLine(bo.IsPowerOfTwo(1));
            Console.WriteLine(bo.IsPowerOfTwo(2));
            Console.WriteLine(bo.IsPowerOfTwo(3));
            Console.WriteLine(bo.IsPowerOfTwo(128));
            Console.WriteLine(bo.IsPowerOfTwo(129));
            */

            /*
            StackUsingQueue stackWithQueue = new StackUsingQueue();
            stackWithQueue.Push('c');
            stackWithQueue.Push('b');
            stackWithQueue.Pop();
            stackWithQueue.Push('q');
            stackWithQueue.Push('a');

            Console.WriteLine(stackWithQueue.Pop());
            Console.WriteLine(stackWithQueue.Pop());
            Console.WriteLine(stackWithQueue.Pop());
            */

            /*
            QueueUsingStack queueWithStack = new QueueUsingStack();
            queueWithStack.Enque('a');
            queueWithStack.Enque('b');
            queueWithStack.Enque('c');
            queueWithStack.Enque('d');
            queueWithStack.Enque('e');

            Console.WriteLine(queueWithStack.Dequeue());
            Console.WriteLine(queueWithStack.Dequeue());
            Console.WriteLine(queueWithStack.Dequeue());
            Console.WriteLine(queueWithStack.Dequeue());
            Console.WriteLine(queueWithStack.Dequeue());
            */

            /*
            ComplementBase10Number complement = new ComplementBase10Number();
            Console.WriteLine(complement.CalculateComplement(8));
            Console.WriteLine(complement.CalculateComplement(10));
            Console.WriteLine(complement.CalculateComplement(6));
            */

            Console.ReadKey();
        }
    }
}

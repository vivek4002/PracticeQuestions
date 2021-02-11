using System;
using System.Collections.Generic;
using System.Linq;

namespace TowerOfHanoi {
    class Program {
        static void Main (string[] args) {
            Stack<int> source = new Stack<int> ();
            Stack<int> aux = new Stack<int> ();
            Stack<int> des = new Stack<int> ();
            int disks = 3;
            for (int i = disks; i >= 1; i--) {
                source.Push (i);
            }
            MoveDisks (disks, source, aux, des);
            var count = des.Count;
            for (int i = 0; i < count; i++) {
                Console.WriteLine (des.Pop () + " ");
            }

        }

        // move n-1 disks from source to aux using des(recursively)
        // move nth disk from source to des 
        // move n-1 disks from aux to des using source (recursively)
        // Just for visualization I have used stack so that we can check all the disks 
        // have been moved in correct order.. otherwise we can also use char or int
        static void MoveDisks (int disks, Stack<int> source, Stack<int> aux, Stack<int> des) {
            if (disks == 1) {
                var item = source.Pop ();
                des.Push (item);
                Console.WriteLine ($"moving disk {item} from {nameof(source)} to {nameof(des)}");
                return;
            }
            MoveDisks (disks - 1, source, des, aux);
            MoveDisks (1, source, aux, des);
            MoveDisks (disks - 1, aux, source, des);

        }


    }
}
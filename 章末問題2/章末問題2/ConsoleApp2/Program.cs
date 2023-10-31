using System;

namespace ConsoleApp2 {
    class Program {

        /// <summary>
        /// 正の整数を入力として受け取り、横向きの三角形を描画します。
        /// </summary>

        public static void DrawTriangle(int vSize) {
            if (vSize <= 0) {
                Console.WriteLine("正の整数を入力してください。");
                return;
            }

            for (int wI = 1; wI <= vSize; wI++) {
                for (int wJ = 1; wJ <= wI; wJ++) {
                    Console.Write("*");
                }
                Console.WriteLine();
            }

            for (int wI = vSize - 1; wI >= 1; wI--) {
                for (int wJ = 1; wJ <= wI; wJ++) {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }

        static void Main(string[] args) {
            int input = 4;
            DrawTriangle(input);
        }
    }
}

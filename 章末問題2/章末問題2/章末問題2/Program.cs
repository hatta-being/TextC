using System;

namespace Practice2_1_1 {
    class Program {
        static string ClassifyInteger(int vNumber) {
            if (vNumber == 0) {
                return "0";
            } else if (vNumber > 0) {
                if (vNumber % 2 == 0) {
                    return "正の偶数";
                } else {
                    return "正の奇数";
                }
            } else {
                if (vNumber % 2 == 0) {
                    return "負の偶数";
                } else {
                    return "負の奇数";
                }
            }
        }

        static void Main(string[] args) {
            int inputNumber = -40; // テスト用の整数値
            string result = ClassifyInteger(inputNumber);
            Console.WriteLine(result);
        }
    }
}


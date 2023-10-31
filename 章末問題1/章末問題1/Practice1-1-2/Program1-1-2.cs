using System;

namespace Practice1_1_2 {
        /*
    問題1.1
    2.どら焼きオブジェクトの消費税額を求め、コンソールに出力するコードを書いてください。
    */

    class Program {
        static void Main(string[] args) {
            Product wDorayaki = new Product(98, "どら焼き", 210);
            int wTaxAmount = wDorayaki.GetTax();
            Console.WriteLine("どら焼きの消費税は" + wTaxAmount + "円");
        }
    }
}

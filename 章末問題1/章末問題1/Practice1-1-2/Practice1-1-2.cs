using Practice1_1_2;
using System;

namespace Practice1_1_2 {
    class Program {
        static void Main(string[] args) {
            //どら焼きオブジェクトの消費税額を求め、コンソールに出力するコードを書いてください。
            Product dorayaki = new Product(98, "どら焼き", 210);
            int taxAmount = dorayaki.GetTax();

            Console.WriteLine("どら焼きの消費税は" + taxAmount + "円");
        }
    }
}


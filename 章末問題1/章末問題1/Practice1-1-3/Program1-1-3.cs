

using dorayaki;
using System;
namespace Practice1_1_3 {
    /*
    問題1.1
    3.productクラスが属する名前空間を別の名前空間に変更し、Mainメソッドから呼び出すようにしてください。
    ただし、mainメソッドのあるProgramクラスの名前空間はそのままにしといてください。
    */
    class Program {
        static void Main(string[] args) {

            Product wdorayaki = new Product(98, "どら焼き", 210);
            int wtaxAmount = wdorayaki.GetTax();

            Console.WriteLine("どら焼きの消費税は" + wtaxAmount + "円");
        }
    }
}

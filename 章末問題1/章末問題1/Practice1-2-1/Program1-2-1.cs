using System;

namespace Practice1_2_1 {
    /*
    問題1.2
    「1.2：構造体」で定義した、MyClassとMyStructの2つを使い、以下のコードを書いてください。

    1.MyClassとMyStructの2つの方を引数に取るメソッドPrintObjectsを定義してください。
    PrintObjectsメソッドでは、2つのオブジェクトの内容(プロパティの値)をコンソールに表示するようにしてください。
    なお、PrintObjectsメソッドは、Programクラスのメソッドとして定義してください。

    2.Mainメソッドで、PrintObjectsメソッドを呼び出すコードを書いてください。
    MyClass, MyStructオブジェクトの値は自由に決めて構いません。
    */

    class Program {
        static void Main(string[] args) {

            MyClass wmyClass = new MyClass { X = 1, Y = 2 };
            MyStruct wmyStruct = new MyStruct { X = 1, Y = 2 };

            // PrintObjectsメソッドを呼び出してオブジェクトの内容を表示
            PrintObjects(wmyClass, wmyStruct);
        }

        // MyClassとMyStructの内容を表示するPrintObjectsメソッドを定義
        static void PrintObjects(MyClass wmyClass, MyStruct wmyStruct) {
            Console.WriteLine("MyClass: X = " + wmyClass.X + ", Y = " + wmyClass.Y);
            Console.WriteLine("MyStruct: X = " + wmyStruct.X + ", Y = " + wmyStruct.Y);
        }



    }
}



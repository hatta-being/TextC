using System;

namespace Practice1_2_3 {
    /*
    問題1.2
    3.PrintObjectsメソッド内で、それぞれのプロパティの値を2倍に変更するコードを追加してください。
    MainメソッドではPrintObjects呼び出しの後にMyClass、MyStructオブジェクトのプロパティの値をコンソールに表示するコードを加えてください。
    */
    class Program {
        static void Main(string[] args) {

            MyClass wMyClass = new MyClass { X = 1, Y = 2 };
            MyStruct wMyStruct = new MyStruct { X = 1, Y = 2 };

            // PrintObjectsメソッドを呼び出してオブジェクトの内容を表示
            PrintObjects(wMyClass, wMyStruct);
            PrintObjects2(wMyClass, wMyStruct);
            PrintObjects(wMyClass, wMyStruct);
        }

        // MyClassとMyStructの内容を表示するPrintObjectsメソッドを定義
        static void PrintObjects(MyClass wMyClass, MyStruct wMyStruct) {
            Console.WriteLine("MyClass: X = " + wMyClass.X + ", Y = " + wMyClass.Y);
            Console.WriteLine("MyStruct: X = " + wMyStruct.X + ", Y = " + wMyStruct.Y);
        }
        // MyClassとMyStructの2倍に変更するコード
        static void PrintObjects2(MyClass wMyClass, MyStruct wMyStruct) {
            wMyClass.X = wMyClass.X * 2;
            wMyClass.Y = wMyClass.Y * 2;
            wMyStruct.X = wMyStruct.X * 2;
            wMyStruct.Y = wMyStruct.Y * 2;
        }
    }
}

        /*
        問題1.2
        4.上記のコードを実行し、結果を確認してください。そして、どうしてそのような結果になったのか、理由を説明してください。

        結果を確認したところ、下記のように表示された。
        MyClass: X = 1, Y = 2
        MyStruct: X = 1, Y = 2
        MyClass: X = 2, Y = 4
        MyStruct: X = 1, Y = 2
        1.2行目はPrintObjectsメソッドを呼び出しMyClassとMyStructのプロパティの値を初期値のまま表示している。
        3行目はMyClass(参照型)であるため、PrintObjects2メソッド呼びを出しMyClassのプロパティは2倍に変更されPrintObjectsメソッドが呼び出されたことで変更後の2倍の値が表示されている。
        4行目はMyStruct(値型)であるため、PrintObjects2 メソッドでの変更に影響されず初期値のまま表示されています。
         */

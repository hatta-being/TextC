using System;

namespace Practice1_2_3 {
    /*
    問題1.2
    3.PrintObjectsメソッド内で、それぞれのプロパティの値を2倍に変更するコードを追加してください。
    MainメソッドではPrintObjects呼び出しの後にMyClass、MyStructオブジェクトのプロパティの値をコンソールに表示するコードを加えてください。
    */
    class Program {
        static void Main(string[] args) {

            MyClass wmyClass = new MyClass { X = 1, Y = 2 };
            MyStruct wmyStruct = new MyStruct { X = 1, Y = 2 };

            // PrintObjectsメソッドを呼び出してオブジェクトの内容を表示
            PrintObjects(wmyClass, wmyStruct);
            PrintObjects2(wmyClass, wmyStruct);
            PrintObjects(wmyClass, wmyStruct);

        }

        // MyClassとMyStructの内容を表示するPrintObjectsメソッドを定義
        static void PrintObjects(MyClass wmyClass, MyStruct wmyStruct) {
            Console.WriteLine("MyClass: X = " + wmyClass.X + ", Y = " + wmyClass.Y);
            Console.WriteLine("MyStruct: X = " + wmyStruct.X + ", Y = " + wmyStruct.Y);
        }
        // MyClassとMyStructの2倍に変更するコード
        static void PrintObjects2(MyClass wmyClass, MyStruct wmyStruct) {
            wmyClass.X = wmyClass.X * 2;
            wmyClass.Y = wmyClass.Y * 2;
            wmyStruct.X = wmyStruct.X * 2;
            wmyStruct.Y = wmyStruct.Y * 2;
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

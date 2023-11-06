using System;

namespace Practice1_3_4 {
    /*
    問題1.3
    「1.6：継承」で示したPersonクラスを使い、以下のコードを書いてください。

    4. 2.で生成したインスタンスをPerson型およびobject型の変数に代入出来ることを確認してください。

    */
    class Program {
        static void Main(string[] args) {
            Student wStudent = new Student("山田太郎","神戸小学校", 3, 3);
            Console.WriteLine($"{wStudent.Name}は、{wStudent.SchoolName}の{wStudent.Grade}年{wStudent.ClassNumber}組に所属しています。");

            //Person型およびobject型の変数に代入出来ることの確認
            object wobject = wStudent;
            Person wpeson = wStudent;
        }
    }
}

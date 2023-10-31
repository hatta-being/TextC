﻿using System;

namespace Practice1_3_1 {
    /*
    問題1.3
    「1.6：継承」で示したPersonクラスを使い、以下のコードを書いてください。

    1.Personクラスを継承し、Studentクラスを定義してください。
    Studentには、2つのプロパティ、Grade(学年)とClassNumber(組)を追加してください。
    2つのプロパティとも型はintとします。

    2.Studentクラスのインスタンスを生成するコードを書いてください、このとき、すべてのプロパティに値を設定してください。

    3. 2.で生成したインスタンスの各プロパティの値をコンソールに出力するコードを書いてください。

    */

    static class Program {
        static void Main(string[] args) {
            Student wStudent = new Student {
                Name = "山田太郎",
                Birthday = new DateTime(2013, 4, 5),
                ShoolName = "神戸小学校",
                Grade = 3,
                ClassNumber = 3,
            };
            Console.WriteLine($"{wStudent.Name}({wStudent.GetAge()})は、{wStudent.ShoolName}の{wStudent.Grade}年{wStudent.ClassNumber}組に所属しています。");
        }
    }
}

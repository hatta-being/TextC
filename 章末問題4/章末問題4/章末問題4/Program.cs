using System;
using System.Linq;
namespace 章末問題4 {
    class Program {
        static void Main(string[] args) {
            /*問題4.2
            1.YearMonthを要素に持つ配列を定義し、初期値として5つのYearMonthオブジェクトをセットしてください。*/
            YearMonth[] w21stCenturyData = {
        new YearMonth(2021, 1),
        new YearMonth(2021, 5),
        new YearMonth(2022, 8),
        new YearMonth(2023, 12),
        new YearMonth(2100, 2)
        };

            //2.この配列の要素(YearMonth)オブジェクトをすべて列挙し、その値をコンソールに出力してください。
            foreach (YearMonth wYearMonth in w21stCenturyData) {
                Console.WriteLine($"{wYearMonth.Year.ToString()}年{wYearMonth.Month}月");
            }

            /*4.3で作成したメソッドを呼び出し、最初に見つかった21世紀のデータの年を表示してください。
            見つからなければ、"21世紀のデータはありません"を表示してください。*/
            YearMonth wFound21 = GetFirst21(w21stCenturyData);
            Console.WriteLine(wFound21 != null ? $"{wFound21.Year}年{wFound21.Month}月" : "21世紀のデータはありません");


            /*5.配列に格納されているすべてのYearMonthの1ヵ月後を求め、その結果を新たな配列に入れてください。
            その後、その配列の要素の内容(年月)を順に表示してください。LINQを使えるところはLINQを使って実装してみてください。*/
            // LINQを使用して1ヶ月後のYearMonthを計算し、新しい配列に格納
            var wNextMonthArray = w21stCenturyData.Select(x => x.AddOneMonth(1)).ToArray();

            // LINQを使用して年月を順に並び変え
            var wSortedArray = wNextMonthArray.OrderBy(x => x.Year).ThenBy(x => x.Month).ToArray();

            // 結果を順に表示
            Console.WriteLine();
            Console.WriteLine("1ヶ月後かつ年月順の結果:");
            foreach (var x in wSortedArray) {
                Console.WriteLine(x);
            }
        }

        /*3.配列の中の最初に見つけた21世紀のYearMonthオブジェクトを返すメソッドを書いてください。
        見つからなかった場合は、nullを返してください。foreach文を使って実装してください。*/
        static YearMonth GetFirst21(YearMonth[] vYearMonthArray) {
            foreach (YearMonth wYearMonth in vYearMonthArray) {
                return wYearMonth.Is21Century == true ? wYearMonth : null;
            }
            return null;
        }
    }
}

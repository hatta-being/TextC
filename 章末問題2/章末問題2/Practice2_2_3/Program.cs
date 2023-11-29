using System;
namespace Practice2_2_3 {
    class Program {
        //「2.2:売り上げ集計プログラム」で作成したプログラムを変更し、商品カテゴリ別の売上高を求めるプログラムを作成してください。
        static void Main(string[] args) {
            var wSales = new SalesCounter("sales.csv");
            var wCalculateSalesPerCategorye = wSales.GetPerCategorySales();

            foreach (var wObj in wCalculateSalesPerCategorye) {
                Console.WriteLine("{0} {1}", wObj.Key, wObj.Value);
            }
        }
    }
}

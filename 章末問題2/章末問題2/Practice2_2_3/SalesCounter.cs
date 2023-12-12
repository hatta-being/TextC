using System.Collections.Generic;
using System.IO;
namespace Practice2_2_3 {
    //売上集計クラス
    class SalesCounter {
        private IEnumerable<Sale> FSales;

        //コンストラクタ
        public SalesCounter(string vFilePath) {
            FSales = ReadSales(vFilePath);
        }

        //売り上げのデータを読み込み、Saleオブジェクトのリストを返す
        private static IEnumerable<Sale> ReadSales(string vFilePath) {
            var wSales = new List<Sale>();
            string[] wLines = File.ReadAllLines(vFilePath);
            foreach (string wLine in wLines) {
                string[] wItems = wLine.Split(',');
                Sale wSale = new Sale {
                    ShopName = wItems[0],
                    ProductCategory = wItems[1],
                    Amount = int.Parse(wItems[2])
                };
                wSales.Add(wSale);
            }
            return wSales;
        }

        //商品別売り上げを求める
        public IDictionary<string, int> GetPerCategorySales() {
            var wDict = new Dictionary<string, int>();
            foreach (Sale wSale in FSales) {
                if (wDict.ContainsKey(wSale.ProductCategory))
                    wDict[wSale.ProductCategory] += wSale.Amount;
                else
                    wDict[wSale.ProductCategory] = wSale.Amount;
            }
            return wDict;
        }
    }
}

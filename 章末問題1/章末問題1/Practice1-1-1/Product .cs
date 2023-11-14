using System;
namespace Practice1_1_1 {
    public class Product {
        /// <summary>
        /// 商品コード
        /// </summary>
        public int Code { get; private set; }
        /// <summary>
        /// 商品名
        /// </summary>
        public string Name { get; private set; }
        /// <summary>
        /// 商品価格（税抜き）
        /// </summary>
        public int Price { get; set; }

        //コンストラクタ
        public Product(int vCode, string vName, int vPrice) {
            this.Code = vCode;
            this.Name = vName;
            this.Price = vPrice;
        }

        //消費税を決める。なおかつ少数になった場合は切り捨てる（消費税率は8％）
        public int GetTax() {
            double wTaxAmount = Price * 0.08;
            return (int)Math.Floor(wTaxAmount);
        }
    }
}

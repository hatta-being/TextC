namespace dorayaki {
    public class Product {
        //商品コード
        public int vCode { get; private set; }
        //商品名
        public string vName { get; private set; }
        //商品価格（税抜き）
        public int vPrice { get; set; }

        //コンストラクタ
        public Product(int vCode, string vName, int vPrice) {
            this.vCode = vCode;
            this.vName = vName;
            this.vPrice = vPrice;
        }

        //消費税を決める（消費税率は8％）
        public int GetTax() {
            return (int)(vPrice * 0.08);
        }
    }
}

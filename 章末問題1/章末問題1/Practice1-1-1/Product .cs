namespace Practice1_1_1 {
    class Product {

        //商品コード
        public int Code { get; private set; }
        //商品名
        public string Name { get; private set; }
        //商品価格（税抜き）
        public int Price { get; set; }

        //コンストラクタ
        public Product(int code, string name, int price) {
            this.Code = code;
            this.Name = name;
            this.Price = price;
        }

        //消費税を決める（消費税率は8％）
        public int GetTax() {
            return (int)(Price * 0.08);
        }
    }
}

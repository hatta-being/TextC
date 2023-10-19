using System;

namespace Program1_1_2 {
    class Program {

        //どら焼きオブジェクトの消費税を求め、コンソールに出力するコードを書いてください。
        //商品クラス
        public class Product {
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
    

        static void Main(string[] args) {
                Product dorayaki = new Product(98, "どら焼き", 210);
                int taxAmount = dorayaki.GetTax();

                Console.WriteLine("どら焼きの消費税は: " + taxAmount + "円");
            

        }
    }
}
}

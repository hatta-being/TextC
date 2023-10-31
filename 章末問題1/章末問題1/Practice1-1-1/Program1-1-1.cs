
namespace Practice1_1_1 {
    /*
    問題1.1
    「1.1:クラス」で定義したProductクラスを使いコードを書いてください。
    1.どら焼きオブジェクトを生成するコードを書いてください。このときの商品番号は"98"、商品価格は"210円"としてください。
    */
    class Program {
        static void Main(string[] args) {
            Product wDorayaki = new Product(98, "どら焼き", 210);
        }
    }
}

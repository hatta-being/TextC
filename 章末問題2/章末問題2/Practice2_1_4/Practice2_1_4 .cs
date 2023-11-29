using System;
namespace Practice2_1_4 {
    class Practice2_1_4 {
        /*
         問題2.1
         4.配列に格納されたすべてのSongオブジェクトの内容をコンソールに出力してください。
         演奏時間の表示は、「4:16」のような書式にしてください。
         ただし、演奏時間は必ず60分未満と仮定してかまいません。
         */
        static void Main(string[] args) {
            //Songクラスのインスタンス
            Song_Class wSong1 = new Song_Class("唱", "Ado", 189);
            Song_Class wSong2 = new Song_Class("アイドル", "YOASOBI", 213);
            Song_Class wSong3 = new Song_Class("Perfect Night", "LE SSERAFIM", 183);

            int wMin1 = wSong1.Length / 60;
            int wAmari1 = wSong1.Length % 60;
            int wMin2 = wSong2.Length / 60;
            int wAmari2 = wSong2.Length % 60;
            int wMin3 = wSong3.Length / 60;
            int wAmari3 = wSong3.Length % 60;

            Console.WriteLine($"タイトル: {wSong1.Title}　アーティスト名: {wSong1.ArtistName}　演奏時間: {wMin1}:{wAmari1:D2}");
            Console.WriteLine($"タイトル: {wSong2.Title}　アーティスト名: {wSong2.ArtistName}　演奏時間: {wMin2}:{wAmari2}");
            Console.WriteLine($"タイトル: {wSong3.Title}　アーティスト名: {wSong3.ArtistName}　演奏時間: {wMin3}:{wAmari3:D2}");
        }
    }
}

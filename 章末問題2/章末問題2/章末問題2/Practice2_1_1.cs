using System;
namespace Practice2_1_1 {
    class Practice2_1_1 {
        //問題2.1
        //3.作成したSongクラスのインスタンスを複数生成し、配列Songsに格納してください。
        static void Main(string[] args) {
            //Songクラスのインスタンス
            Song_Class wSong1 = new Song_Class("唱", "Ado", 189);
            Song_Class wSong2 = new Song_Class("アイドル", "YOASOBI", 213);
            Song_Class wSong3 = new Song_Class("Perfect Night", "LE SSERAFIM", 183);

            Console.WriteLine($"タイトル: {wSong1.Title}　アーティスト名: {wSong1.ArtistName}　演奏時間: {wSong1.Length}");
            Console.WriteLine($"タイトル: {wSong2.Title}　アーティスト名: {wSong2.ArtistName}　演奏時間: {wSong2.Length}");
            Console.WriteLine($"タイトル: {wSong3.Title}　アーティスト名: {wSong3.ArtistName}　演奏時間: {wSong3.Length}");
        }
    }
}

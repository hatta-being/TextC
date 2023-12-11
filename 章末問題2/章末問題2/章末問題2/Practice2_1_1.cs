using System;
namespace Practice2_1_1 {
    class Practice2_1_1 {
        //問題2.1
        //3.作成したSongクラスのインスタンスを複数生成し、配列Songsに格納してください。
        static void Main(string[] args) {
            //Songクラスのインスタンス
            Song wSong1 = new Song("唱", "Ado", 189);
            Song wSong2 = new Song("アイドル", "YOASOBI", 213);
            Song wSong3 = new Song("Perfect Night", "LE SSERAFIM", 183);

            Song[] wSongs = new Song[] { wSong1, wSong2, wSong3 };

            foreach (var wSong in wSongs) {
                int wMinutes = wSong.Length / 60;
                int wRemainder = wSong.Length % 60;
                Console.WriteLine($"タイトル: {wSong.Title}　アーティスト名: {wSong.ArtistName}　演奏時間: {wMinutes}:{wRemainder:D2}");
            }
        }
    }
}

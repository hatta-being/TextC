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
            var wSong1 = new Song("唱", "Ado", 189);
            var wSong2 = new Song("アイドル", "YOASOBI", 213);
            var wSong3 = new Song("Perfect Night", "LE SSERAFIM", 183);
            var wSongs = new Song[] { wSong1, wSong2, wSong3 };
            foreach (var wSong in wSongs) {
                DisplaySong(wSong);
            }
        }
        /// <summary>
        /// 歌の情報を表示する
        /// </summary>
        /// <param name="vSong">歌</param>
        static void DisplaySong(Song vSong) {
            int wMinutes = vSong.Length / 60;
            int wRemainder = vSong.Length % 60;
            Console.WriteLine($"タイトル: {vSong.Title}　アーティスト名: {vSong.ArtistName}　演奏時間: {wMinutes}:{wRemainder:D2}");
        }
    }
}
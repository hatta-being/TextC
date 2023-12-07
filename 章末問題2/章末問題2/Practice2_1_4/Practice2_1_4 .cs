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
            Music("唱", "Ado", 189);
            Music("アイドル", "YOASOBI", 213);
            Music("Perfect Night", "LE SSERAFIM", 183);
        }
        static void Music(string vTitle, string vArtistName, int vMinutes) {
            Song wSong = new Song(vTitle, vArtistName, vMinutes);
            int wMinutes = wSong.Length / 60;
            int wRemainder = wSong.Length % 60;
            Console.WriteLine($"タイトル: {wSong.Title}　アーティスト名: {wSong.ArtistName}　演奏時間: {wMinutes}:{wRemainder:D2}");
        }
    }
}

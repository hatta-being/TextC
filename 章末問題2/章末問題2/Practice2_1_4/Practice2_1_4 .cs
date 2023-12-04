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
            Song wSong1 = new Song("唱", "Ado", 189);
            Song wSong2 = new Song("アイドル", "YOASOBI", 213);
            Song wSong3 = new Song("Perfect Night", "LE SSERAFIM", 183);

            int wMinutes1 = wSong1.Length / 60;
            int wRemainder1 = wSong1.Length % 60;
            int wMinutes2 = wSong2.Length / 60;
            int wRemainder2 = wSong2.Length % 60;
            int wMinutes3 = wSong3.Length / 60;
            int wRemainder3 = wSong3.Length % 60;

            Console.WriteLine($"タイトル: {wSong1.Title}　アーティスト名: {wSong1.ArtistName}　演奏時間: {wMinutes1}:{wRemainder1:D2}");
            Console.WriteLine($"タイトル: {wSong2.Title}　アーティスト名: {wSong2.ArtistName}　演奏時間: {wMinutes2}:{wRemainder2}");
            Console.WriteLine($"タイトル: {wSong3.Title}　アーティスト名: {wSong3.ArtistName}　演奏時間: {wMinutes3}:{wRemainder3:D2}");
        }
    }
}

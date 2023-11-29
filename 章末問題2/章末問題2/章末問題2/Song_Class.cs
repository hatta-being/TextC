namespace Practice2_1_1 {
    public class Song_Class {
        /*
        問題2.1
        1.以下のプロパティを持つ、Songクラスを定義してください。
        Title:string型(歌のタイトル)
        ArtistName:string型(アーティスト名)
        Length:int型(演奏時間、単位は秒)
        */
        /// <summary>
        /// 歌のタイトル
        /// </summary>
        public string Title { get; set; }
        /// <summary>
        /// アーティスト名
        /// </summary>
        public string ArtistName { get; set; }
        /// <summary>
        /// 演奏時間(秒)
        /// </summary>
        public int Length { get; set; }

        //問題2.1
        //2.このとき、3つの引数を持つコンストラクタも定義してください。
        public Song_Class(string vTitle, string vArtistName, int vLength) {
            this.Title = vTitle;
            this.ArtistName = vArtistName;
            this.Length = vLength;
        }
    }
}

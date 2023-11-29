namespace Practice2_1_4 {
    class Song_Class {
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

        //コンストラクタ
        public Song_Class(string vTitle, string vArtistName, int vLength) {
            this.Title = vTitle;
            this.ArtistName = vArtistName;
            this.Length = vLength;
        }
    }
}

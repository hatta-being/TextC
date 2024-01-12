namespace 章末問題4 {
    /*問題4.1
    1.年(Year)と月(Month)の2つのプロパティを持つクラスYearMonthを定義してください。
    このとき、2つのプロパティは読み取り専用にし、値はコンストラクタで指定できるようにしてください。
    なお、引数で渡される月の値は1から12の範囲にあるものと仮定してかまいません。
    */
    class YearMonth {
        /// <summary>
        /// 年
        /// </summary>
        public int Year { get; private set; }
        /// <summary>
        /// 月
        /// </summary>
        public int Month { get; private set; }

        /*2.YearMonthクラスに、Is21Centuryプロパティを追加してください。
        2001年から2100年までが21世紀です。この処理では加減乗除は行わないでください。*/
        /// <summary>
        /// 21世紀
        /// </summary>
        public bool Is21Century {
            get {
                return this.Year >= 2001 && this.Year <= 2100;
            }
        }
        //コンストラクタ
        public YearMonth(int vYear, int vMonth) {
            this.Year = vYear;
            this.Month = vMonth;
        }

        /*3.YearMonthクラスに、1ヵ月後を求めるAddOneMonthメソッドを追加してください。
        このとき、自分自身のプロパティは変更せずに、新たなYearMonthオブジェクトを生成しその値を返してください。
        12月のときの処理に注意してください。*/
        public YearMonth AddOneMonth() {
            int wNewYear = this.Year;
            int wNewMonth = this.Month + 1;
            if (wNewMonth > 12) {
                wNewMonth = 1;
            }
            return new YearMonth(wNewYear, wNewMonth);
        }

        //4.ToStringメソッドをオーバーライドしてください。結果は、"2017年8月"といった形式にしてください。
        public override string ToString() {
            return $"{this.Year}年{this.Month}月";
        }
    }
}

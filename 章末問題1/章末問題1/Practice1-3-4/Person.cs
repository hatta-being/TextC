using System;

namespace Practice1_3_4 {
    public class Person {
        /// <summary>
        /// 名前
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// 誕生日
        /// </summary>
        public DateTime Birthday { get; set; }
        /// <summary>
        /// 年齢
        /// </summary>
        public int GetAge() {
            DateTime wToday = DateTime.Today;
            int wage = wToday.Year - Birthday.Year;
            if (wToday < Birthday.AddYears(wage)) wage--;
            return wage;
        }
    }
}

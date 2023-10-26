using System;

namespace Practice1_3_4 {
    public class Person : object {
        public string Name { get; set; }
        public DateTime Birthday { get; set; }
        public int GetAge() {
            DateTime today = DateTime.Today;
            int wage = today.Year - Birthday.Year;
            if (today < Birthday.AddYears(wage))
                wage--;
            return wage;



        }
    }
}



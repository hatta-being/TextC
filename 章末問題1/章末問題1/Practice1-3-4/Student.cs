namespace Practice1_3_4 {
    public class Student : Person {

        /// <summary>
        /// 学校名
        /// </summary>
        public string SchoolName { get; set; }
        /// <summary>
        /// 学年
        /// </summary>
        public int Grade { get; set; }
        /// <summary>
        /// 組
        /// </summary>
        public int ClassNumber { get; set; }

        //コンストラクタ
        public Student(string wName, string wShoolName, int vGrade, int vClassNumber) {
            this.Name = wName;
            this.SchoolName = wShoolName;
            this.Grade = vGrade;
            this.ClassNumber = vClassNumber;
        }
    }
}

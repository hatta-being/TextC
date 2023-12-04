namespace Practice2_2_2 {
    //インチとメートルの変換を行うクラス
    public static class InchConverter {
        /// <summary>
        /// メートルからインチを求める
        /// </summary>
        /// <param name="vMeter"></param>
        /// <returns>Inch</returns>
        public static double FromMeter(double vMeter) {
            return vMeter / 0.0254;
        }
        /// <summary>
        /// インチからメートルを求める
        /// </summary>
        /// <param name="vInch"></param>
        /// <returns>Meter</returns>
        public static double ToMeter(double vInch) {
            return vInch * 0.0254;
        }
    }
}

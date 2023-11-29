namespace Practice2_2_2 {
    public static class InchConverter {
        //メートルからインチを求める
        public static double FromMeter(double vMeter) {
            return vMeter / 0.0254;
        }
        //インチからメートルを求める
        public static double ToMeter(double vInch) {
            return vInch * 0.0254;
        }
    }
}

using System;
namespace Practice2_2_2 {
    class Practice2_2_2 {
        /*
        「2.1:距離換算プログラム」のコードを参考に、インチからメートルへの変換表を1インチ刻みでコンソールに出力するプログラムを書いてください。
        このときのインチの範囲は、1インチから10インチまでとしてください。1インチは0.0254メートルです。
        */
        static void Main(string[] args) {
            if (args.Length >= 1 && args[0] == "-tom")
                PrintInchToMeterList(1, 10);
            else
                PrintMeterToInchList(1, 10);
        }
        //インチからメートルへの対応表出力
        static void PrintInchToMeterList(int vStart, int vStop) {
            for (int i = vStart; i <= vStop; i++) {
                double wMeter = InchConverter.ToMeter(i);
                Console.WriteLine("{0})in = {1:0.0000}m", i, wMeter);
            }
        }
        //メートルからインチへの対応表出力
        static void PrintMeterToInchList(int vStart, int vStop) {
            for (int i = vStart; i <= vStop; i++) {
                double wInch = InchConverter.FromMeter(i);
                Console.WriteLine("{0}m = {1:0.0000}in", i, wInch);
            }
        }
    }
}

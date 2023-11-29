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
            for (int wInch = vStart; wInch <= vStop; wInch++) {
                double wMeter = InchConverter.ToMeter(wInch);
                Console.WriteLine("{0})in = {1:0.0000}m", wInch, wMeter);
            }
        }
        //メートルからインチへの対応表出力
        static void PrintMeterToInchList(int vStart, int vStop) {
            for (int wMeter = vStart; wMeter <= vStop; wMeter++) {
                double wInch = InchConverter.ToMeter(wMeter);
                Console.WriteLine("{0}in = {1:0.0000}m", wMeter, wInch);
            }
        }
    }
}

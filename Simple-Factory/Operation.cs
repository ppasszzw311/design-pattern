namespace Simple_Factory
{
    // 工廠基底類別
    public class Operation
    {
        // 定義所有的計算元都是兩個計算員組成
        public double NumberA { get; set;} = 0;
        public double NumberB { get; set;} = 0;

        public Operation(double numberA, double numberB)
        {
            NumberA = numberA;
            NumberB = numberB;
        }

        // 建立一個虛擬方法
        public virtual double GetResult() 
        {
            return 0; // 預設返回0
        }
    }
}
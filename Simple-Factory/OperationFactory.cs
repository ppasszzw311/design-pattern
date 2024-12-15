namespace Simple_Factory
{
    // 工廠類別實作
    public class OperationFactory
    {
        public static Operation CreateOperation(string operationType, double numberA, double numberB)
        {
            return operationType switch
            {
                "+" => new OperationAdd(numberA, numberB),
                "-" => new OperationSub(numberA, numberB),
                "*" => new OperationMul(numberA, numberB),
                "/" => new OperationDiv(numberA, numberB),
                _ => throw new Exception("無效的運算符號")
            };
        }
    }
    // 加法類別
    public class OperationAdd : Operation
    {
        public OperationAdd(double numberA, double numberB) : base(numberA, numberB) { }

        // 覆寫父類別的GetResult方法
        public override double GetResult()
        {
            return NumberA + NumberB;
        }
    }

    // 減法類別
    public class OperationSub : Operation
    {
        public OperationSub(double numberA, double numberB) : base(numberA, numberB) { }

        // 覆寫父類別的GetResult方法
        public override double GetResult()
        {
            return NumberA - NumberB;
        }
    }

    // 乘法類別
    public class OperationMul: Operation
    {
        public OperationMul(double numberA, double numberB) :base(numberA, numberB) { }

        // 覆寫父類別的GetResult
        public override double GetResult()
        {
            return NumberA * NumberB;
        }
    }

    // 除法類別
    public class OperationDiv : Operation
    {
        public OperationDiv(double numberA, double numberB) : base(numberA, numberB) { }

        // 覆寫父類別的GetResult
        public override double GetResult()
        {
            if (NumberB == 0)
            {
                throw new Exception("除數不能為0");
            }
            return NumberA / NumberB;
        }
    }
}
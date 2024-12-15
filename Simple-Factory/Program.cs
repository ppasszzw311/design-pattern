// 使用工廠模式創建運算物件
using Simple_Factory;

Operation operation = OperationFactory.CreateOperation("+", 10, 2);
Console.WriteLine($"運算結果: {operation.GetResult()}"); 
Operation operation2 = OperationFactory.CreateOperation("-", 10, 2);
Console.WriteLine($"運算結果: {operation2.GetResult()}"); 
Operation operation3 = OperationFactory.CreateOperation("*", 10, 2);
Console.WriteLine($"運算結果: {operation3.GetResult()}"); 
Operation operation4 = OperationFactory.CreateOperation("/", 10, 2);
Console.WriteLine($"運算結果: {operation4.GetResult()}"); 
// Operation operation5 = OperationFactory.CreateOperation("/", 10, 0);
// Console.WriteLine($"運算結果: {operation5.GetResult()}"); 


using Singleton;
// 單例模式 租借電池系統

Console.WriteLine("租借管理系統啟動中...");

// 初始化站點物品數量
var manager = ItemManager.Instance;
manager.SetInitialQuantity(10);

Console.WriteLine($"站點初始物品數量: {manager.Quantity}");

// 創建三個線程來執行借出跟歸還的動作
Thread thread1 = new Thread(() => SimulateBorrow(manager, 5));
Thread thread2 = new Thread(() => SimulateBorrow(manager, 9));
Thread thread3 = new Thread(() => SimulateReturn(manager, 3));

// 啟動線程
thread1.Start();
thread2.Start();
thread3.Start();

// 等待所有線程完成
thread1.Join();
thread2.Join();
thread3.Join();

Console.WriteLine($"站點剩餘物品數量: {manager.Quantity}");
Console.WriteLine("租借管理系統已關閉");


// 模擬方法 - 借出物品
static void SimulateBorrow(ItemManager manager, int times)
{
  for (int i = 0; i < times; i++)
  {
    if (manager.BorrowItem())
      Console.WriteLine($"[{Thread.CurrentThread.ManagedThreadId}]借出物品成功，剩餘數量: {manager.Quantity}");
    else
      Console.WriteLine($"[{Thread.CurrentThread.ManagedThreadId}]借出物品失敗，沒有足夠的商品");
    Thread.Sleep(100); // 模擬借出物品的時間
  }
}
// 模擬方法 - 歸還物品
static void SimulateReturn(ItemManager manager, int times)
{
  for (int i = 0; i < times; i++)
  {
    manager.ReturnItem();
    Console.WriteLine($"[{Thread.CurrentThread.ManagedThreadId}]歸還物品成功，剩餘數量: {manager.Quantity}");
    Thread.Sleep(150);
  }
}

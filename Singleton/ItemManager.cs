namespace Singleton
{
    public class ItemManager
    {
        private static readonly Lazy<ItemManager> _instance = new (() => new ItemManager());
        private int _quantity; // 站點物品數量
        private readonly object _lock = new(); // 鎖物件

        // 私有化構造函數，防止外部實例化
        private ItemManager() { } 

        // 提供一個靜態屬性，返回單例實例
        public static ItemManager Instance => _instance.Value;

        // 初始化物品數量
        public void SetInitialQuantity(int quantity)
        {
            lock (_lock)
            {
                _quantity = quantity;
            }
        }

        // 獲取當前數量
        public int Quantity 
        {
            get
            {
                lock (_lock)
                {
                    return _quantity;
                }
            }
        }

        // 借出物品
        public bool BorrowItem()
        {
            lock (_lock)
            {
                if (_quantity > 0)
                {
                    _quantity--;
                    return true;
                }
                return false;
            }
        }

        // 歸還物品
        public void ReturnItem()
        {
            lock (_lock)
            {
                _quantity++;
            }
        }
    }
}
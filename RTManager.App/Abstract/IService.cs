using System;
using System.Collections.Generic;
using System.Text;

namespace RTManager.App.Abstract
{
    public interface IService<T>
    {
        List<T> Items { get; set; }
        List<T> GetAllItems();
        int AddItem(T item);
        T GetItemById(int itemId);
        int UpdateItem(T item);
        void RemoveItem(T item);
    }
}

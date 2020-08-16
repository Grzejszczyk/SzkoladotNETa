using System;
using System.Collections.Generic;
using System.Text;

namespace RTManager.App.Abstract
{
    interface IService<T>
    {
        List<T> Items { get; set; }
        List<T> GetAllItems();
        int AddItem(T item);
        T GetItem(T item);
        int UpdateItem(T item);
        void RemoveItem(T item);
    }
}

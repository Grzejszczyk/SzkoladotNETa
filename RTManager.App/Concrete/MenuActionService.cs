using RTManager.App.Abstract;
using RTManager.App.Common;
using RTManager.Domian.Entity;
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Text;

namespace RTManager.App.Concrete
{
    public class MenuActionService : BaseService<MenuAction>
    {
        public MenuActionService()
        {
            Initialize();
        }
        public List<MenuAction> GetMenuActionByMenuName(string menuName)
        {
            List<MenuAction> result = new List<MenuAction>();
            foreach (var menuAction in Items)
            {
                if (menuAction.MenuName == menuName)
                {
                    result.Add(menuAction);
                }
            }
            return result;
        }
        private void Initialize()
        {
            AddItem(new MenuAction(1, "Requests List", "UserMenu"));
            AddItem(new MenuAction(2, "Tasks List", "UserMenu"));
            AddItem(new MenuAction(3, "Assign Request to user as Task", "UserMenu"));
            AddItem(new MenuAction(4, "Sign Task as done", "UserMenu"));
            AddItem(new MenuAction(5, "Create new request", "UserMenu"));
            AddItem(new MenuAction(6, "Remove request", "UserMenu"));
        }
    }
}

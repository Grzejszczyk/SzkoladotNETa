using RTManager.App.Concrete;
using RTManager.Domian.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace RTManager.App.Managers
{
    public class RequestManager
    {
        private readonly MenuActionService _menuActionService;
        public RequestManager(MenuActionService menuActionService)
        {
            _menuActionService = menuActionService;
        }
    }
}

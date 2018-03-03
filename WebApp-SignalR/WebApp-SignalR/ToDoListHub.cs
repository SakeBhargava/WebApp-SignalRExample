using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNet.SignalR;

namespace WebApp_SignalR
{
    public class ToDoListHub : Hub
    {
        public void AddItem(string item)
        {
            Clients.All.addItem(item);
        }
    }
}
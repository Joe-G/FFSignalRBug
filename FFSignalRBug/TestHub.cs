using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNet.SignalR;

namespace FFSignalRBug
{
    [Microsoft.AspNet.SignalR.Hubs.HubName("TestHub")]
    public class TestHub : Hub
    {
    }
}
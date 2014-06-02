﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Automaton.Hub
{
    public interface IHubListener
    {
        void ListenForConnectedHubs();

        event EventHandler<HubConnectedEventArgs> OnHubConnected;
    }
}

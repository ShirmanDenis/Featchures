﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PoluPoker
{
    public interface INotifier
    {
        void Notify(string title, string text);
    }

    public class Notifier : INotifier
    {
        public void Notify(string title, string text)
        {
            
        }
    }
}

﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Mediator_Design_Pattern.Structural
{
    public abstract class Mediator
    {
        public abstract void Send(string message, Colleague colleague);
    }
}

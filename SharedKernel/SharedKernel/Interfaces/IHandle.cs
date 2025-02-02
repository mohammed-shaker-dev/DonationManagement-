﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharedKernel.Interfaces
{
    public interface IHandle<T> where T : BaseDomainEvent
    {
        Task HandleAsync(T args);
    }
}

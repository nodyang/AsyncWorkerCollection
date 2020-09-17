﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

#if NETFRAMEWORK
using ValueTask = System.Threading.Tasks.Task;
#endif

namespace dotnetCampus.Threading
{
    // 这个接口在 .NET Framework 4.5 没有
    interface IAsyncDisposable
    {
        ValueTask DisposeAsync();
    }
}

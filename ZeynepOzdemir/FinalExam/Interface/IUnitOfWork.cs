﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FinalExam.Interface
{
    public interface IUnitOfWork : IDisposable
    {
        IUserRepository UserRepository { get; set; }
        int Complete();
    }
}

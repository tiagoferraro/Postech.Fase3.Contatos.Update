﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Postech.Fase3.Contatos.Update.Infra.CrossCuting.Model;

public class ServiceResult<T>
{
    public T? Data { get; }
    public Exception? Error { get; }
    public bool IsSuccess => Error == null;
    public ServiceResult(T data)
    {
        Data = data;
        Error = null;
    }

    public ServiceResult(Exception error)
    {
        Data = default;
        Error = error;
    }
}
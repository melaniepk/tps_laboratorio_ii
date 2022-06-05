﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public interface IArchivo<T> where T: class
    {        
        T LeerArchivo(string path);
        void EscribirArchivo(T datos, string nombre);

    }
}

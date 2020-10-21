using System;

namespace ComposicaoTres.Entities.Enums
{
    public enum OrderStatus : int
    {
        PendingPyment = 0,
        Processing = 1,
        Shpped = 2,
        Delivered = 3
    }
}
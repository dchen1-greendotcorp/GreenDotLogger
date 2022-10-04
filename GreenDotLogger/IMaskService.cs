using System;
using System.Collections.Generic;
using System.Text;

namespace GreenDotShares
{
    public interface IMaskService
    {
        string  Mask<T>(T t, Exception exception);
    }
}

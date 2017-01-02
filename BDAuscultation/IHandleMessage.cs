using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ProtocalData.Protocol;

namespace BDAuscultation
{
    public  interface IHandleMessage<M>  
        where M : CodeBase
    {
       void HandleMessage(M message);
    }
    public interface IStopStethoscope
    {
        void Stop();
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaElementKit
{
    public enum PlayerState
    {
        Playing,
        Buffering,
        Paused,
        Stoped,
        Failed,
        None,
        Opening,
        Ended,
        Opened
    }
}

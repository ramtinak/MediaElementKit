using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaElementKit
{
    public delegate void PositionChangedHandler(MediaElementPro sender, TimeSpan position);
    public delegate void CurrentStateChangedHandler(MediaElementPro sender, PlayerState state);
}

using Entanglement.Network;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntangleHit.Data
{
    public abstract class SyncData : NetworkMessageData
    {
        public abstract MessageType MsgType { get; }
        public abstract byte[] Serialize();
        public abstract void Deserialize(byte[] data);
    }
}

using EntangleHit.Data;
using Entanglement.Network;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntangleHit
{
    public class NotifyHitHandler : NetworkMessageHandler<NotifyHitData>
    {
        public override byte? MessageIndex
        {
            get
            {
                return new byte?(42);
            }
        }

        public override NetworkMessage CreateMessage(NotifyHitData data)
        {
            NetworkMessage msg = new NetworkMessage()
            {
                messageData = data.Serialize(),
                messageType = (byte)MessageIndex
            };
            return msg;
        }

        public override void HandleMessage(NetworkMessage message, long sender)
        {
            NotifyHitData data = new NotifyHitData();
            data.Deserialize(message.messageData);


        }
    }
}

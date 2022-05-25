using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntangleHit.Data
{
    public class NotifyHitData : SyncData
    {
        public long targetPlayer;
        public float bulletDamage;
        public Limb limb;

        public enum Limb : byte
        {
            Head,
            Chest,
            Arms,
            Legs
        }

        public override MessageType MsgType
        {
            get
            {
                return MessageType.NotifyHit;
            }
        }

        public override void Deserialize(byte[] data)
        {
            targetPlayer = data[0];
            bulletDamage = data[1];
            limb = (Limb)data[2];
        }

        public override byte[] Serialize()
        {
            byte[] msg = new byte[3];
            msg[0] = (byte)targetPlayer;
            msg[1] = (byte)bulletDamage;
            msg[2] = (byte)limb;
            return msg;
        }
    }
}

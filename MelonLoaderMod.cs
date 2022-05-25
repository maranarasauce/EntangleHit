using Discord;
using EntangleHit.Data;
using Entanglement.Modularity;
using Entanglement.Network;
using MelonLoader;
using StressLevelZero.Combat;

namespace EntangleHit
{
    public static class BuildInfo
    {
        public const string Name = "EntangleHit"; // Name of the Mod.  (MUST BE SET)
        public const string Author = null; // Author of the Mod.  (Set as null if none)
        public const string Company = null; // Company that made the Mod.  (Set as null if none)
        public const string Version = "1.0.0"; // Version of the Mod.  (MUST BE SET)
        public const string DownloadLink = null; // Download Link for the Mod.  (Set as null if none)
    }

    public class EntangleHit : EntanglementModule
    {
        public override void OnModuleLoaded()
        {
            base.OnModuleLoaded();
        }

        [Harmon]
        public static class ProjectilePatch
        {

        }

        public static void SendHit(float damage, NotifyHitData.Limb limb, long playerId)
        {
            NotifyHitData hitData = new NotifyHitData()
            {
                bulletDamage = damage,
                limb = limb,
                targetPlayer = playerId
            };

            NetworkMessage msg = NetworkMessage.CreateMessage(42, hitData);
            Node.activeNode.BroadcastMessage(NetworkChannel.Attack, msg.GetBytes());
        }

        public override void OnSceneWasInitialized(int buildIndex, string sceneName)
        {
            base.OnSceneWasInitialized(buildIndex, sceneName);
        }
    }
}

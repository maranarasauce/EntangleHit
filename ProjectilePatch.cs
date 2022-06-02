using HarmonyLib;
using MelonLoader;
using StressLevelZero.Combat;
using System;
using UnityEngine;
using UnityEngine.Events;

namespace EntangleHit
{
    [HarmonyPatch(typeof(Projectile), "OnEnable")]
    public static class ProjectilePatch
    {
        public static void Postfix(Projectile __instance)
        {
            if (__instance._proxy != null)
            {
                MelonLogger.Log($"Bullet fired from type of {__instance._proxy.npcType}");
                if (__instance._proxy.lfHand != null)
                {
                    MelonLogger.Log($"Bullet fired had a hand of {__instance._proxy.lfHand.gameObject.name}");
                }

                UnityAction<Collider, Vector3, Vector3> unityAction = new Action<Collider, Vector3, Vector3>(OnCollision);
                __instance.onCollision.AddListener(unityAction);
            }
        }

        public static void OnCollision(Collider col, Vector3 b, Vector3 c)
        {
            MelonLogger.Log($"BONK! This is the col params spat out: {col.gameObject.name}, ({b.x}, {b.y}, {b.z}), ({c.x}, {c.y}, {c.z})");
        }
    }
}

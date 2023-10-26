using Il2Cpp;
using MelonLoader;

namespace NoFleeGoldSlime
{
    internal class NoFleeGoldSlimeEntry : MelonMod
    {
        public override void OnSceneWasLoaded(int buildIndex, string sceneName)
        {
            if (!sceneName.Equals("GameCore"))
                return;
            SlimeDefinition goldSlime = Utility.Get<SlimeDefinition>("Gold");
            GoldSlimeFlee goldSlimeBehavior;
            if (goldSlime.prefab.TryImprovedGetComponent<GoldSlimeFlee>(out goldSlimeBehavior))
                UnityEngine.Object.Destroy(goldSlimeBehavior);
        }
    }
}

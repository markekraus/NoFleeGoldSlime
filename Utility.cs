using System.Linq;
using UnityEngine;

namespace NoFleeGoldSlime
{
    internal class Utility
    {
        public static T Get<T>(string name) where T : UnityEngine.Object
        {
            return Resources.FindObjectsOfTypeAll<T>().FirstOrDefault((T found) => found.name.Equals(name));
        }
    }
}

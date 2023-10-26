using UnityEngine;

namespace NoFleeGoldSlime
{
  public static class Extensions
  {
    public static bool TryImprovedGetComponent<T>(this GameObject @this, out T monoBehaviour) where T : MonoBehaviour
    {
      T component = @this.GetComponent<T>();
      if (component != null)
      {
        monoBehaviour = component;
        return true;
      }
      monoBehaviour = default;
      return false;
    }
  }
}
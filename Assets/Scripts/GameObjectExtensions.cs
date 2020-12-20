using UnityEngine;
using System.Linq;

public static class GameObjectExtensinos
{
    // https://baba-s.hatenablog.com/entry/2014/08/01/101104
    public static GameObject FindDeep(this GameObject self, string name, bool includeInactive = false)
    {
        Transform[] children = self.GetComponentsInChildren<Transform>(includeInactive);
        foreach (Transform child in children)
        {
            if (child.name == name)
                return child.gameObject;
        }
        return null;
    }

    // https://baba-s.hatenablog.com/entry/2014/06/05/220224
    public static T[] GetComponentsInChildrenWithoutSelf<T>(this GameObject self) where T : Component
    {
        return self.GetComponentsInChildren<T>().Where(c => self != c.gameObject).ToArray();
    }

    public static Transform[] GetTransformsRange(this GameObject self, string from, string to, bool includeActive = false)
    {
        GameObject fromGameObject = self.FindDeep(from);
        GameObject toGameObject = self.FindDeep(to);

        if (fromGameObject == null || toGameObject == null)
        {
            return null;
        }

        Transform[] fromTransfroms = fromGameObject.GetComponentsInChildren<Transform>();
        Transform[] toTransformsWithousSelf = toGameObject.GetComponentsInChildrenWithoutSelf<Transform>();

        Transform[] resultTransforms= fromTransfroms.Except<Transform>(toTransformsWithousSelf).ToArray();

        return resultTransforms;
    }


}
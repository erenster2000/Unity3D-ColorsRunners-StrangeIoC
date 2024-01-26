using Runtime.Data.ValueObject;
using UnityEngine;

namespace Runtime.Data.UnityObject
{
    [CreateAssetMenu(fileName = "CD_Color", menuName = "Data/CD_Color", order = 0)]
    public class CD_Color : ScriptableObject
    {
        public ColorData ColorData;
    }
}
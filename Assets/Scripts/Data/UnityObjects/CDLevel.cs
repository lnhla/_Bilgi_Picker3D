using System.Collections.Generic;
using Data.ValueObjects;
using UnityEngine;

namespace Data.UnityObjects
{
    [CreateAssetMenu(fileName = "CDLevel", menuName = "Picker3D/CDLevel", order = 1)]
    public class CDLevel : ScriptableObject
    {
        public List<LevelData> Levels = new List<LevelData>();
    }
}
using Scenes;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Scenes
{
    [CreateAssetMenu(fileName = "Scenes", menuName = "ScriptableObjects/GameData/SceneData", order = 1)]
    public class ScenesData : ScriptableObject
    {
        public List<BaseScene> scenes;
    }
}
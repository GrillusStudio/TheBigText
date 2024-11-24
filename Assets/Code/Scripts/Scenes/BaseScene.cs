using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Scenes
{
    [CreateAssetMenu(fileName = "BaseScene", menuName = "ScriptableObjects/Scenes/BaseScene", order = 1)]
    public class BaseScene : ScriptableObject
    {
        public string SceneName;
    }
}
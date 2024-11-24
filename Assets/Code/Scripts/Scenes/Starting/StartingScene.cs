using Scenes;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Scenes.Starting
{
    [CreateAssetMenu(fileName = "StartScene", menuName = "ScriptableObjects/Scenes/StartingScenes/StartScene", order = 1)]
    public class StartingScene : BaseScene
    {
        public string FirstText;
    }
}
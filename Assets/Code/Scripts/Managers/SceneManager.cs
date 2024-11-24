using NaughtyAttributes;
using Scenes;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

namespace Managers
{
    public class SceneManager : MonoBehaviour
    {
        public BaseScene CurrentScene;
        public TextMeshProUGUI CurrentLocation;
        public GameObject ScreenContent;

        [Button]
        public void updateScene()
        {
            CurrentLocation.text = CurrentScene.SceneName;
        }

    }

}
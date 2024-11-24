using NaughtyAttributes;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Player
{
    public class Player : MonoBehaviour
    {
        [Required("Wymagany SO PlayerData")] public PlayerData PlayerData;
        [SerializeField] private int _chareaterSprite = 0;
        [Required("Model Gracza"), SerializeField] private Image _model;

        public int CharacterSprite
        {
            get
            {
                return _chareaterSprite;
            }
            set
            {
                if (value > PlayerData.Sprites.Count - 1)
                {
                    Debug.LogWarning("Sprite Poza Zakresem");
                }
                else
                {
                    _chareaterSprite = value;
                }
                UpdateModel();
            }
        }

        public void UpdateModel()
        {
            _model.sprite = PlayerData.Sprites[CharacterSprite];
        }

        #region Test metody

        public int newModelNumber;

        [Button("Update Model", EButtonEnableMode.Playmode)]
        public void TestUpdateModel()
        {
            CharacterSprite = newModelNumber;
        }

        #endregion Test metody

    }
}
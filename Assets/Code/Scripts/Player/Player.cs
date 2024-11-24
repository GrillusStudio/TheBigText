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
                _chareaterSprite = value;
            }
        }

        [Button]
        public void UpdateModel()
        {
            _model.sprite = PlayerData.Sprites[CharacterSprite];
        }

    }
}
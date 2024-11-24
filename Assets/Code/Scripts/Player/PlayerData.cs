using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Player
{
    [CreateAssetMenu(fileName = "Player", menuName = "ScriptableObjects/GameData/PlayerData", order = 1)]
    public class PlayerData : ScriptableObject
    {
        [SerializeField] public List<Sprite> Sprites;
    }
}
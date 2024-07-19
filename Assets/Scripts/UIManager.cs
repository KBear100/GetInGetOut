using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    [Header("Player")]
    [SerializeField] CharacterMovement character;
    [Header("UI")]
    [SerializeField] TMP_Text collectablesCountText;

    void Start()
    {
        collectablesCountText.text = "Treasure: " + character.collectables.ToString();
    }

    void Update()
    {
        collectablesCountText.text = "Treasure: " + character.collectables.ToString();
    }
}

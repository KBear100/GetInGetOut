using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    [Header("Player")]
    [SerializeField] Player player;
    [Header("UI")]
    [SerializeField] TMP_Text collectablesCountText;
    [SerializeField] Slider healthBar;

    void Start()
    {
        collectablesCountText.text = "Treasure: " + player.collectables.ToString();
    }

    void Update()
    {
        collectablesCountText.text = "Treasure: " + player.collectables.ToString();
        healthBar.value = player.health;
    }
}

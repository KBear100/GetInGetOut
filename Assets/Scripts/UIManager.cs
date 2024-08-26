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
    [Header("Sounds")]
    [SerializeField] AudioSource coinSound;

    void Start()
    {
        collectablesCountText.text = "Treasure: " + player.collectables.ToString();
    }

    void Update()
    {
        if(!collectablesCountText.text.Contains(player.collectables.ToString())) coinSound.Play();
        collectablesCountText.text = "Treasure: " + player.collectables.ToString();
        healthBar.value = player.health;
    }
}

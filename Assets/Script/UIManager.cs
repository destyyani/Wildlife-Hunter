using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class UIManager : MonoBehaviour
{
    public Image playerHealthBar;
    public float playerHealthBarFullX = 100;

    public GameObject playerHealthBarObject;

    public GameObject gameOverUI;
    public GameObject levelCompleteUI;

    public PlayerController player;

    void Update()
    {

        if (playerHealthBar)
        {
            Vector2 size = playerHealthBar.rectTransform.sizeDelta;
            size.x = player.health / player.healthMax * playerHealthBarFullX;

            playerHealthBar.rectTransform.sizeDelta = size;
        }

        
        if(gameOverUI && (player.health <= 0 || GameManager.isGameOver))
        {
            gameOverUI.SetActive(true);

            playerHealthBar.gameObject.SetActive(false);

            playerHealthBarObject.SetActive(false);
        }
        else if(levelCompleteUI && ScoreManager.currentEnemyProgress == ScoreManager.targetEnemyProgress)
        {
            levelCompleteUI.SetActive(true);
        }
    }
}
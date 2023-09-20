using UnityEngine;
using System.Collections;
using TMPro;

public class ScoreManager : MonoBehaviour
{
    public static ScoreManager Instance { get; private set; }

    public static int currentEnemyProgress { get; private set; }
    public static int targetEnemyProgress { get; private set; }

    public GameObject scoreText;
    void Awake()
    {
        Instance = this;
    }

   void Update()
    {
        if (scoreText)
        {
            scoreText.GetComponent<TextMeshProUGUI>().text = currentEnemyProgress + " of " + targetEnemyProgress;
        }
    }

    private void Start()
    {
        EnemyController[] enemyControllers = FindObjectsOfType<EnemyController>();

        targetEnemyProgress = enemyControllers.Length;
        currentEnemyProgress = 0;
    }

    public static void DefeatEnemy()
    {
        currentEnemyProgress += 1;

        if (currentEnemyProgress >= targetEnemyProgress)
        {
            GameManager.CompleteLevel();
        }
    }

}
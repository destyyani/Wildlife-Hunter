using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LevelPlayButton : MonoBehaviour
{
    private Button button;
    [SerializeField] private string levelName;

    private void Awake() 
    {
        button = GetComponent<Button>();
        button.onClick.AddListener(PlayLevel);
    }
    
    private void PlayLevel() 
    {
        SceneManager.LoadScene(levelName);
    }
}

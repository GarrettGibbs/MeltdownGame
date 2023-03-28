using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuController : MonoBehaviour
{
    [SerializeField] TMP_Text scoreText;

    private void Start() {
        scoreText.text = PlayerPrefs.GetInt("HS", 0).ToString();
    }

    public void StartGame() {
        SceneManager.LoadScene(1);
    }
}

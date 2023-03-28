using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using TMPro;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    private int remainingHealth = 10;
    private int score = 0;
    [SerializeField] UIController uiController;
    [SerializeField] SpawnController spawnController;
    [SerializeField] InSceneSettings inSceneSettings;
    [SerializeField] TMP_Text scoreText;
    [SerializeField] TMP_Text highScoreText;
    [SerializeField] AudioClip damageSound;
    [SerializeField] AudioClip crystalSound;

    public AudioManager audioManager;

    public bool playing = true;

    private async void Start() {
        highScoreText.text = PlayerPrefs.GetInt("HS", 0).ToString();
        audioManager = FindObjectOfType<AudioManager>();
        Time.timeScale = 1f;
        await Task.Delay(1000);
        spawnController.SpawnNewCrystal();
    }

    public void TakeDamage() {
        audioManager.PlaySound(damageSound);
        remainingHealth--;
        uiController.UpdateHealth(remainingHealth);
        if(remainingHealth <= 0) {
            inSceneSettings.ToggleSettingsPanel();
            playing = false;
        }
    }

    public void CollectCrystal() {
        audioManager.PlaySound(crystalSound);
        score++;
        scoreText.text = score.ToString();
        spawnController.SpawnNewCrystal();
    }

    private void OnDestroy() {
        int currentHightScore = PlayerPrefs.GetInt("HS", 0);
        if(score > currentHightScore) {
            PlayerPrefs.SetInt("HS", score);
        }
    }
}

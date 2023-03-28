using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class InSceneSettings : MonoBehaviour
{
    [SerializeField] GameObject settingPanel;
    [SerializeField] GameManager gameManager;
    [SerializeField] Toggle fullscreenToggle;
    bool SettingsOpen = false;

    public void ToggleSettingsPanel() {
        //levelManager.audioManager.PlaySound("Click");
        if (gameManager != null) {
            if(!gameManager.playing) return;
        }
        if (!SettingsOpen) {
            //levelManager.inSettings = true;
            SettingsOpen = true;
            settingPanel.SetActive(true);
            Time.timeScale = 0;
        } else {
            //levelManager.inSettings = false;
            SettingsOpen = false;
            settingPanel.SetActive(false);
            Time.timeScale = 1f;
        }
    }

    private void Update() {
        if (Input.GetKeyDown(KeyCode.Escape)) {
            ToggleSettingsPanel();
        }
        if (Input.GetKeyDown(KeyCode.R)) {
            RestartScene();
        }
    }

    public void RestartScene() {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void ReturnToMenu() {
        SceneManager.LoadScene(0);
    } 

    public void QuitGame() {
        Application.Quit();
    }
}

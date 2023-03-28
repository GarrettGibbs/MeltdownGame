using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIController : MonoBehaviour
{
    [SerializeField] GameObject firstPersonCamera;
    [SerializeField] GameManager gameManager;
    [SerializeField] GameObject[] healhIcons;

    private void Update() {
        if(Input.GetKeyDown(KeyCode.Tab)) SwitchCamera();
    }

    private void SwitchCamera() {
        firstPersonCamera.SetActive(!firstPersonCamera.activeSelf);
    }

    public void UpdateHealth(int newAmount) {
        for (int i = 0; i < healhIcons.Length; i++) {
            if (i >= newAmount) healhIcons[i].SetActive(false);
            else healhIcons[i].SetActive(true);
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIController : MonoBehaviour
{
    [SerializeField] GameObject firstPersonCamera;
    [SerializeField] GameManager gameManager;

    private void Update() {
        if(Input.GetKeyDown(KeyCode.Tab)) SwitchCamera();
    }

    private void SwitchCamera() {
        firstPersonCamera.SetActive(!firstPersonCamera.activeSelf);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] GameManager gameManager;

    private void OnTriggerEnter(Collider other) {
        if (other.gameObject.name == "Damage") {
            gameManager.TakeDamage();
        } else if (other.gameObject.name == "Crystal(Clone)") {
            gameManager.CollectCrystal();
        }
    }
}

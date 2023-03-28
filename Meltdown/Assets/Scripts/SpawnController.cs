using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnController : MonoBehaviour
{
    [SerializeField] GameObject crystal;
    [SerializeField] GameManager gameManager;
    [SerializeField] List<Transform> spawnPoints;

    GameObject currentCrystal = null;

    List<Transform> workingSpawns = new List<Transform>();

    public void SpawnNewCrystal() {
        if (currentCrystal != null) Destroy(currentCrystal);
        if (workingSpawns.Count == 0) workingSpawns = spawnPoints;
        int index = Random.Range(0, workingSpawns.Count);
        currentCrystal = Instantiate(crystal, workingSpawns[index], false);
        workingSpawns.RemoveAt(index);
    }
}

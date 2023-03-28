using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spinner : MonoBehaviour
{
    [SerializeField] float rotationSpeed;

    private float increaseAmount;
    private float timeElapsed;
    void Update() {
        timeElapsed += Time.deltaTime;
        increaseAmount = Mathf.Min(timeElapsed / 4, rotationSpeed * .75f);
        transform.RotateAround(transform.position, transform.up, Time.deltaTime * (rotationSpeed + increaseAmount));
    }
}

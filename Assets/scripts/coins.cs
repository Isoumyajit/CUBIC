using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class coins : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject Coin;
    public float rotateSpeed = 90f;

    private void OnTriggerEnter(Collider other) {
        
        if(other.gameObject.name != "Player"){

            return;
        }

        // Destroy coin
        Destroy(gameObject);
    }

    private void Update() {
        transform.Rotate(0, 0, rotateSpeed * Time.deltaTime);
    }
}

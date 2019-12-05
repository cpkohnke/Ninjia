using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Heart : MonoBehaviour
{
    //If Ninjia reached the hearts, it will disappear
    void OnTriggerEnter2D(Collider2D co) {
        if (co.name == "Ninjia")
            Destroy(gameObject);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    //If Ninjia reached the coins, it will disappear
    void OnTriggerEnter2D(Collider2D co) {
        if (co.name == "Ninjia")
            Destroy(gameObject);
    }
}

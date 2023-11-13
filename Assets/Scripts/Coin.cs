using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    int coin = 1;
    public PlayerMovement pm;

    private void FixedUpdate()
    {
        gameObject.transform.Rotate(new Vector3 (0,0,5));
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Player")
        {
            pm = other.GetComponentInParent<PlayerMovement>();
            pm.collectCoin(coin);
            Destroy(gameObject);
        }
    }
}

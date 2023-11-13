using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ObstacleCheck : MonoBehaviour
{
    PlayerMovement pm;
    public int damage = 1;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            pm = other.GetComponentInParent<PlayerMovement>();
            pm.decreaseHealth(damage);
        }
    }
}

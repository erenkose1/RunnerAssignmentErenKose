using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class Obstacle2 : MonoBehaviour
{
    PlayerMovement pm;
    public int damage = 2;
    bool isGoingBack = false;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            pm = other.GetComponentInParent<PlayerMovement>();
            pm.decreaseHealth(damage);
        }
    }
    private void FixedUpdate()
    {
        if (isGoingBack == false)
        {
            isGoingBack = true;
            gameObject.transform.DOLocalMoveX(gameObject.transform.localPosition.x - 3, 1);
            Invoke(nameof(goBack), 1);
        }
    }

    void goBack()
    {
        gameObject.transform.DOLocalMoveX(gameObject.transform.localPosition.x + 3, 1);
        Invoke(nameof(stopGoingBack), 1);
    }

    void stopGoingBack()
    {
        isGoingBack = false;
    }
}

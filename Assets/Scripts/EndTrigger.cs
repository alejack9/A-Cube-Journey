using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndTrigger : MonoBehaviour
{
    public GameManager gameManager;

    void OnTriggerEnter(Collider collider)
    {
        if(collider.tag.Equals("Player"))
            gameManager.EndLevel();
    }
}

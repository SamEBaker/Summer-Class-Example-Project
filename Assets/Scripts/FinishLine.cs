using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinishLine : MonoBehaviour
{
    public GameManager Manager;
    void OnTriggerEnter(Collider other)
    {
        if (other.name == "Player")
        {
            // end the game
            Manager.endGame();

        }
    }
}

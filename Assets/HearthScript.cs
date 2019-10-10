using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HearthScript : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D col)
    {
        if (GameControllerScript.health < 3)
        {
            GameControllerScript.health += 1;
            gameObject.SetActive(false);
        }
    }
}

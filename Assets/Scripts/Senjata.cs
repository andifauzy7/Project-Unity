using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Senjata : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.name == "pacman")
        {
            GameManager.dipakai += 1;
            GameObject[] senjata = GameObject.FindGameObjectsWithTag("senjata");
            Destroy(gameObject);
            if (GameManager.dipakai > 2)
                GameManager.dipakai = 0; /* Pengen ngebuat kalau isi tas udah sudah, maka muncul pesan   */
        }
    }
}

using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Pacdot : MonoBehaviour
{
    public Text score;
    private int scoreValue = 0;
    void OnTriggerEnter2D(Collider2D collision)
    {

        if (collision.gameObject.tag == "pacdot")
        {
            collision.gameObject.SetActive(false);
            scoreValue += 10;
            //GameObject[] pacdots = GameObject.FindGameObjectsWithTag("pacdot");
            SetScore();
            //Destroy(gameObject);
        }
    }
    void SetScore()
    {
        score.text = "Score: " + scoreValue;
    }
}

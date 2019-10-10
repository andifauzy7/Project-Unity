using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public GameObject followTarget;	//
    private Vector3 targerPos;		//
    public float moveSpeed;			//
    // Start is called before the first frame update
    void Start()
    {


    }

    // Update is called once per frame
    void Update()
    {
        targerPos = new Vector3(followTarget.transform.position.x, followTarget.transform.position.y, -10f);
        transform.position = Vector3.Lerp(transform.position, targerPos, moveSpeed * Time.deltaTime);

    }
}

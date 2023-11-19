using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    int speed = 10;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
         transform.Translate(Vector3.left * speed * Time.deltaTime);

    if (transform.position.x <= -4)
    {
        transform.Translate(Vector3.right * speed * Time.deltaTime);
        Debug.Log("Working!");
    }

    }
}

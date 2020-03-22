using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paddle : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float movement = Input.GetAxis("Horizontal");

        transform.Translate(Vector2.right * movement * Time.deltaTime * 10);

        if (transform.position.x > 6.64f)
            transform.position = new Vector2(6.64f, transform.position.y);

        if (transform.position.x < -6.61f)
            transform.position = new Vector2(-6.61f, transform.position.y);
    }
}

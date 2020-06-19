using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class CubukKontrol : MonoBehaviour
{
    private float movement;
    public float speed;
    static public float fallSpeed = 2.3f;
    void Start()
    {
    }

    void Update()
    {
        transform.Translate(new Vector3(0, -fallSpeed * Time.deltaTime, 0));
        if (Input.GetAxisRaw("Horizontal") > 0.5f || Input.GetAxisRaw("Horizontal") < -0.5f)
        {
            transform.Translate(new Vector3(Input.GetAxisRaw("Horizontal")* speed * 0.0182451f, 0, 0));
        }

        if (transform.position.x >= 15.688573f)
        {
            transform.position = new Vector3(-14.324997f, transform.position.y, transform.position.z);
        }
        if (transform.position.x <= -15.688573f)
        {
            transform.position = new Vector3(14.324997f, transform.position.y, transform.position.z);
        }
    }
}

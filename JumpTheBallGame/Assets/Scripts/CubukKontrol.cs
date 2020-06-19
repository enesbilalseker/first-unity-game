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
            transform.Translate(new Vector3(Input.GetAxisRaw("Horizontal")* speed * Time.deltaTime, 0, 0));
        }
    }
}

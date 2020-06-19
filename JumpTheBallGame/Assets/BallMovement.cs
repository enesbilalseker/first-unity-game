using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallMovement : MonoBehaviour
{
    public float thrust;
    Rigidbody fizik;
    // Start is called before the first frame update
    void Start()
    {
        fizik = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
     
    }

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "Cubuk") { 
        Debug.Log("Oldu");
        fizik.AddForce(new Vector3(0, thrust * Time.deltaTime, 0));
        }
    }

}

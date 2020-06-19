using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TopMovement : MonoBehaviour
{
    public int thrust;
    private int coin;
    Rigidbody phy;
    // Start is called before the first frame update
    void Start()
    {
        coin = 0;
        phy = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
    
    }

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "coin")
        {
            coin++;
            Debug.Log("Coin: " + coin);
            Destroy(other.gameObject);
        }
        if (other.gameObject.tag == "orta")
        {
            phy.velocity = new Vector3(0, thrust, 0); 
        }

        else if (other.gameObject.tag == "sag")
        {
            phy.velocity = new Vector3(5, thrust, 0);

        }

        else if (other.gameObject.tag == "sol")
        {
            phy.velocity = new Vector3(-5, thrust, 0);
        }
    }
}

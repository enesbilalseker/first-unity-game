using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BorderControl : MonoBehaviour
{
    static public int destroyCount;
    void Start()
    {
        destroyCount = 0;
    }

    void Update()
    {
        
    }
    void OnTriggerExit(Collider other)
    {
       
        if (other.gameObject.tag == "sol" || other.gameObject.tag == "sag" || other.gameObject.tag == "orta") 
        {
            destroyCount++;
            Debug.Log("DestroyCount: " + destroyCount);
            if(destroyCount % 27 == 0)
            {
                CubukKontrol.fallSpeed *= 1.02f;
            }
            Destroy(other.transform.root.gameObject);
        }
    }
}

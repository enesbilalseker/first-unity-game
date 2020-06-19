using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BorderControl : MonoBehaviour
{
    static public int destroyCount;
    static public float deger;
    void Start()
    {
        destroyCount = 0;
        deger = 1.25f;
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
            if(destroyCount%9 == 0)
            {
                CubukKontrol.fallSpeed *= 1.25f;
                deger = deger - deger/4;    
            }
            Debug.Log("Yok Edildi");
            Destroy(other.transform.root.gameObject);
        }
    }
}

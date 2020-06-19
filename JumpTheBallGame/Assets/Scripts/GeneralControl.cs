using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GeneralControl : MonoBehaviour
{
    static public int randomSayi;
    void Start()
    {
        randomSayi = Random.Range(4, -4);
    }

    void Update()
    {
        randomSayi = Random.Range(4, -4);
    }
}

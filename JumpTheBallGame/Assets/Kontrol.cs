using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Kontrol : MonoBehaviour
{
    public GameObject cubuk;
    int randomSayi;
    // Start is called before the first frame update
    void Start()
    {
        randomSayi = Random.Range(-4, 4);
        InvokeRepeating("CubukGenerate", 1.0f, BorderControl.deger);

    }

    // Update is called once per frame
    void Update()
    {
        randomSayi = Random.Range(-4, 4);
        
    }

    void CubukGenerate()
    {
        GameObject yaratilan = Instantiate(cubuk, new Vector3(randomSayi, 10, -1), Quaternion.identity);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Kontrol : MonoBehaviour
{
    public float aralik;
    public int generateY;
    public int generateZ;
    public GameObject cubuk;
    List<GameObject> cubuklar;
    void Start()
    {
        StartCoroutine(CubukDalgasi());

    }

    void Update()
    {
        
    }

    void CubukGenerateYukaridan()
    {
        float mesafe = 9.55f;
        GameObject obj0, obj1, obj2, obj3, obj4, obj5, obj6, obj7, obj8;
        obj0 = Instantiate(cubuk) as GameObject;
        obj0.transform.position = new Vector3(GeneralControl.randomSayi, generateY, generateZ);
        obj1 = Instantiate(cubuk) as GameObject;
        obj1.transform.position = new Vector3(GeneralControl.randomSayi + mesafe, generateY, generateZ);
        obj2 = Instantiate(cubuk) as GameObject;
        obj2.transform.position = new Vector3(GeneralControl.randomSayi + mesafe * 2, generateY, generateZ);
        obj3 = Instantiate(cubuk) as GameObject;
        obj3.transform.position = new Vector3(GeneralControl.randomSayi + mesafe * 3, generateY, generateZ);
        obj4 = Instantiate(cubuk) as GameObject;
        obj4.transform.position = new Vector3(GeneralControl.randomSayi + mesafe * 4, generateY, generateZ);
        obj5 = Instantiate(cubuk) as GameObject;
        obj5.transform.position = new Vector3(GeneralControl.randomSayi - mesafe, generateY, generateZ);
        obj6 = Instantiate(cubuk) as GameObject;
        obj6.transform.position = new Vector3(GeneralControl.randomSayi - mesafe * 2, generateY, generateZ);
        obj7 = Instantiate(cubuk) as GameObject;
        obj7.transform.position = new Vector3(GeneralControl.randomSayi - mesafe * 3, generateY, generateZ);
        obj8 = Instantiate(cubuk) as GameObject;
        obj8.transform.position = new Vector3(GeneralControl.randomSayi - mesafe * 4, generateY, generateZ);


    }
    IEnumerator CubukDalgasi()
    {
        while (true) 
        {               //1.2540847 - ilk iki cubuk arasindaki mesafe(bu baz alinarak yapilmistir)
            float deger = 1.2540847f / CubukKontrol.fallSpeed;
            yield return new WaitForSeconds(deger*aralik);
            CubukGenerateYukaridan();
        }
    }
}

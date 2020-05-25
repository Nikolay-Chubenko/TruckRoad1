using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Car2_Car3_NoSnow : MonoBehaviour
{
    public GameObject CAR2;
    public GameObject CAR3;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "CAR2")
        {
            Destroy(CAR2);
            CAR3.SetActive(true);
        }
    }
}

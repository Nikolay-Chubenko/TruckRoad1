using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NoSnow_Car : MonoBehaviour
{
    public GameObject Car;
    public GameObject Car1;
    public GameObject NoSnow;
    public GameObject okl;
    // Start is called before the first frame update
    bool start = false;
    float i = 6;
    // Update is called once per frame
    void Update()
    {
        if (start==true)
        {
            i -= Time.deltaTime;
        }

        if (i<0)
        {
            Car.SetActive(false);
            Car1.SetActive(true);
        }
        

    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            okl.SetActive(false);
            NoSnow.SetActive(true);
            start = true;
        }
    }
}

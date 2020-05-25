using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoCar : MonoBehaviour
{
    public GameObject Truck;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        this.transform.position = Vector3.MoveTowards(this.transform.position, new Vector3(Truck.transform.position.x, 0.3f, Truck.transform.position.z ), 3.8f * Time.deltaTime);
    }
}

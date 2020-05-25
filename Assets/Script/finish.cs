using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class finish : MonoBehaviour
{
    public GameObject okl1;
    public GameObject Canvas;
    public GameObject Canvas_NO;
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
        if (other.tag == "Player")
        {
            if(okl1.activeInHierarchy == false)
            {
                Canvas.SetActive(true);
            }
            else
            {
                Canvas_NO.SetActive(true);
            }
                
            //Debug.Log("entered");
        }
    }
}

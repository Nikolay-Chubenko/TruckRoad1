using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NoSnow : MonoBehaviour
{
    public GameObject Snow1;
    public GameObject Snow2;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {
            Snow1.SetActive(true);
            Snow2.SetActive(true);
            //Debug.Log("entered");
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            Snow1.SetActive(false);
            Snow2.SetActive(false);
            //Debug.Log("entered");
        }
    }
}

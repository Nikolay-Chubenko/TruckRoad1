using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Instantiate_big_snow : MonoBehaviour
{
    public GameObject Snow;
    int i;
    // Start is called before the first frame update
    void Start()
    {
        i = 0;
    }

    // Update is called once per frame
    void Update()
    {
        i++;
        if (i > 30)
        {
            var S1 = Instantiate(Snow);
            S1.transform.position = new Vector3(this.transform.position.x-27f, 0.3f, this.transform.position.z);
            i = 0;
        }

    }
}

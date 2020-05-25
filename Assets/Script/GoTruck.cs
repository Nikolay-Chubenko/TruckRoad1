using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class GoTruck : MonoBehaviour
{
    public GameObject forward;
    public Vector3 pos;
    public GameObject NoSnow;

    public GameObject Snow_big1;
    public GameObject Snow_big2;

    public GameObject Snow;
    // Start is called before the first frame update
    void Start()
    {
        pos = this.transform.position;
    }
   
    // Update is called once per frame
    Vector2 moveDirection = Vector2.zero;
    void Update()
    {
        var fingerCount = 0;
        foreach (Touch touch in Input.touches)
        {
            if (touch.phase != TouchPhase.Ended && touch.phase != TouchPhase.Canceled)
            {
                fingerCount++;
            }
        }
        if (fingerCount > 0)
        {
            //print("User has " + fingerCount + " finger(s) touching the screen");
        }
        if (Input.touchCount > 0)
        {
            Touch myTouch = Input.GetTouch(0);
            if (myTouch.phase == TouchPhase.Moved && myTouch.phase != TouchPhase.Ended && myTouch.phase != TouchPhase.Canceled)
            {
                Vector2 positionChange = myTouch.deltaPosition;
                positionChange.y = -positionChange.y;
                //Debug.Log(positionChange);
                //forward.transform.position = new Vector3(forward.transform.position.x+positionChange.x, forward.transform.position.y, forward.transform.position.z);
                //positionChange.x = 0;
                moveDirection = positionChange.normalized;
                Debug.Log(moveDirection);
                forward.transform.position = new Vector3(forward.transform.position.x + positionChange.x / 20, forward.transform.position.y, forward.transform.position.z);


            }
        }
        else
        {
            forward.transform.position = new Vector3(0, forward.transform.position.y, forward.transform.position.z);
        }
            this.transform.position = Vector3.MoveTowards(this.transform.position, new Vector3(this.transform.position.x+forward.transform.position.x, this.transform.position.y, this.transform.position.z+15), 4 * Time.deltaTime);
            if (Math.Abs(pos.z - this.transform.position.z) > 1)
            {
                pos = this.transform.position;
                var go = Instantiate(NoSnow);
                go.transform.position = new Vector3(pos.x, 0.3f, pos.z+2);
            }
        }
    
}


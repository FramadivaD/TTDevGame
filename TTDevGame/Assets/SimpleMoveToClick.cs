using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SimpleMoveToClick : MonoBehaviour
{
    bool move=false;
    public Transform Cam;
    Vector2 touchPos;
    
    // Start is called before the first frame update
    void Start()
    {
    
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.touchCount>0)
        {
            Touch touch=Input.GetTouch(0);
            touchPos=Camera.main.ScreenToWorldPoint(touch.position);

            if(touch.phase==TouchPhase.Began)
            {
                Cam.position=touchPos;
                move=true;
            }
            if(touch.phase==TouchPhase.Ended)
            {
                move=false;
            }
        }
        if(move)
        {
            transform.position=Vector2.MoveTowards(transform.position,touchPos,0.5f);
        }
    }

}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwipeMove : MonoBehaviour {

    private Vector2 startTouchPosition, endTouchPosition;

    
    public float sayımartı = 1.74f;

    // Update is called once per frame
    private void Update()
    {
        
    }

    private void OnMouseDown()
    {
        if (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Began)
            startTouchPosition = Input.GetTouch(0).position;





        if (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Ended)
        {
            endTouchPosition = Input.GetTouch(0).position;

            if ((endTouchPosition.x < startTouchPosition.x) && transform.position.x > -sayımartı)
                transform.position = new Vector2(transform.position.x - sayımartı, transform.position.y);

            if ((endTouchPosition.x > startTouchPosition.x) && transform.position.x < sayımartı)
                transform.position = new Vector2(transform.position.x + sayımartı, transform.position.y);
        }
    }

}

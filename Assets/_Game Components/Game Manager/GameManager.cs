using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {

    GameObject hitReciever;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public bool SomethingIsHit()
    {
        //if (Input.GetMouseButtonDown(0))
        //{
            //
            RaycastHit2D hit = Physics2D.Raycast(Input.mousePosition, Vector2.zero);

            // if ray has hit something with a collider
            if (hit.collider != null)
            {
                //Debug.Log(hit.collider.gameObject.name);

                hitReciever = hit.collider.gameObject;      //init / re-init the hitReciever, storing the object which got hit the latest.
                //seqM.GetObjectNumber(hitReciever);
                return true;
            }
        //}
        return false;
    }

    //getter method for the hitReciver gameObject
    public GameObject GetHitObject() { return hitReciever; }
}

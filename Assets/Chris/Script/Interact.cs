using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interact : MonoBehaviour
{
    // Start is called before the first frame update

    public Transform Player;
    public Transform Bob;
    public Transform Bobby;
    public Transform Kelly;
    public Transform Ben;

    //public bool BobActive = false;
    //public bool BobbyActive = false;
    //public bool KellyActive = false;

    float distanceBob, distanceBobby, distanceKelly,distanceBen;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        distanceBobby = Vector2.Distance(Player.position, Bobby.position);
        distanceBob = Vector2.Distance(Player.position, Bob.position);
        distanceBen = Vector2.Distance(Player.position, Ben.position);
        distanceKelly = Vector2.Distance(Player.position, Kelly.position);
        //distanceKelly = Vector2.Distance(Player.position, Bob.position);

        //Debug.Log("Distance " + distanceBob);

        if (distanceBobby < 1.0f)
        {
            if (Input.GetKey(KeyCode.E))
            {
                Debug.Log("HI Ryder, from Bobby");
                Debug.Log("Bobby" + distanceBobby);
            }
        }

        if (distanceBob < 1.0f)
        {
            if (Input.GetKey(KeyCode.E))
            {
                Debug.Log("HI Ryder, from Bob");
                Debug.Log("Bob" + distanceBob);
            }
        }

        if (distanceBen < 1.0f)
        {
            if (Input.GetKey(KeyCode.E))
            {
                Debug.Log("HI Ryder, from Ben");
                Debug.Log("Ben" + distanceBen);
            }
        }

        if (distanceKelly < 1.0f)
        {
            if (Input.GetKey(KeyCode.E))
            {
                Debug.Log("HI Ryder, from Kelly");
                Debug.Log("Kelly" + distanceKelly);
            }
        }


    }
}
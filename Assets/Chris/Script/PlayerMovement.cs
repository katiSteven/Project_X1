using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;

public class PlayerMovement : MonoBehaviour
{
	public int Speed;
    float move;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 movement = new Vector3(CrossPlatformInputManager.GetAxisRaw("Horizontal"), CrossPlatformInputManager.GetAxisRaw("Vertical"), 0.0f);
        transform.position = transform.position + movement * Speed * Time.deltaTime;

        
    }
}

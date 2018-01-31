using ScriptableFramework.Variables;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseFollower : MonoBehaviour {

    public BoolReference IsItem;
    public int toAdd;

    // Use this for initialization
    void Start ()
    {
		
	}
	
	// Update is called once per frame
	void FixedUpdate ()
    {
        if (IsItem.Value)
        {
            transform.position = new Vector3(
                Input.mousePosition.x - (toAdd + 150),
                Input.mousePosition.y + toAdd,
                Input.mousePosition.z);
        } else
        {
            transform.position = new Vector3(
                Input.mousePosition.x - (toAdd + 150),
                Input.mousePosition.y - toAdd,
                Input.mousePosition.z);
        }
	}
}

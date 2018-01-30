using ScriptableFramework.Variables;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseFollower : MonoBehaviour {

    public BoolReference IsItem;

	// Use this for initialization
	void Start ()
    {
		
	}
	
	// Update is called once per frame
	void FixedUpdate ()
    {
        int toAdd;
        if (IsItem.Value)
        {

        }
        toAdd = -120;

        transform.position = new Vector3(
            Input.mousePosition.x + toAdd,
            Input.mousePosition.y + toAdd,
            Input.mousePosition.z + toAdd);
	}
}

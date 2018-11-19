using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirstCamera : MonoBehaviour
{
    public static bool Ca_Sw = false;
    private void OnMouseUp()
    {
        if (Ca_Sw == true)
        {
            Ca_Sw = false;
            Debug.Log("tr");
        }
        else
            Ca_Sw = true;

    }

    // Use this for initialization
    void Start ()
    {
        Ca_Sw = false;
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}

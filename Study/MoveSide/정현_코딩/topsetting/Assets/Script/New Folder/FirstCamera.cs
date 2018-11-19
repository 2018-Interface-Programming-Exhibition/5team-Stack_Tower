using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirstCamera : MonoBehaviour
{
    GameObject Bar , Aim;

    public static bool Ca_Sw = false;
    private void OnMouseUp()
    {
        Bar = GameObject.Find("Bar");
        Aim = GameObject.Find("Aim");
        if (Ca_Sw == true)
        {
            Ca_Sw = false;
            Debug.Log("tr");
            Renderer b_renderer = Bar.GetComponent<Renderer>();
            Renderer a_renderer = Aim.GetComponent<Renderer>();
            b_renderer.material.color = new Color(b_renderer.material.color.r, b_renderer.material.color.g, b_renderer.material.color.b, 1f);
            a_renderer.material.color = new Color(a_renderer.material.color.r, a_renderer.material.color.g, a_renderer.material.color.b, 1f);

        }
        else
        {
            Ca_Sw = true;
            Renderer b_renderer = Bar.GetComponent<Renderer>();
            Renderer a_renderer = Aim.GetComponent<Renderer>();
            b_renderer.material.color = new Color(b_renderer.material.color.r, b_renderer.material.color.g, b_renderer.material.color.b, 0.5f);
            a_renderer.material.color = new Color(a_renderer.material.color.r, a_renderer.material.color.g, a_renderer.material.color.b, 0.5f);
        }
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

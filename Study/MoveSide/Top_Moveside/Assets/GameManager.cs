using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {
    public GameObject Bird2,Bird1;
    public Transform randomT;
    int cnt1 = 0;
    float delta = 1.5f;
    public void Drop()
    {

    }
	// Use this for initialization
	void Start ()
    {
		
	}

	// Update is called once per frame
	void Update () {

        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (cnt1 == 0)
            {
                randomT.position = new Vector3(Random.Range(-3.9f, 3.8f), 3.32f+delta, 9.88f);
                GameObject.Find("Bird2").SendMessage("Drop_on");
                Instantiate(Bird1, randomT.position, Quaternion.identity);
                delta += 1.5f;
                cnt1++;
            }
            else
            {
                randomT.position = new Vector3(Random.Range(-3.9f, 3.8f), 3.32f+delta, 9.88f);
                GameObject.Find("Bird1").SendMessage("Drop_on");
                Instantiate(Bird2, randomT.position, Quaternion.identity);
                cnt1--;
                delta += 1.5f;
            }
        
        }
    }
}
//GameObject.Find("GameManager").SendMessage("    RestartGame    ");
//RestartGame 이라는 메소드를 불러온다.
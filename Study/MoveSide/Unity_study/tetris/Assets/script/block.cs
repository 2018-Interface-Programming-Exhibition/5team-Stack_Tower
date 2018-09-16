using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class block : MonoBehaviour {

    float fall = 0;
    public float fallSpeed = 1;

    public bool allowRotation = true;
    public bool limitRotation = false;
	// Use this for initialization
	void Start ()
    {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
        CheckUserInput();
	}
    void CheckUserInput()
    {
        if (Input.GetKeyDown(KeyCode.RightArrow)) // 오른쪽 버튼 누름
        {

            transform.position += new Vector3(1, 0, 0);
            if (CheckIsValidPosition()) // 위치가 갈수있는 위치라면
            {
                FindObjectOfType<Game>().UpdateGrid(this);
            }
            else // 갈수 없는 위치라면
            {
                transform.position += new Vector3(-1, 0, 0);
            }
        }
        else if (Input.GetKeyDown(KeyCode.LeftArrow)) // 왼쪽 버튼 누름
        {
            transform.position += new Vector3(-1, 0, 0);
            if (CheckIsValidPosition()) // 위치가 갈수있는 위치라면
            {
                FindObjectOfType<Game>().UpdateGrid(this);
            }
            else // 갈수 없는 위치라면
            {
                transform.position += new Vector3(1, 0, 0);
            }
        }
        else if (Input.GetKeyDown(KeyCode.UpArrow)) // 위 누름
        {
            if (allowRotation) // 회전하는 경우가 있다면
            {
                if (limitRotation) // 도형이 2가지 방향만 가질때
                {
                    if (transform.rotation.eulerAngles.z >= 90)
                    {
                        transform.Rotate(0, 0, -90);
                    }
                    else
                    {
                        transform.Rotate(0, 0, 90);
                    }

                }
                else
                {
                    transform.Rotate(0, 0, 90);
                }
                if (CheckIsValidPosition()) // 위치가 갈수있는 위치라면
                {
                    FindObjectOfType<Game>().UpdateGrid(this);
                }
                else // 갈수 없는 위치라면
                {
                    if (limitRotation)
                    {
                        if (transform.rotation.eulerAngles.z >= 90)
                        {
                            transform.Rotate(0, 0, -90);
                        }
                        else
                        {
                            transform.Rotate(0, 0, 90);
                        }
                    }
                    else
                    {
                        transform.Rotate(0, 0, -90);
                    }

                }

            }
             

        }
        else if (Input.GetKeyDown(KeyCode.DownArrow)) // 아래 누름 or 시간 지남 
        {
            transform.position += new Vector3(0, -1, 0);
            if (CheckIsValidPosition()) // 위치가 갈수있는 위치라면
            {
                FindObjectOfType<Game>().UpdateGrid(this);

            }
            else // 갈수 없는 위치라면
            {
                transform.position += new Vector3(0, 1, 0);

                FindObjectOfType<Game>().DeleteRow();
                enabled = false; // 이 함수를 비활성화 시킴

                FindObjectOfType<Game>().SpawnNextBlock();
            }
            fall = Time.time; // fall을 넣어 time-fall = 0 으로 함
        }
        else if (Input.GetKeyDown(KeyCode.Space)) // 스페이스바 누름
        {
            while (CheckIsValidPosition())
            {
                transform.position += new Vector3(0, -1, 0);
            }
            transform.position += new Vector3(0, 1, 0);
            FindObjectOfType<Game>().UpdateGrid(this);
            FindObjectOfType<Game>().DeleteRow();
            enabled = false; // 이 함수를 비활성화 시킴
            FindObjectOfType<Game>().SpawnNextBlock();
        }
    }




    bool CheckIsValidPosition() // 위치가 잘못되면 false 반환
    {
        foreach (Transform mino in transform) // 각각 블럭의 위치를 불러와서 검사
        {
            Vector2 pos = FindObjectOfType<Game>().Round(mino.position); 
            
            if (FindObjectOfType<Game>().CheckIsInsideGrid(pos) == false)
            {
                return false; 
            }
            if (FindObjectOfType<Game>().GetTransformAtGridPosition(pos) != null && FindObjectOfType<Game>().GetTransformAtGridPosition(pos).parent != transform)
            {
                return false;
            }

        }

        return true;
    }
}

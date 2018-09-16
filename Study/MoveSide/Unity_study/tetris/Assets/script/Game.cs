using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Game : MonoBehaviour {

    public static int gridWidth = 10;
    public static int gridHeight = 20;

    public static Transform[,] grid = new Transform[gridWidth, gridHeight];
    // Use this for initialization
    void Start ()
    {
        SpawnNextBlock ();
	}
    // 여기부터 줄 삭제 함수
    public bool IsFullRowAt(int y)
    {
        for (int x = 0; x < gridWidth; ++x)
        {
            if (grid[x, y] == null)
            {
                return false;
            }
        }
        return true;
    }
    public void DeleteMinoAt(int y)
    {
        for (int x = 0; x < gridWidth; ++x)
        {
            Destroy(grid[x, y].gameObject);
            grid[x, y] = null;
        }
    }

    public void MoveRowDown(int y)
    {
        for (int x = 0; x < gridWidth; ++x)
        {
            if (grid[x, y] != null)
            {
                grid[x, y - 1] = grid[x, y];
                grid[x, y] = null;
                grid[x, y - 1].position += new Vector3(0, -1, 0);
            }
        }
    }
    public void MoveAllRowsDown(int y)
    {
        for (int i = y; i < gridHeight; ++i)
        {
            MoveRowDown(i);
        }
    }
    public void DeleteRow()
    {
        for (int y = 0; y < gridHeight; ++y)
        {
            if (IsFullRowAt(y))
            {
                DeleteMinoAt(y);
                MoveAllRowsDown(y + 1);
                --y;
            }
        }
    }
    // 요기까지
    public void UpdateGrid(block tetromino) // 블럭 인식 함수
    {
        for (int y = 0; y < gridHeight; ++y)
        {
            for (int x = 0; x < gridWidth; ++x)
            {
                if (grid[x, y] != null)
                {
                    if (grid[x, y].parent == tetromino.transform)
                    {
                        grid[x, y] = null;
                    }
                }
            }
        }
        foreach (Transform mino in tetromino.transform)
        {
            Vector2 pos = Round(mino.position);
            if (pos.y < gridHeight)
            {
                grid[(int)pos.x, (int)pos.y] = mino;
            }
        }
    }

    public Transform GetTransformAtGridPosition(Vector2 pos)
    {
        if (pos.y > gridHeight - 1)
        {
            return null;
        }
        else
        {
            return grid[(int)pos.x, (int)pos.y];
        }
    }
    public void SpawnNextBlock () // 블럭 스폰함수
    {
        GameObject nextBlock = (GameObject)Instantiate(Resources.Load(GetRandomBlock(), typeof(GameObject)), new Vector2(5.0f, 20.0f), Quaternion.identity);
    }

    public bool CheckIsInsideGrid(Vector2 pos) // pos가 게임창 안에 있는지 확인함
    {
        return ((int)pos.x >= 0 && (int)pos.x < gridWidth && (int)pos.y >= 1);
    }

    public Vector2 Round(Vector2 pos) // pos 를 round(반올림) 해서 반환함
    {
        return new Vector2(Mathf.Round(pos.x), Mathf.Round(pos.y)); 
    }

    string GetRandomBlock() // 랜덤 블럭 리턴 함수
    {
        int randomBlock = Random.Range(1,8);
        string randomBlockName = "maden_block/Block1";
        Debug.Log(randomBlock);
        
        switch (randomBlock)
        {
            case 1:
                randomBlockName = "maden_block/Block1";
                break;
            case 2:
                randomBlockName = "maden_block/Block2";
                break;
            case 3:
                randomBlockName = "maden_block/Block3";
                break;
            case 4:
                randomBlockName = "maden_block/Block4";
                break;
            case 5:
                randomBlockName = "maden_block/Block5";
                break;
            case 6:
                randomBlockName = "maden_block/Block6";
                break;
            case 7:
                randomBlockName = "maden_block/Block7";
                break;
        }
        Debug.Log(randomBlockName);

        return randomBlockName;

        }
    
}

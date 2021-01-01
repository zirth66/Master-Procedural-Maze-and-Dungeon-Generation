using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Maze : MonoBehaviour
{
    
    [Range(0, 100)]
    public int width = 30; // x length
    [Range(0, 100)]
    public int depth = 30; // y length
    public byte[,] map;

    // Start is called before the first frame update
    void Start()
    {
        InitialiseMap(); // Sets everthing to walls
        Generate(); // Digs corridors
        DrawMap();
    }
    void InitialiseMap()
    {
        map = new byte[width, depth];
        for (int z = 0; z < depth; z++)
        {
            for (int x = 0; x < width; x++)
            {
                    map[x, z] = 1; // 1 = wall, 0 = corridor           
            }
        }
    }

    public virtual void Generate() // public virtual so we can ovveride it in Crawler.cs
    {
        for (int z = 0; z < depth; z++)
        {
            for (int x = 0; x < width; x++)
            {

                if (Random.Range(0, 100) < 50)
                {
                    map[x, z] = 0; // 1 = wall, 0 = corridor    
                }
            }
        }
    }

    void DrawMap()
    {
        for (int z = 0; z < depth; z++)
        {
            for (int x = 0; x < width; x++)
            {
                if (map[x, z] == 1)
                {
                    Vector3 pos = new Vector3(x, 0, z);
                    GameObject wall = GameObject.CreatePrimitive(PrimitiveType.Cube);
                    wall.transform.position = pos;
                }
            }
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}

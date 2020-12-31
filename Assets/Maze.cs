using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Maze : MonoBehaviour
{
    public GameObject cube;
    [Range(0, 100)]
    public int width = 30; // x length
    [Range(0, 100)]
    public int depth = 30; // y length

    // Start is called before the first frame update
    void Start()
    {
        for(int z = 0; z < depth; z++)
        {
            for (int x = 0; x < width; x++)
            {
                Vector3 pos = new Vector3(x, 0, z);
                Instantiate(cube, pos, Quaternion.identity);
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

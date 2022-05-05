using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenerateCubes : MonoBehaviour
{
    public GameObject cube;
    private List<GameObject> cubes = new List<GameObject>();

    public int stageNum;
    
    // Start is called before the first frame update
    void Start()
    {
        GenerateCube();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void GenerateCube()
    {
        int rnd = Random.Range(4, 9);

        while (cubes.Count > 0)
        {
            Destroy(cubes[0]);
            cubes.RemoveAt(0);
        }
        
        for (int i = 0; i < rnd; i++)
        {
            GameObject tmp = Instantiate(cube);
            if (stageNum == 1 || stageNum == 2)
            {
                tmp.transform.localScale =
                    new Vector3(Random.Range(0.3f, 1.5f), Random.Range(0.3f, 1.5f), Random.Range(0.3f, 1.5f));
            }
            else if (stageNum == 3)
            {
                tmp.transform.localScale =
                    new Vector3(Random.Range(0.8f, 3.0f), Random.Range(0.8f, 3.0f), Random.Range(0.8f, 8.0f));
            }

            tmp.GetComponent<Rigidbody>().velocity = new Vector3(0, 0.1f, 0);
            tmp.GetComponent<Renderer>().material.color = Color.white;
            cubes.Add(tmp);
            tmp.transform.position = new Vector3(Random.Range(-4, 5), 4, Random.Range(-4, 5));
        }
    }

    public void DestroyCube()
    {
        while (cubes.Count > 0)
        {
            Destroy(cubes[0]);
            cubes.RemoveAt(0);
        }
    }
}

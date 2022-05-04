using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenerateCubes : MonoBehaviour
{
    public GameObject cube;
    private List<GameObject> cubes = new List<GameObject>();

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
            tmp.transform.localScale =
                new Vector3(Random.Range(0.3f, 1.5f), Random.Range(0.3f, 1.5f), Random.Range(0.3f, 1.5f));
            tmp.GetComponent<Rigidbody>().velocity = new Vector3(0, 0.1f, 0);
            tmp.GetComponent<Renderer>().material.color = new Color(255, 255, 255);
            cubes.Add(tmp);
            tmp.transform.position = new Vector3(Random.Range(-4, 5), 4, Random.Range(-4, 5));
        }
    }
}

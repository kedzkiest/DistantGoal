using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JudgeClear : MonoBehaviour
{
    public GameObject player;

    public static bool clearFlag;

    // Start is called before the first frame update
    void Start()
    {
        clearFlag = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Vector3.Distance(transform.position, player.transform.position) <= 0.1f)
        {
            clearFlag = true;
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_info : MonoBehaviour
{

    public float maxHight;
    // Start is called before the first frame update
    void Start()
    {
        maxHight = -10;
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position.y > maxHight)
        {
            maxHight = transform.position.y;
        }
    }
}

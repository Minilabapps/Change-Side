using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Platform_info : MonoBehaviour
{
    public float multiplier;
    // Start is called before the first frame update
    void Start()
    {
        
    }


    public void OnCollisionEnter2D(Collision2D other)
    {
        GetForce(other);
    }


    public void GetForce(Collision2D _other)
    {
        float x = Random.Range(-0.8f, 0.8f);
        if(x < 0.15f & x > 0)
        {
            x += 0.15f;
        }
        if(x > -0.15f & x < 0)
        {
            x -= 0.15f;
        }
        float y = Random.Range(0.4f, 0.8f);
        Rigidbody2D orb;
        orb = _other.gameObject.GetComponent<Rigidbody2D>();
        orb.AddForce(new Vector2(x, y) * multiplier, ForceMode2D.Impulse);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

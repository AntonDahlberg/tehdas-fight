using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float leftLimit = -40;
    public float rightlimit = 40;


    // Start is called before the first frame update


    // Update is called once per frame
    void Update()
    {
        if (transform.position.x < leftLimit)
        {
            Destroy(gameObject);
        }
        else if (transform.position.x > rightlimit)

            Destroy(gameObject);
    }







    public void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "Enemy")
        {
            Destroy(gameObject);
            


        }

    }
}

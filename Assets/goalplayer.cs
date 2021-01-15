using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class goalplayer : MonoBehaviour
{
    public int damage;
    goal Playerhp;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
     public void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "Player")
        {
            Playerhp = other.transform.GetComponent<goal>();
            Playerhp.Health -= damage;
            Destroy(gameObject);



        }

    }
}

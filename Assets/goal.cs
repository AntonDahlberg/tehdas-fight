using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class goal : MonoBehaviour
{
    public int Health;
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
        if (other.gameObject.tag == "maa")
        {
            if (Health <= 0)
            {

                Destroy(gameObject);

                Youwon();

            }







        }

    }
    public void Youwon()
    {
        SceneManager.LoadScene("You win");
    }
}

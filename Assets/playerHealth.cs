using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class playerHealth : MonoBehaviour
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
        if (other.gameObject.tag == "bullet1")
        {
            if (Health <= 0)
            {

                Destroy(gameObject);

                Youlose();

            }







        }

    }
    public void Youlose()
    {
        SceneManager.LoadScene("you lose");
    }
}

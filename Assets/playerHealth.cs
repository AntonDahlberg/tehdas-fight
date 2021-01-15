using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class playerHealth : MonoBehaviour
{
    public int Health;
    public Text heal;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        heal.text = Health.ToString();

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

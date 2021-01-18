using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class enemy : MonoBehaviour
{
    public GameObject[] obj;
    //public GameObject obj;
    public float spawnMin;
    public float spawnMax;
    public int Health;
    public int Enemyleft;
    public GameObject endgame;
    playerHealth Playerhp;
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
        if (other.gameObject.tag == "bullet")
        {
            if (Health <= 0)
            {
                
                
                    Destroy(gameObject);
                    endgame.gameObject.SetActive(false);

                

                    

            }
          
            
            
            



        }

    }
    void Spawn()

    {
        
        Instantiate(obj[Random.Range(0, obj.GetLength(0))], transform.position, Quaternion.identity);
        Invoke("Spawn", Random.Range(spawnMin, spawnMax));

    }
    public void Youwon()
    {
        SceneManager.LoadScene("You win");
    }
}

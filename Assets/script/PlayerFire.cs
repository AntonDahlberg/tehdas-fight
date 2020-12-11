using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerFire : MonoBehaviour
{

    public Rigidbody projectile;

    public float speed = 20;
    public Animator Aim;
    public Animator animator;

    public int maxAmmo = 10;
    public int currentAmmo;
    public float reloadTime = 1f;
    private bool isReloading = false;

    
    public AudioClip otherClip;
    private AudioSource playerAudio;


    // Use this for initialization
    void Start()
    {
        playerAudio = GetComponent<AudioSource>();

        currentAmmo = maxAmmo;
            
        
        
    }
    

    // Update is called once per frame
    void Update()
    {
        if (isReloading)
            return;
        if(currentAmmo <= 0)
        {
            StartCoroutine(reload());
            return;
        }
        
        

            if (Input.GetButtonDown("Fire1"))
            {
                Rigidbody instantiatedProjectile = Instantiate(projectile, transform.position, transform.rotation) as Rigidbody;

                instantiatedProjectile.velocity = transform.TransformDirection(new Vector3(0, 0, speed));
                playerAudio.PlayOneShot(otherClip, 1.0f);
                currentAmmo--;

        }
            if (Input.GetButtonDown("Fire2"))
            {
                Aim.SetTrigger("tahtain");

            }
            IEnumerator reload()
        {
            
            
                isReloading = true;
                Debug.Log("Reloading...");
                animator.SetBool("Reloading", true);

                yield return new WaitForSeconds(reloadTime - .25f);
                animator.SetBool("Reloading", false);
                yield return new WaitForSeconds(.25f);

                currentAmmo = maxAmmo;
                isReloading = false;
            
        
                
                
        }
        
        


    }
}


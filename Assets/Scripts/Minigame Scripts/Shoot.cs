using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour
{
    public bool canFire;
    private float timer;
    public float timeBetweenFiring;
    public GameObject projectilePrefab;
    public GameObject player;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Restrict firing
        if(!canFire){
            timer += Time.deltaTime;
            if(timer > timeBetweenFiring){
                canFire = true;
                timer = 0;
            }
        }

        // Shoot
        if (Input.GetKey(KeyCode.Space) && canFire){
            canFire = false;
            // player.transform.rotation
            Instantiate(projectilePrefab, transform.position, player.transform.rotation * Quaternion.Euler(0, 180, 0));
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class BallDestroyer : MonoBehaviour
{
    public int points = 1;
    

    // Start is called before the first frame update
    void Start()
    {
        
    }
    
    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter(Collision collision)
    {
        FindObjectOfType<Score>().Hit(this);
        this.gameObject.SetActive(false);
    } 

        
    
}

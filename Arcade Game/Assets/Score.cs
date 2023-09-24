using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Score : MonoBehaviour
{
    public int score = 0;
    public int total;
    // Start is called before the first frame update
    void Start()
    {
        score = 0;
    }
   
    
    // Update is called once per frame
    public void Update()
    {
    }
    public void Hit(BallDestroyer brick)
    {
        this.score += brick.points;
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RainGeneration : MonoBehaviour
{
    public GameObject rain;
    public GameObject rainGenerator;

    int x;
    Vector3 offset;
    float timer;
    
    void Update()
    {
        float deltaTime = Time.deltaTime / Time.timeScale;
        timer += deltaTime;

        //if timer >= 1, instantiate a raindrop at a random x value on screen
        if(timer >= 1){
            x = Random.Range(6, -6);
            offset = new Vector3 (x, 0, 0);

            Instantiate(rain, transform.position + offset, transform.rotation); 

            timer = 0;
        } 
    }
}

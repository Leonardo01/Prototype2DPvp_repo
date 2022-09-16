using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovimento : MonoBehaviour
{
    float speed = 20;
    bool CanMove = true;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(CanMove){
            movimento();
        }
        
    }

    void movimento(){
         
            float xInput = Input.GetAxis("Horizontal") * speed * Time.deltaTime;
            transform.Translate(xInput,0,0);

    }    
}

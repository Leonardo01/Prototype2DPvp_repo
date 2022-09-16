using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Backgroundscrolling : MonoBehaviour
{
    Material background;
    Vector2 offset;
    public float xVelocity,yVelocity;
    private void Awake(){
        background = GetComponent<Renderer>().material;
    }
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        offset = new Vector2(xVelocity,yVelocity);               
        background.mainTextureOffset += offset * Time.deltaTime;
    }


}

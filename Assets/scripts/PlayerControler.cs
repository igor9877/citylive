using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControler : MonoBehaviour
{
    public int speed = 6;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
      transform.Translate(new Vector3(0,0,1)*Time.deltaTime*speed);
    }
}

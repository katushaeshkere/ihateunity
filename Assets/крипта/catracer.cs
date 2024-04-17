using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class catracer : MonoBehaviour
{
   public float speed = 2.0f;
    void Start()
    {
        
    }

   
    void Update()
    {
        transform.Translate( Vector3.forward* Time.deltaTime * speed);
        
    }
}

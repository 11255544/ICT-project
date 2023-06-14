using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFolow : MonoBehaviour
{
 public transform targrt;
 
 private void LateUpdate();
 {
    if (target.position.y>transform.position.y)
    {
    Vector3 newPositon = new Vector3 (transform.position.x, target.position.y)
 // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

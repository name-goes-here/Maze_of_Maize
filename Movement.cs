using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour {

    //Change speed variable in unity editor during testing. No movement will happen at the dfault value (zero).
    public float speed;

    void Update(){
        transform.position += new Vector3(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical")) * speed * Time.deltaTime;
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour {

    //Change speed variable in unity editor during testing. No movement will happen at the default value (zero).
    public float speed = 5f;
    //Vector3 pos;

    private void Start() {
       // pos = transform.position;
    }

    void Update(){
        //transform.position += new Vector3(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical")) * speed * Time.deltaTime;
        float horz =Input.GetAxis("Horizontal");
        float vert =Input.GetAxis("Vertical");
        
        // POSITION SETTING
        //transform.position += (new Vector3(horz, vert, 0) * speed * Time.deltaTime);
        
        // VELOCITY SETTING
        GetComponent<Rigidbody2D>().velocity = (new Vector3(horz, vert, 0) * speed);
        
//        if (Input.GetKeyDown(KeyCode.D) || Input.GetKeyDown(KeyCode.RightArrow) && transform.position == pos) {
//            pos += Vector3.right;
//        } else if (Input.GetKeyDown(KeyCode.A) || Input.GetKeyDown(KeyCode.LeftArrow) && transform.position == pos) {
//            pos += Vector3.left;
//        } else if (Input.GetKeyDown(KeyCode.W) || Input.GetKeyDown(KeyCode.UpArrow) && transform.position == pos) {
//            pos += Vector3.up;
//        } else if (Input.GetKeyDown(KeyCode.S) || Input.GetKeyDown(KeyCode.DownArrow) && transform.position == pos) {
//            pos += Vector3.down;
//        }
//
//        transform.position = Vector3.MoveTowards(transform.position, pos, Time.deltaTime * speed);
    }
}

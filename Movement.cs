using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour {

    //Change speed variable in unity editor during testing. No movement will happen at the default value (zero).
    public float speed;
    Vector3 pos;

    private void Start() {
        pos = transform.position;
    }

    void Update(){
        //transform.position += new Vector3(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical")) * speed * Time.deltaTime;

        if (Input.GetKeyDown(KeyCode.D) && transform.position == pos) {
            pos += Vector3.right;
        } else if (Input.GetKeyDown(KeyCode.A) && transform.position == pos) {
            pos += Vector3.left;
        } else if (Input.GetKeyDown(KeyCode.W) && transform.position == pos) {
            pos += Vector3.up;
        } else if (Input.GetKeyDown(KeyCode.S) && transform.position == pos) {
            pos += Vector3.down;
        }

        transform.position = Vector3.MoveTowards(transform.position, pos, Time.deltaTime * speed);
    }
}

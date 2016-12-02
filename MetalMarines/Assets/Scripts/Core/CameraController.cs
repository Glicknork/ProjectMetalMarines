using UnityEngine;
using System.Collections;

public class CameraController : MonoBehaviour {

    public float speed = 1f;

	// Update is called once per frame
	void FixedUpdate () {

        if (Input.GetKey(KeyCode.W))
        {            
            transform.Translate(Vector3.forward * speed);
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(-Vector3.right * speed);
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(-Vector3.forward * speed);
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(Vector3.right * speed);
        }

    }
}

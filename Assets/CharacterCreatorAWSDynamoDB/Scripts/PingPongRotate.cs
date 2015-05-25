using UnityEngine;
using System.Collections;

public class PingPongRotate : MonoBehaviour
{
    public float speed;
    public float to;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update ()
	{
        // Simple rotation of the Z axis of a 2D Sprite to rotate it back and forth between 0 and the 'to' specified angles.
	    var rotationValue = Mathf.PingPong(Time.time * speed, to);
	    transform.eulerAngles = new Vector3(0, 0, rotationValue);

	}
}

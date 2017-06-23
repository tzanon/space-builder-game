
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    private float moveFactor = 15f;
    private float rotateFactor = 30f;


    void Start ()
    {
		
	}
	
	void Update ()
    {
        // moving/strafing
        if (Input.GetKey(KeyCode.W))
        {
            transform.position += (moveFactor * Time.deltaTime) * transform.forward.normalized;
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.position -= (moveFactor * Time.deltaTime) * transform.forward.normalized;
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.position += (moveFactor * Time.deltaTime) * transform.right.normalized;
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.position -= (moveFactor * Time.deltaTime) * transform.right.normalized;
        }

        // rotating
        if (Input.GetKey(KeyCode.UpArrow))
        {
            transform.Rotate(rotateFactor * Time.deltaTime * Vector3.left);
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            transform.Rotate(rotateFactor * Time.deltaTime * Vector3.right);
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.Rotate(rotateFactor * Time.deltaTime * Vector3.up);
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Rotate(rotateFactor * Time.deltaTime * Vector3.down);
        }

    }

}

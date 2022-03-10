using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateScript : MonoBehaviour
{

    [SerializeField]
    private float RotateSpeed = 100.5f;

    [SerializeField]
    private GameObject g;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.Rotate(0, 0, -1 * RotateSpeed * Time.deltaTime);

            //Good, but there is a better way
            //transform.Rotate(0, 0,-RotateSpeed * Time.deltaTime);

        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Rotate(0, 0, 1 * RotateSpeed * Time.deltaTime);

            //Good, but there is a better way
            //transform.Rotate(0, 0, RotateSpeed * Time.deltaTime);
        }
        //For Either side
        //transform.Rotate(0,0, Input.GetAxis("Horizontal") * rotateSpeed * Time.deltaTime);
    }
}

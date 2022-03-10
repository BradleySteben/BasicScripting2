using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeColor : MonoBehaviour
{
    [SerializeField]
    GameObject g;

    Renderer r;

    [SerializeField]
    [Range(0f, 1f)]
    float red, green, blue;

    // Start is called before the first frame update
    void Start()
    {
        r = g.GetComponent<Renderer>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.C))
        {
            r.material.color =  new Color(red, green, blue);
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivateDeactivate : MonoBehaviour
{
    [SerializeField]
    private GameObject g;

    void Start()
    {
        g = GameObject.Find("Baseball");
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.D))
        {
            g.SetActive(!g.activeSelf);
        }
    }
}

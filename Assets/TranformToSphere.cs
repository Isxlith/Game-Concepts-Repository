﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TranformToSphere : MonoBehaviour
{
    GameObject sphere;
    GameObject cube;

    // Start is called before the first frame update
    void Start()
    {
        sphere = GameObject.FindWithTag("Sphere");
        cube = GameObject.FindWithTag("Cube");
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.F))
        {
            if(sphere.active == true)
            {
                sphere.transform.localScale -= new Vector3(1.0f, 1.0f, 1.0f);
                cube.transform.localScale += new Vector3(0.5f, 0.5f, 0.5f);
                cube.transform.localPosition += sphere.transform.localPosition;
                cube.transform.localPosition += new Vector3(0.0f, 0.1f, 0.0f);
                cube.SetActive(true);
                sphere.SetActive(false);
            }
            else if (cube.active == true)
            {
                cube.transform.localScale -= new Vector3(1.0f, 1.0f, 1.0f);
                sphere.transform.localScale += new Vector3(1.0f, 1.0f, 1.0f);
                sphere.transform.localPosition += cube.transform.localPosition;
                sphere.transform.localPosition += new Vector3(0.0f, 0.1f, 0.0f);
                cube.SetActive(false);
                sphere.SetActive(true);
            }
        }
    }
}

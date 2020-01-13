﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotarPlataforma : MonoBehaviour
{
    public int rotationSpeed;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        this.gameObject.transform.Rotate(Vector3.forward, Time.deltaTime * rotationSpeed);
    }
}

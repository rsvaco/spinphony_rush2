using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateAround : MonoBehaviour
{

    public int rotationSpeed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        this.gameObject.transform.RotateAround(this.gameObject.transform.parent.transform.position, Vector3.up, Time.deltaTime * rotationSpeed);
    }
}

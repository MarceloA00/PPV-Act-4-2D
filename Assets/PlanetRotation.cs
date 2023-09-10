using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlanetRotation : MonoBehaviour
{

    public float orbitSpeed;
    public Transform pivot;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        transform.RotateAround(pivot.position, new Vector3(0,0,1), (orbitSpeed * Time.deltaTime));
    }
}

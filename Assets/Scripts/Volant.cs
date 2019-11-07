using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Volant : MonoBehaviour
{
    int Rot;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Rot = - Rotation.Instance.Rot;
        transform.localEulerAngles = new Vector3(0, 0, Rot);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateVehicule : MonoBehaviour
{


    int Rot;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(0, 0, 10);
        Rot = Rotation.Instance.Rot;
        print(Rot);
        transform.Rotate(0, Rot/15, 0);
    }
}

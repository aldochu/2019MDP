using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TopCamera : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        transform.position = new Vector3(10.8f, 20, 6.5f);
        transform.Rotate(90, -90, 0);
    }

}

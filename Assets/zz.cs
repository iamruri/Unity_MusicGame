using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class zz : MonoBehaviour
{
    public Vector3 clickPosition;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Input.GetMouseButtonDown(0);
        clickPosition = Input.mousePosition;

    }
}

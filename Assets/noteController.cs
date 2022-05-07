using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class noteController : MonoBehaviour
{
    void Update()
    {
        //フレームごとに等速で落下させる。
        this.transform.position += Vector3.down * 9.95f * Time.deltaTime;
        if (Input.GetMouseButtonDown(0))
        {
            Destroy(gameObject);
        }
        
        if(Input.GetMouseButtonDown(1))
        {
            Destroy(gameObject);
        }
        //transform.Translate(0, -0.2f, 0);
        if (transform.position.y < -3.1f)
        {
            Destroy(gameObject);
        }
    }
}
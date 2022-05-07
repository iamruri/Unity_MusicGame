using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hantei : MonoBehaviour
{
    //public ButtonController bc;
    [SerializeField] GameObject good;
    [SerializeField] GameObject bad;
    public float hyouji_time = 0.3f;
    float time = 0f;

    void Start()
    {
    }
    void Update()
    {
        time += Time.deltaTime;
        Vector3 localPos = GameObject.Find("赤ノーツ(Clone)").transform.position; //座標を取得
        float NotePositionY = localPos.y;
        float NotePositionX = localPos.x;

        if (NotePositionY < 0f && NotePositionY > -3.0f && NotePositionX == 0.9f)
        {
            if (Input.GetMouseButtonDown(0))
            {
                if (Input.mousePosition.x >= Screen.width / 2)
                {
                    good.SetActive(true);
                }
                else
                {
                    bad.SetActive(true);
                }
            }
        }
        
        if(NotePositionY < 0f && NotePositionY > -3.0f && NotePositionX == -0.9f)
        {
            if (Input.GetMouseButtonDown(0))
            {
                if (Input.mousePosition.x <= Screen.width / 2)
                {
                    good.SetActive(true);
                }
                else
                {
                    bad.SetActive(true);
                }
            }
        }

        if (NotePositionY < -3.0f)
        {
            bad.SetActive(true);
        }

        if (time >= hyouji_time)
        {
            good.SetActive(false);
            bad.SetActive(false);
            time = 0f;
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class notegenerator : MonoBehaviour
{
    public GameObject notePrefabRED1;
    public GameObject notePrefabRED2;
    public GameObject notePrefabRED3;
    public GameObject notePrefabRED4;
    public GameObject notePrefabRED5;
    public GameObject notePrefabBLUE1;
    public GameObject notePrefabBLUE2;
    public GameObject notePrefabBLUE3;
    public GameObject notePrefabBLUE4;
    public GameObject notePrefabBLUE5;
    public GameObject notePrefabYELLOW1;
    public GameObject notePrefabYELLOW2;
    public GameObject notePrefabYELLOW3;
    public GameObject notePrefabYELLOW4;
    public GameObject notePrefabYELLOW5;
    public loadScript load;
    private int x = 0, y = 0, note;
    public float delta = 0;
    public int end;

    void Start()
    {
    }

    void Update()
    {
        if (load.end == 1)
        {
            this.delta += Time.deltaTime;
            if (load.time[x] < this.delta)
            {
                switch (load.note[x])
                {
                    case 1:
                        switch (load.line[x])
                        {
                            case 1:
                                GameObject go = Instantiate(notePrefabRED1) as GameObject;
                                go.transform.position = new Vector3(0.9f, 4.2f, 0);
                                break;

                            case 2:
                                GameObject go2 = Instantiate(notePrefabRED2) as GameObject;
                                go2.transform.position = new Vector3(-0.9f, 4.2f, 0);
                                break;

                            case 3:
                                GameObject go3 = Instantiate(notePrefabRED3) as GameObject;
                                go3.transform.position = new Vector3(0, 4.3f, 0);
                                break;

                            case 4:
                                GameObject go4 = Instantiate(notePrefabRED4) as GameObject;
                                go4.transform.position = new Vector3(0.96f, 4.3f, 0);
                                break;

                            case 5:
                                GameObject go5 = Instantiate(notePrefabRED5) as GameObject;
                                go5.transform.position = new Vector3(1.91f, 4.3f, 0);
                                break;

                            default:
                                break;
                        }
                        break;

                    case 2:
                        switch (load.line[x])
                        {
                            case 1:
                                GameObject go = Instantiate(notePrefabBLUE1) as GameObject;
                                go.transform.position = new Vector3(-0.9f, 4.2f, 0);
                                break;

                            case 2:
                                GameObject go2 = Instantiate(notePrefabBLUE2) as GameObject;
                                go2.transform.position = new Vector3(-0.96f, 4.3f, 0);
                                break;

                            case 3:
                                GameObject go3 = Instantiate(notePrefabBLUE3) as GameObject;
                                go3.transform.position = new Vector3(0, 4.3f, 0);
                                break;

                            case 4:
                                GameObject go4 = Instantiate(notePrefabBLUE4) as GameObject;
                                go4.transform.position = new Vector3(0.96f, 4.3f, 0);
                                break;

                            case 5:
                                GameObject go5 = Instantiate(notePrefabBLUE5) as GameObject;
                                go5.transform.position = new Vector3(1.91f, 4.3f, 0);
                                break;

                            default:
                                break;
                        }
                        break;

                    case 3:
                        switch (load.line[x])
                        {
                            case 1:
                                GameObject go = Instantiate(notePrefabYELLOW1) as GameObject;
                                go.transform.position = new Vector3(-1.91f, 4.3f, 0);
                                break;

                            case 2:
                                GameObject go2 = Instantiate(notePrefabYELLOW2) as GameObject;
                                go2.transform.position = new Vector3(-0.96f, 4.3f, 0);
                                break;

                            case 3:
                                GameObject go3 = Instantiate(notePrefabYELLOW3) as GameObject;
                                go3.transform.position = new Vector3(0, 4.3f, 0);
                                break;

                            case 4:
                                GameObject go4 = Instantiate(notePrefabYELLOW4) as GameObject;
                                go4.transform.position = new Vector3(0.96f, 4.3f, 0);
                                break;

                            case 5:
                                GameObject go5 = Instantiate(notePrefabYELLOW5) as GameObject;
                                go5.transform.position = new Vector3(1.91f, 4.3f, 0);
                                break;

                            default:
                                break;
                        }
                        break;

                    case 0:
                        SceneManager.LoadScene("EndScenes");
                        break;

                    default:
                        break;
                }
                x++;
            }
        }
        if (x == 100)
        {
            enabled = false;
        }
    }
}

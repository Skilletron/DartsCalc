using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonsScripts : MonoBehaviour
{
    public GameObject[] info = new GameObject[3];

    public void info_301()
    {
        info[0].SetActive(true);
        info[1].SetActive(false);
        info[2].SetActive(false);
    }
    public void info_501()
    {
        info[0].SetActive(false);
        info[1].SetActive(true);
        info[2].SetActive(false);
    }
    public void info_1001()
    {
        info[0].SetActive(false);
        info[1].SetActive(false);
        info[2].SetActive(true);
    }
}

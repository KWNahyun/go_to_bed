using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomObject : MonoBehaviour
{

    public GameObject[] objects;

    public void Change()
    {
        int r = Random.Range(0, objects.Length);
        for ( int i = 0; i < objects.Length; i++)
        {
            transform.GetChild(i).gameObject.SetActive(r == i);
        }
    }
}

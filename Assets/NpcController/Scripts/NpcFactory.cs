using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NpcFactory : MonoBehaviour
{
    public GameObject npcPrefab;

    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < 2; i++)
        {
            Instantiate(npcPrefab, new Vector3(2 + i, 0, (float)10), Quaternion.identity);
        }
    }
}

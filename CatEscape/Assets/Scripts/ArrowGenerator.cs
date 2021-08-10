using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrowGenerator : MonoBehaviour
{
    public GameObject ArrowPrefab;
    float span = 1.0f;
    float delta = 0;
    void Start()
    {
        
    }

    void Update()
    {
        delta += Time.deltaTime;
        if (delta > span)
        {
            delta = 0;
            GameObject go = Instantiate(ArrowPrefab) as GameObject;
            int px = Random.Range(-6, 7);
            go.transform.position = new Vector2(px, 7);
        }
    }
}

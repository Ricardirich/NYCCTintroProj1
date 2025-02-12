using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Instantiator : MonoBehaviour
{
    public GameObject prefab;
    public float timer;
    public float fixedTimer;
    public float interval;
    // Start is called before the first frame update
    void Start()
    {
        timer = 0f;
        InvokeRepeating("SpawnObj", 1.0f, interval);
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
    }

    void FixedUpdate()
    {
        fixedTimer += Time.fixedDeltaTime;
    }

    void SpawnObj()
    {
        Instantiate(prefab);
    }
}

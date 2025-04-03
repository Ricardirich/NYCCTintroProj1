using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TextAnimator : MonoBehaviour
{
    RectTransform myRect;
    public Vector2 radii = new Vector2(1f,1f);
    public float speed;
    float timer;
    // Start is called before the first frame update
    void Start()
    {
        myRect = GetComponent<RectTransform>();
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        Vector3 newPos = new Vector3(Mathf.Sin(-timer), Mathf.Cos(timer), 0f);
        myRect.position += newPos;
    }
}

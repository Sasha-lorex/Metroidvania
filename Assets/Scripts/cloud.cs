using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cloud : MonoBehaviour
{
    // Start is called before the first frame update
    float time = 0;
    float y = 0;
    float x = 0;
    float a = 0.2f;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(x + a * Mathf.Cos(time) + 10.36f, y + a * Mathf.Sin(time) + 0.7f, transform.position.z);
        time += Time.deltaTime;
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move_camera : MonoBehaviour
{
    // Start is called before the first frame update
    public Transform target;
    public int speed;
    void Start()
    {
        transform.position = new Vector3(target.position.x, target.position.y + 2, -10);
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 pos = new Vector3(target.position.x, target.position.y + 2, -10);
        transform.position = Vector3.Lerp(transform.position, pos, speed * Time.deltaTime);
    }
}

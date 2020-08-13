using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class shop : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject sh;
    void OnTriggerExit2D()
    {
            sh.SetActive(false);
    }
    void OnTriggerEnter2D()
    {
        sh.SetActive(true);
    }

}

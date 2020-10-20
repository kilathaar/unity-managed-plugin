using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Entitet;

public class UseManagedPlugin : MonoBehaviour
{
    private Text text;
    // Start is called before the first frame update
    void Start()
    {
        Text text = new Text("Hello World");
        Debug.Log(text.ToString());
    }

    // Update is called once per frame
    void Update()
    {
    }
}

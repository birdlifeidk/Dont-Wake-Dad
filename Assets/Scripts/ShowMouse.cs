using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowMouse : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Invoke("Display",0.2f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Display()
    {
        Cursor.visible = true;
        Debug.Log("Display Mouse");
    }
}

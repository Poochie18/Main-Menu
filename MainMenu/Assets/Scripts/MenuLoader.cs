using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuLoader : MonoBehaviour
{
    private bool isMenu = true;
    public GameObject canvasUI;
    // Start is called before the first frame update
    void Awake()
    {
        if (!isMenu)
            isMenu = true;
        if (isMenu)
        {

            Instantiate(canvasUI);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

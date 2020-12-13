using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
public class Box : MonoBehaviour
{
    private PlayerControls controls;
    // Start is called before the first frame update
    void Awake()
    {
        controls = new PlayerControls();
       
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

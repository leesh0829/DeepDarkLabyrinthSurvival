using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MasterController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(OVRInput.Get(OVRInput.Button.Two))
        {
            if(PickUpFlashLight.pickedUp == true)
            {
                PickUpFlashLight.pickedUp = false;
            }
        }
    }
}

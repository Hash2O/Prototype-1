using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerPropellerX : MonoBehaviour
{
    private float propellerSpeed = 100.0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Faire tourner l'hélice de l'avion (autour de l'axe z)
        transform.Rotate(0, 0, propellerSpeed);
    }
}

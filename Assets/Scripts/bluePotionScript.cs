using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bluePotionScript : MonoBehaviour
{
    public GameObject PrincessVarient;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.name == "PrincessLevel2")
        {
            //Add 1 to points.
            Destroy(gameObject); //This Destroys
        }
    }
}

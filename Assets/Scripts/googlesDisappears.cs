using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class googlesDisappears : MonoBehaviour
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
        if (other.CompareTag("princess"))
        {
                Destroy(gameObject);
            }
        
    }
}

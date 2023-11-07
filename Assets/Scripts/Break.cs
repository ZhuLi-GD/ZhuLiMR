using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Break : MonoBehaviour
{
    //public GameObject one;
    //public GameObject three;
    //public GameObject star;

    private void OnTriggerEnter(Collider other)
    {

        if (other.CompareTag("x"))
        {
            if (this.gameObject.GetComponent<Rigidbody>().velocity.magnitude > 0.01f)
            {
                other.gameObject.SetActive(false);
                other.gameObject.GetComponent<Renderer>().enabled = false;
                other.transform.parent.GetChild(1).gameObject.SetActive(true);
                other.transform.parent.GetChild(2).gameObject.SetActive(true);
            }
        }
        
    }


}

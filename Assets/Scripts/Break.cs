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
<<<<<<< Updated upstream
        if (other.CompareTag("X"))
        {
=======
<<<<<<< HEAD
        if(other.CompareTag("x"))
        {
            Debug.Log(121);
=======
        if (other.CompareTag("X"))
        {
>>>>>>> a44129b2ca2625183fbdddb0af699e178d4f9c6b
>>>>>>> Stashed changes
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

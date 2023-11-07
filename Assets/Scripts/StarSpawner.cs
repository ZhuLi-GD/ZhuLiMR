using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StarSpawner : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject star;


    //public float x_force;
    //public float y_force;
    //public float z_force;
    public float zForce;
    float timer = 1f;
    float cd;
    float finalX, finalY, finalZ;
    public float randomX, randomY, randomZ;
    void Start()
    {
        finalX = Random.Range(-randomX, randomX);
        finalY = Random.Range(-randomY, randomY);
        finalZ = Random.Range(-randomZ, randomZ);
        //StartCoroutine(SpawnStar());
    }

    void Update()
    {
        timer -= Time.deltaTime;
        if(timer<=0)
        {
            GameObject arrowObject = Instantiate(star, transform.position, Quaternion.identity);
            arrowObject.GetComponent<Rigidbody>().AddForce(new Vector3(finalX, finalY, finalZ));
            cd = Random.Range(0.1f, 1f);
            timer = cd;
        }
    }



    //IEnumerator SpawnStar()
    /*    {
            while (true)
            {
                GameObject arrowObject = Instantiate(star, transform.position, Quaternion.identity);
                arrowObject.GetComponent<Rigidbody>().AddForce(new Vector3(finalX, finalY, finalZ));
                yield return new WaitForSeconds(Random.Range(0, 1));
            }
        }*/
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bomb : MonoBehaviour
{
    public GameObject capsule;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("Bomb", 6f, 7f);
    }
    // Update is called once per frame
    void Update()
    {
        
    }


    public void Bomb()
    {
        float Xpos = Random.Range(-10, 5);
        Vector3 Position =new Vector3(Xpos,0,0);
        Instantiate(capsule,Position,Quaternion.identity);

    }
}

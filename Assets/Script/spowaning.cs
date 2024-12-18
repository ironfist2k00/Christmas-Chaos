using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sponpoint : MonoBehaviour
{
    public bool a;
    public GameObject CubeA;
    public Rigidbody rb;
    float height = 500f;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("Ok", 2f, 3f);
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(1)&& a== true)
        {
            rb.AddForce(Vector3.up * height, ForceMode.Force);
            a= false;
        }

    }

    private void OnCollisionEnter(Collision collision)
    {
        a=true;
        Debug.Log("ho");
    }
    void Ok()
    {
        float Xpos = Random.Range(-10, 5);
        Vector3 Position = new Vector3(Xpos, 0, 0);
        Instantiate(CubeA, Position, Quaternion.identity);
    }
}
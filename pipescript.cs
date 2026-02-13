using System.Security.Cryptography.X509Certificates;
using UnityEngine;

public class pipescript : MonoBehaviour
{
    // Start is called onc
    // e before the first
    // execution of Update after the MonoBehaviour is created
    public float movespeed;
    private float destroyposition =-25;
    void Start()

    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += Vector3.left * movespeed*Time.deltaTime;
        if(transform.position.x < destroyposition)
        {
            Destroy(gameObject);
        }
    }

}

using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;

public class birdscript : MonoBehaviour

{
    public Rigidbody2D myrigidbody;
    public float flapstrength;
    public logicmanager logic;
    public bool Alive = true;
    void Start()
    {
        if (myrigidbody == null)
        {

        myrigidbody = GetComponent<Rigidbody2D>();
        
        }

        logic = GameObject.FindGameObjectWithTag("logic").GetComponent<logicmanager>();

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space)==true && Alive) {
            myrigidbody.linearVelocity = Vector2.up * flapstrength;
      
        }
        else if (!Alive)
        {
            myrigidbody.linearVelocity = Vector2.up * 15;
        }
    }
     
    private void OnCollisionEnter2D(Collision2D collision)
    {
        logic.GameOver();
        Alive = false;
    }


}


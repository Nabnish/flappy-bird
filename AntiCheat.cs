using UnityEngine;


public class AntiCheat : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public logicmanager logic;
    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("logic").GetComponent<logicmanager>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.layer == 3)
        {   
            logic.addscore(-1);
        }
    }
}

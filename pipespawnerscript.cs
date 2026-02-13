using UnityEditor.Profiling.Memory.Experimental;
using UnityEngine;

public class pipespawnerscript : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public GameObject pipe;
    public float spawnrate=2;
    private float timer;
    public float heightoffset;
    void spawnPipe()
    {
        float lowestpoint = transform.position.y - heightoffset;
        float highestpoint = transform.position.y + heightoffset;
        Instantiate(pipe, new Vector3(transform.position.x,Random.Range(lowestpoint,highestpoint ),0), transform.rotation);
    }
    void Start()
    {
        spawnPipe();
    }

    // Update is called once per frame
    void Update()
    {
        if (timer < spawnrate)
        { 
            timer+= Time.deltaTime;
        }
        else
        {
            spawnPipe();
            timer = 0;
        }
    }
}

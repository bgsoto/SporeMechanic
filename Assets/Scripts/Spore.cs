using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class Spore : MonoBehaviour
{

    [SerializeField] float minSize = 0;
    [SerializeField] float maxSize = 0;
    [SerializeField] GameObject spore;
    [SerializeField] float spawnRadius = 1.0f;
    [SerializeField] float timer = 0;
    [SerializeField] float targettime = 0;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
         

       if (timer < 2f)
        {
            timer += Time.deltaTime;
           // spawnNextSpore();
        }
        else
        {
            timer = 0f;
            spawnNextSpore();
        }
        
    }

    private void spawnNextSpore()
    {
        Vector2 randomPosition = Random.insideUnitSphere * spawnRadius;

        //randomPosition.y = 0;
        
        Instantiate(spore, (Vector2)transform.position + randomPosition, Quaternion.identity );

    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField]
    private GameObject mob;

    private float spawnDuration;


    private void Spawn()
    {
        Instantiate(mob, new Vector3(Random.Range(-50.0f, 250.1f), 0f, Random.Range(50.0f, 350.1f)), Quaternion.identity);
    }
    private void Start()
    {
        spawnDuration = 0;
    }

    private void Update()
    {
        spawnDuration += Time.deltaTime;
        if(spawnDuration >=5.0f)
        {
            spawnDuration = 0.0f;
        }
        if(spawnDuration == 0.0f)
        {
            Spawn();
        }
    }

}

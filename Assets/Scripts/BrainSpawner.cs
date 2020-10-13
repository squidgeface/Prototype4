using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BrainSpawner : MonoBehaviour
{
    public GameObject brain;
    float counter = 0;
    Transform spawner;

    // Update is called once per frame
    void Update()
    {
        counter += 1 * Time.deltaTime * 100;

        if (counter >= 10)
        {
            float randomY = Random.Range(10.0f, Screen.height - 10.0f);
            spawner = transform;
            spawner.transform.position = new Vector3(transform.position.x, randomY, transform.position.z);
            Instantiate(brain, spawner);
            Debug.Log("Spawned");
            counter = 0;
        }
    }
}

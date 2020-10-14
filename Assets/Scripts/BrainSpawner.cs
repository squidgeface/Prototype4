using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class BrainSpawner : MonoBehaviour
{
    public GameObject brain;
    float counter = 0;
    public RectTransform canvas;

    // Update is called once per frame
    void Update()
    {
        counter += 1 * Time.deltaTime * 100;

        if (counter >= 200)
        {
            float randomY = Random.Range(50.0f, Screen.height - 50.0f);
            Instantiate(brain, new Vector3(Screen.width + 10.0f, randomY, 0.0f), new Quaternion(), canvas);
            Debug.Log("Spawned");
            counter = 0;
        } 
    }

}

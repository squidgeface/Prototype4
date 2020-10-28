using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class BrainSpawner : MonoBehaviour
{
    public GameObject brain;
    float counter = 0;
    public Canvas canvas;
    float spawnTime = 0.0f;
    public int brainCount = 1;
    float width;
    float height;

    private void Start()
    {
        spawnTime = Random.Range(100.0f, 200.0f);
        width = canvas.gameObject.GetComponent<RectTransform>().localPosition.x + canvas.gameObject.GetComponent<RectTransform>().rect.width/2;
        height = canvas.gameObject.GetComponent<RectTransform>().rect.height;

    }

    // Update is called once per frame
    void Update()
    {
        counter += 1 * Time.deltaTime * 100;
        

        if (counter >= spawnTime && brainCount < 10)
        {
            spawnTime = Random.Range(150.0f, 350.0f);
            float randomY = Random.Range(- 30.0f,  50.0f);
            Instantiate(brain, new Vector3(gameObject.transform.position.x, randomY, canvas.gameObject.GetComponent<RectTransform>().localPosition.z), new Quaternion(), canvas.gameObject.GetComponent<RectTransform>());
            Debug.Log("Spawned");
            counter = 0;
            brainCount++;
        } 
    }

}

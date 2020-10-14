using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlyingBrain : MonoBehaviour
{
    float speed = 0.0f;
    public AudioSource swoosh;
    private TrumpMover brain;
    void Start()
    {
        speed = Random.Range(3.0f, 7.0f);
        swoosh.Play();
        brain = FindObjectOfType<TrumpMover>();
    }

    // Update is called once per frame
    void Update()
    {
        gameObject.transform.position += new Vector3(-speed * Time.deltaTime * 100, 0.0f, 0.0f);

        if (gameObject.transform.position.x < 0.0f)
        {
            brain.brainCount++;
            Destroy(this.gameObject);
        }
    }
}

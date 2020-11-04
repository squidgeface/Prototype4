using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FlyingBrain : MonoBehaviour
{
    float speed = 0.0f;
    public AudioSource swoosh;
    private TrumpMover brain;
    public Animator cloud;
    public Image brainSprite;
   
    void Start()
    {
        speed = Random.Range(2.0f, 7.0f);
        swoosh.Play();
        brain = FindObjectOfType<TrumpMover>();
    }

    // Update is called once per frame
    void Update()
    {
        gameObject.transform.localPosition += new Vector3(-speed * Time.deltaTime * 100, 0.0f, 0.0f);

        if (gameObject.transform.localPosition.x < -Screen.width/2)
        {
            brain.brainCount++;
            Destroy(this.gameObject);
        }
    }

}

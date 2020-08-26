using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BrainScript : MonoBehaviour

{

    public GameObject target;
    public GameObject me;
    private Vector3 objectRotation;
    private Vector3 moveTowards;
    public Text score;

    private float timer = 0;
    // Start is called before the first frame update
    void Start()
    {
        target = GameObject.Find("Target");


        // objectRotation = Vector3.RotateTowards(transform.position, target.transform.position, 2 * Mathf.PI, 10);
        me.transform.rotation = new Quaternion();
      
      //  transform.RotateAround(target.transform.position, Random.Range(0, 360));

        //find the direction of the target
        moveTowards = Vector3.MoveTowards(this.transform.position, target.transform.position, 0.1f);
        moveTowards.z = 0;
        moveTowards.Normalize();
        
    }

    // Update is called once per frame
    void Update()
    {

        //move towards the target
        me.transform.Rotate(0, 0, 1);
        transform.position -= moveTowards * Time.deltaTime * 8;

        
        //count how long minigame has been going ~26 is end of game in this example
        timer += Time.deltaTime;

        if (timer > 26.5f)
        {
            //END MINI GAME AND GOTO NEXT SCENE
            print("end of game");

            print("score of " + FindObjectOfType<ScoreScript>().brainScore);

    
        }
    }
    private void OnMouseDown()
    {
        //destroy and add to score when clicked
       
        FindObjectOfType<ScoreScript>().brainScore += 1;
        score.text = FindObjectOfType<ScoreScript>().brainScore.ToString() + "/ 10";
        GameObject.Destroy(me, 0);
    }

}


using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using Random=System.Random;
using TMPro;

public class NewBehaviourScript : MonoBehaviour
{
    public Material mat;
    public Material mate;
    public Material mater;
    public Material materi;
    public Renderer rend;
    public TMP_Text text;
    private Rigidbody rb;
    private Collider col;
    private List<string> colores= new List<string>(){"RED","YELLOW","GREEN","BLUE"};
    private string random;
    // Start is called before the first frame update
    void Start()
    {
        rend =GetComponent<Renderer>();
        
        rb = GetComponent<Rigidbody>();

        Random rnd = new Random();
        int randIndex = rnd.Next(colores.Count);
        random = colores[randIndex];
        text.text="Press SPACEBAR to stop the ball in "+random+" block";
    
    }

    
    void OnTriggerEnter(Collider c){
        
        if(c.tag=="RED"){
            rend.material= mat;
            col=c;
        }
        if(c.tag=="YELLOW"){
            rend.material= mate;
            col=c;
        }
        if(c.tag=="GREEN"){
            rend.material= mater;
            col=c;
        }
        if(c.tag=="BLUE"){
            rend.material= materi;
            col=c;
        }

    }

    void Update(){
        if (Input.GetKeyDown(KeyCode.Space))
        {
            rb.isKinematic=true;
            if(col.tag==random){
                text.text="YOU HAVE WIN, YOU HAVE SELECTED THE CORRECT COLOR";
            }
            else{

                text.text="YOU HAVE LOSE, YOU HAVE NOT SELECTED THE CORRECT COLOR";
            }
        }
    }
}

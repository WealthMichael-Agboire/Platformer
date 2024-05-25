using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AIChase : MonoBehaviour
{

 public GameObject player;
 public float speed;
 public float distanceBetween;

 private float distance;

public GameObject startPoint;
   public GameObject Player;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       distance = Vector2.Distance(transform.position, player.transform.position);
       Vector2 direction = player.transform.position - transform.position;

       
    if(distance <distanceBetween)
    {
        transform.position = Vector2.MoveTowards(this.transform.position, player.transform.position, speed * Time.deltaTime);
        
    }
    
    }

     private void OnCollisionEnter2D(Collision2D other)
    {

   if(other.gameObject.CompareTag("Player"))

   {
    Player.transform.position = startPoint.transform.position;
   }

    }

}

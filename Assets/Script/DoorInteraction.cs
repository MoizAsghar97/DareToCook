using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class DoorInteraction : MonoBehaviour
{
  public bool isInRange;
  public string doorTitle;
  public KeyCode interactKey;
  public UnityEvent interactAction;
  public bool spiceDoor;     
  public Item item;   

  void Update()
  {
    if(spiceDoor==true && (doorTitle=="Food" && Input.GetKeyDown(interactKey) ))
    {

       interactAction.Invoke();
    }
 
    if(spiceDoor==true && doorTitle=="FoodSecond" && Input.GetKeyDown(interactKey))
    {
 
       interactAction.Invoke();
    }

    if(spiceDoor==true && doorTitle=="FoodThird" && Input.GetKeyDown(interactKey))
    {
    
       interactAction.Invoke();
    }

    if(spiceDoor==true && doorTitle=="FoodFourth" && Input.GetKeyDown(interactKey))
    {
  
       interactAction.Invoke();
    }
  }

  private void OnTriggerEnter2D(Collider2D collider)
  {
    if(doorTitle=="Enemy")
    {
       interactAction.Invoke();
    }

    if( doorTitle=="Dialogue" || doorTitle=="OpenDoor"  )
    {
       interactAction.Invoke();
    }
    spiceDoor = true;


  }
 
 private void OnTriggerExit2D(Collider2D collider)
  {
     
   spiceDoor = false;           

 
  }


}



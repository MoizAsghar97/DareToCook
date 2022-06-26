using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SnapController : MonoBehaviour
{
  
  public List<Transform> snapPoints;
  public List<Draggable> draggableObjects;
  public bool snapPointsIndexFirst;
  public float snapRange = 0.5f;
  private int firstItem;
  //public Image image2;

  void Start()
  {

    foreach (Draggable draggable in draggableObjects)
    {
 //     draggable.dragEndedCallback = OnDragEnded;
    }
  
  }

  private void OnDragEnded(Draggable draggable,string itemName)
  {
  
    float closestDistance = -1;
    Transform closestSnapPoint = null;
    foreach (Transform snapPoint in snapPoints)
    {

      float currentDistance = Vector2.Distance(draggable.transform.localPosition,snapPoint.localPosition);
      if(closestDistance==null || currentDistance < closestDistance)
      {
        closestSnapPoint = snapPoint;
        closestDistance = currentDistance;

      }

    }

     if(closestSnapPoint!=null && closestDistance <= snapRange)
     {
      draggable.transform.localPosition = closestSnapPoint.localPosition;
     
     }

      if(itemName=="water" )
      {
          firstItem= firstItem+1;
      }
      if(itemName=="rice" )
      {
          firstItem= firstItem+1;
      }

      if(itemName=="spicy" )
      {
            firstItem= firstItem+1;
      }

      if(itemName=="ginger")
      {
          firstItem= firstItem+1;
      }
  }

}

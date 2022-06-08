using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.Events;
using UnityEngine.UI;


public class Draggable : MonoBehaviour,IPointerDownHandler,IBeginDragHandler,IEndDragHandler,IDragHandler
{
    private bool isDragged = false;
    private bool isDraggedItem = false;
    private bool isWater = false;
    private bool isRice = false;
    private Vector3 spriteDragStartPosition;
    private Vector3 mouseDragStartPosition;
    private Camera cam;
    public string draggableObjectName = null;
    public string draggableObjectCircle = null;
    public delegate void DragEndedDelegate(Draggable draggableObjects,string draggableObjectName);
    public DragEndedDelegate dragEndedCallback;
    private RectTransform rectTransForm;
    private Draggable draggable ;
    public Image image2;
    public static List<string> addDrag = new List<string>();
    public Text text;
    void Start()
    {
          cam = Camera.main;
          rectTransForm = GetComponent<RectTransform>();
          image2 = GameObject.Find("DialoguePopup").GetComponent<Image>();
          text = GameObject.Find("ScoreText").GetComponent<Text>();
          text.enabled = false;
          image2.enabled = false;
    }


   public void OnBeginDrag(PointerEventData eventData)
   {
       Debug.Log("down");
       isDragged = true;
       mouseDragStartPosition  = cam.ScreenToWorldPoint(Input.mousePosition);    
       spriteDragStartPosition = transform.localPosition;

   }
   public void OnDrag(PointerEventData eventData)
   {
        Debug.Log("drag");
       if(isDragged)
       {
          transform.localPosition = spriteDragStartPosition + ( cam.ScreenToWorldPoint(Input.mousePosition) - mouseDragStartPosition );

       }

   }

    public void OnEndDrag(PointerEventData eventData)
   { 
         isDragged = false;
     

          if(draggableObjectName=="water")
          {
             addDrag.Add("water");
          }

          if(draggableObjectName=="rice")
          {
             addDrag.Add("rice");
          }

          if(draggableObjectName=="spicy")
          {
             addDrag.Add("spicy");
          }

          if(draggableObjectName=="ginger")
          {
             addDrag.Add("ginger");
          }
    

           

   }


 public void OnPointerDown(PointerEventData eventData)
 {
 
  }

void Update()
{
  
  
   if(addDrag.Count==4)
   {
      image2.enabled = true;
       text.enabled = true;

   }

   }

}

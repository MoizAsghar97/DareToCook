using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class DoorScript : MonoBehaviour, IPointerClickHandler
{
    
        public Image image;
        public string gameObjectName;
        public AudioSource audioSourceOne;

        private float timer = 0.0f;
        public Item item;
        public void Awake()
        {
            
            if(gameObjectName=="Food")
            {

             CommonFunctionalityForImages("Food",false);
            }
             
            if(gameObjectName=="FoodSecond")
            {
               CommonFunctionalityForImages("FoodSecond",false);
            }

            if(gameObjectName=="FoodThird"){
               CommonFunctionalityForImages("FoodThird",false); 
 
            }
            
            if(gameObjectName=="FoodFourth")
            {
              CommonFunctionalityForImages("FoodFourth",false);  
            }
       
        }

       public void OnPointerClick(PointerEventData eventData){
  
       }
   
       public void OpenFoodDoor(Item item)
       {
   
         PickUp(item);  
         CommonFunctionalityForImages("Food",true);
         
         
       
       }

        
      public void OpenSecondFoodDoor(Item item)
      {
        Debug.Log("testing2");
        PickUp(item);
        CommonFunctionalityForImages("FoodSecond",true);
      
       
     }

      public void OpenThirdFoodDoor(Item item)
      {
          PickUp(item);
          CommonFunctionalityForImages("FoodThird",true);
            
      }


       public void OpenFourthFoodDoor(Item item)
       {
         PickUp(item); 
         CommonFunctionalityForImages("FoodFourth",true);
         
       }

        void CommonFunctionalityForImages(string title,bool isImage)
       {
         image = GameObject.Find(title).GetComponent<Image>();
         image.enabled = isImage;
         audioSourceOne.Play();
          
        }
    
      public void PickUp(Item item)
      {
         
            bool wasPickedUp =  Inventory.instance.Add(item);
  
        
      }

}

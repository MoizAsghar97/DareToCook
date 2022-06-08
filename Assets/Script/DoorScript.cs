using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class DoorScript : MonoBehaviour, IPointerClickHandler
{
        public Inventory Inventory;
        public CookType type;
        public Image image;
        public Image image2;
        public Image image3;
        public string gameObjectName;
        public AudioSource audioSourceOne;
        public string scorea;
        private float timer = 0.0f;
        //public ScoreKeeper sk;

        public void Awake()
        {
            
            if(gameObjectName=="Food")
            {

             CommonFunctionalityForImages("Food",false,"InventoryFood",false);
            }
             
            if(gameObjectName=="FoodSecond")
            {
               CommonFunctionalityForImages("FoodSecond",false,"InventoryFoodSecond",false);
            }

            if(gameObjectName=="FoodThird"){
               CommonFunctionalityForImages("FoodThird",false,"InventoryFoodThird",false); 
 
            }
            
            if(gameObjectName=="FoodFourth")
            {
              CommonFunctionalityForImages("FoodFourth",false,"InventoryFoodFourth",false);  
            }
          //  sk.score.ToString();
        }

      void Update()
      {

      }
   
        public void OnPointerClick(PointerEventData eventData)
        {

            if(gameObjectName=="Food")
            {
              CommonFunctionalityForInventory("InventoryFood");
              Inventory.Add(type);

            }
            
           if(gameObjectName=="FoodThird")
           {
               CommonFunctionalityForInventory("InventoryFoodThird");
               Inventory.Add(type);
           }
        

          if(gameObjectName=="FoodSecond")
           {
                CommonFunctionalityForInventory("InventoryFoodSecond");
                Inventory.Add(type);
            }
         
            if(gameObjectName=="FoodFourth")
            {
                  CommonFunctionalityForInventory("InventoryFoodFourth");
                  Inventory.Add(type);
            }
       
        }


       public void OpenFoodDoor()
       {
        CommonFunctionalityForImages("Food",true,"InventoryFood",true);
        Inventory.Add(type);
       
         image = GameObject.Find("Food").GetComponent<Image>();
         image.enabled = true;

         image3 = GameObject.Find("DoorFirst").GetComponent<Image>();
         image3.enabled = false;

         
       }

        
      public void OpenSecondFoodDoor()
      {
        CommonFunctionalityForImages("FoodSecond",true,"InventoryFoodSecond",true);
        Inventory.Add(type);
        image3 = GameObject.Find("DoorSecond").GetComponent<Image>();
        image3.enabled = false;
     }

      public void OpenThirdFoodDoor()
      {
        CommonFunctionalityForImages("FoodThird",true,"InventoryFoodThird",true);
        Inventory.Add(type);
        image3 = GameObject.Find("DoorThird").GetComponent<Image>();
        image3.enabled = false;
      }


       public void OpenFourthFoodDoor()
       {
              
        CommonFunctionalityForImages("FoodFourth",true,"InventoryFoodFourth",true);
        Inventory.Add(type);
        image3 = GameObject.Find("DoorFourth").GetComponent<Image>();
        image3.enabled = false;
    
       }

        void CommonFunctionalityForImages(string title,bool isImage, string inventoryTitle, bool isInventoryImage)
       {
         image = GameObject.Find(title).GetComponent<Image>();
         image.enabled = isImage;
         image2 = GameObject.Find(inventoryTitle).GetComponent<Image>();
         image2.enabled = isInventoryImage;
         audioSourceOne.Play();
          
         
       
        }
       


   

    void CommonFunctionalityForInventory(string inventoryTitle)
    {
         image.enabled = true;
         image2 = GameObject.Find(inventoryTitle).GetComponent<Image>();
         image2.enabled = true; 
        
    }


}

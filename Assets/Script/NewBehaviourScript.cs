using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
//using UnityEngine.SceneManagement;
using UnityEngine.EventSystems;

public class NewBehaviourScript : MonoBehaviour, IPointerClickHandler
{
       // public Inventory Inventory;
     //   public CookType type;
        public Image image;
        public Image image2;
        public string gameObjectName;
        public AudioSource audioSourceOne;

        public void Awake()
        {   
            if(gameObjectName=="Food"){
            
                image = GameObject.Find("Food").GetComponent<Image>();
                image.enabled = false; 
                image2 = GameObject.Find("InventoryFood").GetComponent<Image>();
                image2.enabled = false; 
              
            }
             
            if(gameObjectName=="FoodSecond")
            {

                image = GameObject.Find("FoodSecond").GetComponent<Image>();
                image.enabled = false;  
                image2 = GameObject.Find("InventoryFoodSecond").GetComponent<Image>();
                image2.enabled = false; 
               
            }

            if(gameObjectName=="FoodThird"){
              image = GameObject.Find("FoodThird").GetComponent<Image>();
              image.enabled = false;  
              image2 = GameObject.Find("InventoryFoodThird").GetComponent<Image>();
              image2.enabled = false;
            }
            
            if(gameObjectName=="FoodFourth"){
              image = GameObject.Find("FoodFourth").GetComponent<Image>();
              image.enabled = false;  
              image2 = GameObject.Find("InventoryFoodFourth").GetComponent<Image>();
              image2.enabled = false; 
 
            }
           
              
        }

   
        public void OnPointerClick(PointerEventData eventData)
        {

            if(gameObjectName=="Food"){
               image.enabled = true;
               // Inventory.Add(type);
                image2 = GameObject.Find("InventoryFood").GetComponent<Image>();
                image2.enabled = true;
                audioSourceOne.Play();
 
                 
            }
        
            if(gameObjectName=="FoodSecond"){
                 image.enabled = true;
                // Inventory.Add(type);
                 image2 = GameObject.Find("InventoryFoodSecond").GetComponent<Image>();
                 image2.enabled = true;
                 audioSourceOne.Play();
           
            }
            
            
           if(gameObjectName=="FoodThird"){
                 image.enabled = true;
                // Inventory.Add(type);
                 image2 = GameObject.Find("InventoryFoodThird").GetComponent<Image>();
                 image2.enabled = true;
                 audioSourceOne.Play();
                
           }
        
            if(gameObjectName=="FoodFourth"){
                 image.enabled = true;
                 //Inventory.Add(type);
                 image2 = GameObject.Find("InventoryFoodFourth").GetComponent<Image>();
                 image2.enabled = true;
                 audioSourceOne.Play();
 
            }
       
        }

}

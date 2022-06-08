using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{
 private Dictionary<CookType, int> inventory;
 private void Awake()
 {
   inventory = new Dictionary<CookType, int>();
 }

 public void Add(CookType type,int count = 1)
 {
     if(!inventory.TryGetValue(type,out int current)){
        inventory.Add(type,count);
     }else{
         inventory[type] += count;
     }

 }

 public int Get(CookType type)
 {
     if(inventory.TryGetValue(type,out int current)){
        //inventory.Add(type,count);
        return current;
     }else{
         throw new KeyNotFoundException();
     }

 }
 
 //private void OnApplicationQuit()
// {
  //  List<string> inventoryToSave = new List<string>();
    //foreach(var key in inventory.Keys)
    //{
      // for(int i = 0; i < inventory[key]; i++)
      // {
        //   inventoryToSave.Add(key.ToString());

       //}

   // }
// }

}

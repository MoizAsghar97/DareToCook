using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueShowHideBox : MonoBehaviour
{
  public static DialogueShowHideBox instance = null;
  private void Awake()
  {
     if(instance==null)
     {
           instance=this;
           DontDestroyOnLoad(gameObject);
      }
     else{
            Destroy(gameObject);
      }   
   }
    public  void Show(GameObject obj)
    {
        obj.SetActive(true);
    }


    public  void Hide(GameObject obj)
    {
        obj.SetActive(false);
    }
 
 
 }
   



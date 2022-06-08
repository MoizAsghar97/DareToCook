using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FirstSecneScript : MonoBehaviour
{
  public static FirstSecneScript instance = null;
  public string doorTitle;

    public void ChangeSecne()
    {
        SceneManager.LoadScene("Main");
    }

    public void ChangeSecneDynamic(string doorTitle)
    {

        SceneManager.LoadScene(doorTitle);
    }
    

}

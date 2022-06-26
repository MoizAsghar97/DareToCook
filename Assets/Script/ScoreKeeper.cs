using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreKeeper : MonoBehaviour
{
    public int score;
    private Text secoreText;


    //private void Awake()
   // {
     //   if(instance==null)
       // {
         //  instance=this;
          // DontDestroyOnLoad(gameObject);
       // }
       // else{
         //   Destroy(gameObject);
       // }
    
    //}
   
    // Start is called before the first frame update
    void Start()
    {
        secoreText=this.GetComponent<Text>();
        Reset();
        secoreText.text=score.ToString();

    }

    // Update is called once per frame
    public void ChangeScore(int points)
    {
          score+=points;
          secoreText.text=score.ToString();
     }

    public  void Reset()
    {
      score=0;
   
    }

}

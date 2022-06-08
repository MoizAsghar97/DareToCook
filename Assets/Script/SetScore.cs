using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SetScore : MonoBehaviour
{

   public ScoreKeeper sk;
   //  Start is called before the first frame update
    void Start()
    {
        Text text = this.GetComponent<Text>();
        text.text = sk.score.ToString();
        sk.Reset();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour {

public float timeScore = 0;
public Text scoreText;

    void SetScoreText()
    {
        timeScore += Time.deltaTime;
        scoreText.text = "Count: " + timeScore.ToString();

        //Timer ;
        var Timer = 0.0;


    }

  //업데이트에다가  Timer += Time.deltaTime;


}

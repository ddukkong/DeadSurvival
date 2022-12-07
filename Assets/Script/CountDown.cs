using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class CountDown : MonoBehaviour
{

    public float timeValue = 90;
    public Text timeText;
    // Start is called before the first frame update
    void Start()
    {
        timeText.text = timeValue.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        if (timeValue > 0)
        {
            timeValue -= Time.deltaTime;

        }
        else 
        {
            timeValue = 0;
        }
        DisPlayTime(timeValue);
    }
    void DisPlayTime(float timeToDisplay)
    {
        if(timeToDisplay < 0)
        {
            timeToDisplay = 0;
        }
        float minutes = Mathf.FloorToInt(timeToDisplay / 60);
        float second = Mathf.FloorToInt(timeToDisplay % 60);

        timeText.text = string.Format("{0:00}:{1:00}", minutes, second);

    }

}

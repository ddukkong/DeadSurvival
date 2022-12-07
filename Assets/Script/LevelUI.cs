using UnityEngine;
using UnityEngine.UI;

public class LevelUI : MonoBehaviour
{
    public static int level = 0;
    Text TextLevel;


    void Start()
    {
        TextLevel = GetComponent<Text>();
    }
    void Update()
    {
        TextLevel.text = "LV." + level;


    }

}

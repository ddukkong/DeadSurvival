using UnityEngine;
using UnityEngine.UI;

public class DeathUI : MonoBehaviour
{

    public static int deathCount = 0;
    Text TextdeathUI;


    void Start()
    {
        TextdeathUI = GetComponent<Text>();
    }
    void Update()
    {
        TextdeathUI.text = "" + deathCount;


    }

}


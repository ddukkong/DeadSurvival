using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Level : MonoBehaviour
{
    public Text ScriptTxt;
    int Lcount = GameManager.instance.Lcount;
    // Start is called before the first frame update
    void Start()
    {

    }
    // Update is called once per frame
    void Update()
    {
        Debug.Log(Lcount);
        ScriptTxt.text = string.Format("LV.{0}", Lcount);
    }
}

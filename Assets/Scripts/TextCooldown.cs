using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextCooldown : MonoBehaviour
{
    public Text textObj; 
    // Start is called before the first frame update

    // Update is called once per frame
    void Update()
    {
        if (GameData.cooldownF > 1)
        {
            textObj.text = GameData.cooldownF.ToString("#.#");
        }
        else if (GameData.cooldownF > 0.1)
        {
            textObj.text = GameData.cooldownF.ToString("0.#");
        }
        else
        {
            textObj.text = "";
        }
    }
}

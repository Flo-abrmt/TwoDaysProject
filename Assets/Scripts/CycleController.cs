using System.Collections;
using System.Collections.Generic;
using System.Threading;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class CycleController : MonoBehaviour
{
    //end cylce open citycontroller and start building

    [SerializeField] int time = 0;
    [SerializeField] int minTime = 0;
    [SerializeField] Sprite morningSprite;
    [SerializeField] Sprite middaySprite;
    [SerializeField] Sprite eveningSprite;
    [SerializeField] TMP_Text m_TextComponent;
    [SerializeField] Image i_CycleView;

    public bool repeatCycle = true;

    public CityController cityController;
    public void handleCycle() 
    {
        minTime = minTime + 5;
        if (minTime >= 60)
        {
            minTime = 0;
            time = time + 1;
        }


        // Change the text on the text component.
        m_TextComponent.text = time.ToString()+ ":"+minTime.ToString();
        //endOfCycle();

        if (time >= 24)
        {
            endOfCycle();
        }

        //startmorning
        if(time > 6)
        {
            changeImage(morningSprite);
        }
        //startmidday
        if(time >= 12)
        {
            changeImage(middaySprite);
        }
        //startevening
        if (time >= 18)
        {
            changeImage(eveningSprite);
        }
        Debug.Log(minTime.ToString());
        if (repeatCycle)
        {
            repeatCycle = false;
            InvokeRepeating("handleCycle", 1f, 1f);
        }
    }
    void startOfCycle()
    {
        InvokeRepeating("handleCycle", 1.0f, 1.0f);
    }

    void middleOfCycle()
    {

    }

    void endOfCycle()
    {
        CancelInvoke();
        cityController.whenCycle();
    }

    void changeImage(Sprite image)
    {
        i_CycleView.sprite = image;
    }
}

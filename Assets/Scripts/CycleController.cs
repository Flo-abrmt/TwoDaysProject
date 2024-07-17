using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CycleController : MonoBehaviour
{
    //end cylce open citycontroller and start building

    [SerializeField] float time;
    [SerializeField] Sprite morningSprite;
    [SerializeField] Sprite highnoonSprite;
    [SerializeField] Sprite eveningSprite;

    public CityController cityController;
    public void handleCycle() 
    {
        endOfCycle();
    }
    void startOfCycle()
    {

    }

    void middleOfCycle()
    {

    }

    void endOfCycle()
    {
        cityController.whenCycle();
    }


}

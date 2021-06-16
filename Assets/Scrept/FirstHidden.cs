using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirstHidden : MonoBehaviour
{
    public GameObject Blackout;
    public GameObject backButton;
    public GameObject MapPopup;
    public GameObject MapPopup2;
    public GameObject MapPopupFish;
    public GameObject LockFish;
    public GameObject Lock;
    public GameObject text;
    // Start is called before the first frame update
    void Start()
    {
        Blackout.SetActive(false);
        backButton.SetActive(false);
        MapPopup.SetActive(false);
        MapPopup2.SetActive(false);
        MapPopupFish.SetActive(false);
        LockFish.SetActive(false);
        Lock.SetActive(false);
        text.SetActive(false);
    }

    public void OnClickButtonMainAchieement()
    {
        Blackout.SetActive(true);
        MapPopup.SetActive(true);
        MapPopup2.SetActive(true);
        MapPopupFish.SetActive(true);
        text.SetActive(true);
    }

    public void OnClickButtonMainAchieementLock()
    {
        Blackout.SetActive(true);
        MapPopup.SetActive(true);
        MapPopup2.SetActive(true);
        LockFish.SetActive(true);
        Lock.SetActive(true);
        text.SetActive(true);
    }

    public void OnClickButtonGoMain()
    {
        Blackout.SetActive(false);
        backButton.SetActive(false);
        MapPopup.SetActive(false);
        MapPopup2.SetActive(false);
        MapPopupFish.SetActive(false);
        LockFish.SetActive(false);
        Lock.SetActive(false);
        text.SetActive(false);
    }
}

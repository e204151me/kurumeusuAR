using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Button : MonoBehaviour
{
    public GameObject objeback;
    public GameObject objemap;
    public GameObject objecamera;
    public GameObject objeAR;
    public GameObject objenull;
    public GameObject obleachievement;
    public GameObject HazardMap;
    public GameObject Location;
    public GameObject Location2;
    // Start is called before the first frame update

    public void OnClickButtonRun()
    {
        objeback.SetActive(true);

        objeAR.SetActive(true);

        objemap.SetActive(false);

        objecamera.SetActive(false);

        objenull.SetActive(false);

        obleachievement.SetActive(false);

        HazardMap.SetActive(false);

        Location.SetActive(false);

        Location2.SetActive(false);
    }

    public void OnClickButtonBack()
    {
        objeback.SetActive(false);

        objeAR.SetActive(false);

        objemap.SetActive(true);

        objecamera.SetActive(true);

        objenull.SetActive(true);

        obleachievement.SetActive(true);

        HazardMap.SetActive(true);

        Location.SetActive(true);

        Location2.SetActive(true);
    }

    
        
}
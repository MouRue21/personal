using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class born : MonoBehaviour
{
    public GameObject icetank;
    public GameObject firetank;
    public Camera mainl;
    private GameObject go;
    // Start is called before the first frame update
    void Awake()
    {
        if(PlayerPrefs.GetFloat("num1")==1)
        {
            icetank.GetComponent<tankmovement>().number = 1;
            go=GameObject.Instantiate(icetank, transform.position,transform.rotation);
            mainl.GetComponent<follow>().player1 = go.transform;
        }
        else if(PlayerPrefs.GetFloat("num1") == 2)
        {
            firetank.GetComponent<tankmovement>().number = 1;
            go=GameObject.Instantiate(firetank, transform.position, transform.rotation);
            mainl.GetComponent<follow>().player1 = go.transform;
        }
    }

    // Update is called once per frame


}

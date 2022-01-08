using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class born2 : MonoBehaviour
{
    public GameObject icetank;
    public GameObject firetank;
    public Camera mainl;
    private GameObject go;
    // Start is called before the first frame update
    void Awake()
    {
        if(PlayerPrefs.GetFloat("num2") == 1)
        {
            icetank.GetComponent<tankmovement>().number = 2;
            go=GameObject.Instantiate(icetank, transform.position, transform.rotation);
            mainl.GetComponent<follow>().player2 = go.transform;
        }
        else if(PlayerPrefs.GetFloat("num2") == 2)
        {
            firetank.GetComponent<tankmovement>().number = 2;
            go=GameObject.Instantiate(firetank, transform.position, transform.rotation);
            mainl.GetComponent<follow>().player2 = go.transform;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

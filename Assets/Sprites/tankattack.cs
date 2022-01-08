using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tankattack : MonoBehaviour
{
    //¼õËÙµ¯Ò©
    public GameObject shellprefab;
    private Transform fireposition;
    public KeyCode firekey;
    public float shellspeed = 15;
    public AudioClip firemusic;
    // Start is called before the first frame update
    void Start()
    {
        if(this.GetComponent<tankmovement>().number==1)
        {
            firekey = KeyCode.Space;
        }
        else if(this.GetComponent<tankmovement>().number==2)
        {
            firekey = KeyCode.KeypadEnter;
        }
        fireposition = transform.Find("fireposition");
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(firekey))
        {
            AudioSource.PlayClipAtPoint(firemusic, transform.position);
            GameObject go= GameObject.Instantiate(shellprefab, fireposition.position, fireposition.rotation)as GameObject;
            go.GetComponent<Rigidbody>().velocity = go.transform.forward * shellspeed;
        }
    }
}

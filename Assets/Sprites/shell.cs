using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shell : MonoBehaviour
{
    //¼õËÙµ¯Ò©
    public GameObject shellexplosionprefab;
    private AudioSource audio1;
    // Start is called before the first frame update
    void Start()
    {
        audio1 = this.GetComponent ( "AudioSource" ) as AudioSource;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void OnTriggerEnter(Collider collider)
    {
        GameObject.Instantiate(shellexplosionprefab, transform.position, transform.rotation);
        GameObject.Destroy(this.gameObject);
        if(collider.tag=="tank")
        {
            collider.SendMessage("tankdamage1");
            collider.SendMessage("slow");
        }
    }
}

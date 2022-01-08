using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class tankheals : MonoBehaviour
{
    public GameObject tankexplosion;
    public int hp = 100;
    public AudioClip tankexplosionmusic;
    public Slider hpslider;
    private int hptotal;
    // Start is called before the first frame update
    void Start()
    {
        hptotal = hp;
    }

    // Update is called once per frame
    void Update()
    {
    
    }
    void tankdamage1()//ºıÀŸµØ…À∫¶
    {
        if (hp <= 0)
            return;
        hp -= Random.Range(10, 20);
        hpslider.value = (float)hp / (float)hptotal;
        if (hp <= 0)
        {
            AudioSource.PlayClipAtPoint(tankexplosionmusic, transform.position);
            GameObject.Instantiate(tankexplosion, transform.position + Vector3.up, transform.rotation);
            Destroy(this.gameObject);
        }
    }
    void tankdamage2()//ª—ÊµØ…À∫¶
    {
        if (hp <= 0)
            return;
        hp -= Random.Range(20, 40);
        hpslider.value = (float)hp / (float)hptotal;
        if (hp <= 0)
        {
            AudioSource.PlayClipAtPoint(tankexplosionmusic, transform.position);
            GameObject.Instantiate(tankexplosion, transform.position + Vector3.up, transform.rotation);
            Destroy(this.gameObject);
        }
    }
}

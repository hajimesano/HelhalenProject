using System.Collections;
using UnityEngine;

public class BakemonoFollse : MonoBehaviour {

    public GameObject bake;
    Animator ani;
    AudioSource soubake;
    public Soundcontroller soucon;
    AudioClip clips;

    void Start ()
    {
        soubake = bake.GetComponent<AudioSource>();
        soubake.clip = soucon.audioclip01[5];
        ani = bake.GetComponent<Animator>();
        ani.speed = 0;
    }

    void Update()
    {

    }

    public IEnumerator fall()
    {
        yield return new WaitForSeconds(12.5f);
        soubake.Play();
        Player.isMove = true;
    }

    void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Player")
        {
            bake.SetActive(true);
            Player.isMove = false;
            ani.speed = 1;
            StartCoroutine("fall");
        }
    }
}

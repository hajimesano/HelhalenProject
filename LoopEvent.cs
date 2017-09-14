using UnityEngine;
using System.Collections;

public class LoopEvent : MonoBehaviour {

    GameObject housereference;
    GameObject getsoundcontroller;
    Soundcontroller soundcon;

    void Start ()
    {
        //Debug.Log(fade);
        housereference = GameObject.FindGameObjectWithTag("HouseSwitcher");//Hierarchy上のGameContrllerを所得
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            Houseswitch Hswitch = housereference.GetComponent<Houseswitch>();//Houseswitchの呼び出し
            Hswitch.housecheck(Hswitch.housebox[Hswitch.kaunto]);//Houseswitchのhousecheck起動Hswitch.kauntoの数値によって呼び出しが変動する
            //Debug.Log(Hswitch.kaunto);
            Hswitch.kaunto++;//Houseswitchのkauntoをプラス1している
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            Destroy(this);
        }
    }
}

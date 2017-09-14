using UnityEngine;

public class deshouse : MonoBehaviour {

    GameObject housereference;

    void Start ()
    {
        housereference = GameObject.FindGameObjectWithTag("HouseSwitcher");//Hierarchy上のGameContrllerを所得
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            Houseswitch Hswitch = housereference.GetComponent<Houseswitch>();//Houseswitchの呼び出し
            Hswitch.housedescheck(Hswitch.housebox[Hswitch.deskaunto]);//Houseswitchのhousedescheck起動Hswitch.deskauntoの数値によって呼び出しが変動する
            //Debug.Log(Hswitch.deskaunto);
            Hswitch.deskaunto++;// Houseswitchのdeskauntをプラス1している
            //Debug.Log("DESHIT");//起動確認用
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if(other.gameObject.tag == "Player")
        {
            Destroy(gameObject);
        }
    }
}

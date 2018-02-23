using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bitisTest : MonoBehaviour {



    GameObject tebriklerMesaji; //Oyun pobjesi sınıfı çağır. 
    void Start()
    {
        tebriklerMesaji = GameObject.Find("tebriklerMesaji"); //isimden obje bul.
        tebriklerMesaji.active = false; //obje görünürlüğünü kapat.
    }
    void OnControllerColliderHit(ControllerColliderHit col) //objeye dokunma eventi 
    {
        if (col.collider.gameObject.name == "bitisAlan") //kaynak obje ve hedef obje eşitse
        {
            tebriklerMesaji.active = true; //objeyi görünür yap.
        }
        else
        {
            tebriklerMesaji.active = false; //objeyi sil.
        }
    }



}

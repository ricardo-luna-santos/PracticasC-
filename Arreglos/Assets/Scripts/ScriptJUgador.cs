using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScriptJUgador : MonoBehaviour
{
    public string enemigo1="araña";
    public string enemigo2="araña2";
    public string enemigo3="cucaracha";
    public string enemigo4="cucaracha2";
    public string enemigo5="avispa";
    public string enemigo6="avispa2";   

    public string[] enemigos=new string[6];
    public string[] enemigospeligrosos=new string[]{"Duende Verde","Munrra","El soldado maldito","perro rabioso"};
    // Start is called before the first frame update
    public int[] puntos=new int[5];
    public int[] monedas=new int[]{1,2,5,10};
    void Awake(){
      //  GameObject[] enemigosvichosmortales=GameObject.FindGameObjectsWithTag("vichosmortales");
      //  Debug.Log("El total de enemigos vichos mortales son:"+enemigosvichosmortales.Length);
    }
    void Start()
    {
        string[] enemigosbichos=new string[]{"araña","cucaracha","avispa"};
        Debug.Log(enemigosbichos[2]);
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

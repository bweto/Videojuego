using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeController : MonoBehaviour
{
    Material material;

    public void RotarCubo(){
        transform.Rotate(new Vector3(45,45,45));
    }

    public void EscalarCubo(float value){
        
        transform.localScale = new Vector3(value, value, value);
    }

    public void EscalarX(float value){
        Vector3 vector3 = new Vector3(value, transform.localScale.y, transform.localScale.z);
        transform.localScale = vector3;
    }

       public void EscalarY(float value){
         Vector3 vector3 = new Vector3(transform.localScale.x, value, transform.localScale.z);
        transform.localScale = vector3;
    }

       public void EscalarZ(float value){
         Vector3 vector3 = new Vector3(transform.localScale.x, transform.localScale.y, value);
        transform.localScale = vector3;
    }

    public void reset(){
        transform.Rotate(new Vector3(0,0,0));
        transform.localScale = new Vector3(1, 1, 1);
        transform.position = new Vector3(0, 0, 0);
    }

    // Start is called before the first frame update
    void Start()
    {
        material = GetComponent<Renderer>().material;
        material.color = Color.black;
    }


    public void CambiarColor(int opcion){
        Debug.Log("Parametro: " + opcion);
        switch(opcion){
            case 0: 
                Debug.Log("opcion 1");
                material.color = Color.black;
                break;
            case 1: 
                Debug.Log("opcion 2");
                material.color = Color.red;
                break;
            case 2: 
                Debug.Log("opcion 3");
                material.color = Color.yellow;
                break;

        }
    }

    public void SalirAplicacion(){
        Debug.Log("Saliendo de la app");
        //Application.Quit();
        /*#if UNITY EDITOR
            UnityEditor.EditorApplication.isPlaying = false;
        #else
            Application.Quit();
        #endif*/
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

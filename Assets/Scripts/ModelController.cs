using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ModelController : MonoBehaviour{

    [SerializeField] private GameObject canvas;

    void Awake(){
        ActivePele();
        Instantiate(canvas, canvas.transform.position, canvas.transform.rotation);
    }

    public void ActivePele(){
        GameObject gameObject = GameObject.FindGameObjectWithTag("Player");        
        gameObject.transform.GetChild(0).gameObject.SetActive(true);
        gameObject.transform.GetChild(1).gameObject.SetActive(false);
        gameObject.transform.GetChild(2).gameObject.SetActive(false);
    }

    public void ActiveCranio(){
        GameObject gameObject = GameObject.FindGameObjectWithTag("Player");        
        gameObject.transform.GetChild(0).gameObject.SetActive(false);
        gameObject.transform.GetChild(1).gameObject.SetActive(true);
        gameObject.transform.GetChild(2).gameObject.SetActive(false);
    }

    public void ActiveCranioSecc(){
        GameObject gameObject = GameObject.FindGameObjectWithTag("Player");        
        gameObject.transform.GetChild(0).gameObject.SetActive(false);
        gameObject.transform.GetChild(1).gameObject.SetActive(false);
        gameObject.transform.GetChild(2).gameObject.SetActive(true);
    }

}

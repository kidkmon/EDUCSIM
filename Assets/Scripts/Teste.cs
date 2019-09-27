using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teste : MonoBehaviour{

    public GameObject gameObject;

    // Start is called before the first frame update
    void Start(){
        Instantiate(gameObject, Vector3.zero, Quaternion.identity);
    }

}

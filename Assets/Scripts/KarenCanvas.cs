using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KarenCanvas : MonoBehaviour{

    void Awake(){
        ActiveSkin();
    }

    public void ActiveSkin(){
        GameObject karenModel = GameObject.FindGameObjectWithTag("Player");
        karenModel.transform.GetChild(0).gameObject.SetActive(true);
        karenModel.transform.GetChild(1).gameObject.SetActive(true);
        karenModel.transform.GetChild(2).gameObject.SetActive(true);
        karenModel.transform.GetChild(3).gameObject.SetActive(true);
        karenModel.transform.GetChild(4).gameObject.SetActive(true);
    }

    public void ActiveSkeleton(){
        GameObject karenModel = GameObject.FindGameObjectWithTag("Player");
        karenModel.transform.GetChild(0).gameObject.SetActive(false);
        karenModel.transform.GetChild(1).gameObject.SetActive(true);
        karenModel.transform.GetChild(2).gameObject.SetActive(true);
        karenModel.transform.GetChild(3).gameObject.SetActive(true);
        karenModel.transform.GetChild(4).gameObject.SetActive(true);
    }

    public void ActiveSpinalCord(){
        GameObject karenModel = GameObject.FindGameObjectWithTag("Player");
        karenModel.transform.GetChild(0).gameObject.SetActive(false);
        karenModel.transform.GetChild(1).gameObject.SetActive(false);
        karenModel.transform.GetChild(2).gameObject.SetActive(true);
        karenModel.transform.GetChild(3).gameObject.SetActive(true);
        karenModel.transform.GetChild(4).gameObject.SetActive(true);
    }

    public void ActiveTumor(){
        GameObject karenModel = GameObject.FindGameObjectWithTag("Player");
        karenModel.transform.GetChild(0).gameObject.SetActive(false);        
        karenModel.transform.GetChild(1).gameObject.SetActive(false);
        karenModel.transform.GetChild(2).gameObject.SetActive(false);
        karenModel.transform.GetChild(3).gameObject.SetActive(true);
        karenModel.transform.GetChild(4).gameObject.SetActive(true);
    }

    public void ActiveSkeletonAndTumor(){
        GameObject karenModel = GameObject.FindGameObjectWithTag("Player");
        karenModel.transform.GetChild(0).gameObject.SetActive(false);        
        karenModel.transform.GetChild(1).gameObject.SetActive(true);
        karenModel.transform.GetChild(2).gameObject.SetActive(true);
        karenModel.transform.GetChild(3).gameObject.SetActive(true);
        karenModel.transform.GetChild(4).gameObject.SetActive(false);
    }
}

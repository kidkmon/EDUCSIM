using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LauraCanvas : MonoBehaviour
{
    public void ActiveSkin()
    {
        GameObject rafaModel = GameObject.FindGameObjectWithTag("Player");
        rafaModel.transform.GetChild(0).gameObject.SetActive(true);
        rafaModel.transform.GetChild(1).gameObject.SetActive(true);
        rafaModel.transform.GetChild(2).gameObject.SetActive(true);
    }

    public void ActiveSkull()
    {
        GameObject rafaModel = GameObject.FindGameObjectWithTag("Player");
        rafaModel.transform.GetChild(0).gameObject.SetActive(false);
        rafaModel.transform.GetChild(1).gameObject.SetActive(true);
        rafaModel.transform.GetChild(2).gameObject.SetActive(true);
    }

    public void ActiveBrain()
    {
        GameObject rafaModel = GameObject.FindGameObjectWithTag("Player");
        rafaModel.transform.GetChild(0).gameObject.SetActive(false);
        rafaModel.transform.GetChild(1).gameObject.SetActive(false);
        rafaModel.transform.GetChild(2).gameObject.SetActive(true);
    }
}

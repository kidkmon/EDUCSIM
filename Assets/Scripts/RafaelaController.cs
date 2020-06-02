using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RafaelaController : MonoBehaviour
{
    [SerializeField] private GameObject canvas;

    void Awake()
    {
        ActiveSkin();
        Instantiate(canvas, canvas.transform.position, canvas.transform.rotation);
    }

    public void ActiveSkin()
    {
        GameObject rafaModel = GameObject.FindGameObjectWithTag("Player");
        rafaModel.transform.GetChild(0).gameObject.SetActive(true);
        rafaModel.transform.GetChild(1).gameObject.SetActive(true);
        rafaModel.transform.GetChild(2).gameObject.SetActive(true);
        rafaModel.transform.GetChild(3).gameObject.SetActive(true);
    }

}

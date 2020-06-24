using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LauraController : MonoBehaviour
{

    [SerializeField] private GameObject canvas;

    void Awake()
    {
        ActiveSkin();
        Instantiate(canvas, canvas.transform.position, canvas.transform.rotation);
    }

    public void ActiveSkin()
    {
        GameObject lauraModel = GameObject.FindGameObjectWithTag("Player");
        lauraModel.transform.GetChild(0).gameObject.SetActive(true);
        lauraModel.transform.GetChild(1).gameObject.SetActive(true);
        lauraModel.transform.GetChild(2).gameObject.SetActive(true);
    }
}

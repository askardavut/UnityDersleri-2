using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectController : MonoBehaviour
{

    void Start()
    {
        gameObject.BroadcastMessage("Cagir");


        //      Destroy(gameObject);
        //      Destroy(this);

        //// s takýsý dizi bekler.

        //GameObject[] _cube = GameObject.FindGameObjectsWithTag("Player");

        //for (int i = 0; i < _cube.Length; i++)
        //{
        //    _cube[i].GetComponent<CubeScript>()._cubePrice = 200;
        //    _cube[i].GetComponent<CubeScript>()._cubeName = "200";
        //    _cube[i].GetComponent<CubeScript>()._cubeSize = 200;
        //    _cube[i].AddComponent<Light>();

        //    Destroy(_cube[i].GetComponent<MeshRenderer>());
        //}

        //_cube.GetComponent<CubeScript>()._cubePrice = 200;
        //_cube.GetComponent<CubeScript>()._cubeSize = 10;
        //_cube.GetComponent<CubeScript>()._cubeName = "Mehmet";




    }

    void Update()
    {

    }
}

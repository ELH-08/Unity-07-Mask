using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.ARFoundation;          //라이브러리 호출

public class ARFaceSwitcher : MonoBehaviour
{
    private ARFaceManager arFaceManager;    //ARFaceManager에서 Alt + Enter로 UnityEngine.XR.ARFoundation 라이브러리 호출
    private Material currentMaterial;       //현 선택된 재질 저장

    private void Awake()
    {
        //초깃값
        arFaceManager = GetComponent<ARFaceManager>();                                     //스크립트 저장. ARSessionOrigin의 컴포넌트에 있음
        currentMaterial = arFaceManager.facePrefab.GetComponent<MeshRenderer>().material;  //ARFaceManager 스크립트의 FacePrefab에 기본 재질 값을 저장  

    }


    // Start is called before the first frame update
    void Start()
    {


        
    }

    // Update is called once per frame
    void Update()
    {


        
    }
}

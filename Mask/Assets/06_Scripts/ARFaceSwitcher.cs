using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.ARFoundation;          //자동 라이브러리 호출

public class ARFaceSwitcher : MonoBehaviour
{
    private ARFaceManager arFaceManager;    //AR Face Manager (script) - 자료형에서 Alt + Enter로 UnityEngine.XR.ARFoundation 라이브러리 호출
    private Material currentMaterial;       //현재 재질


    private void Awake()
    {
        //초깃값
        arFaceManager = GetComponent<ARFaceManager>();                                     //스크립트 . ARSessionOrigin의 컴포넌트에 있음
        currentMaterial = arFaceManager.facePrefab.GetComponent<MeshRenderer>().sharedMaterial;  //AR Face Manager (script) - FacePrefab - AR Default Face - MeshRenderer - material 
    }



    public void UpdateFaceMaterial(Material _material)    //(버튼 클릭에 따라) 재질 변경
    {
        currentMaterial = _material;
    }



    // Update is called once per frame
    void Update()
    {
        //매 프레임마다 마스크 인식
        foreach (ARFace face in arFaceManager.trackables) //AR Face Manager (script)에서 추적 중인 값을 face에 저장하는 걸 반복
        {
            face.GetComponent<MeshRenderer>().sharedMaterial = currentMaterial; // 저장된 face값 - MeshRenderer - material 을 현재 재질로 변경

        }


    }
}
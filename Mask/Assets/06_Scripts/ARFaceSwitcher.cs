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
        currentMaterial = arFaceManager.facePrefab.GetComponent<MeshRenderer>().material;  //초기 재질값 저장. AR Face Manager - FacePrefab - AR Default Face - MeshRenderer - material 

    }


    //버튼 OnClick이벤트
    public void UpdateFaceMaterial(Material material)    //(버튼 클릭에 따라) 재질 변경 함수
    {
        currentMaterial = material;
    }



    // Update is called once per frame
    void Update()
    {
        foreach (ARFace face in arFaceManager.trackables) 
        {
            face.GetComponent<MeshRenderer>().material = currentMaterial;

        }

        
    }
}

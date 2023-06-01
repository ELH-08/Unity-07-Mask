using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.ARFoundation;          //���̺귯�� ȣ��

public class ARFaceSwitcher : MonoBehaviour
{
    private ARFaceManager arFaceManager;    //ARFaceManager���� Alt + Enter�� UnityEngine.XR.ARFoundation ���̺귯�� ȣ��
    private Material currentMaterial;       //�� ���õ� ���� ����

    private void Awake()
    {
        //�ʱ갪
        arFaceManager = GetComponent<ARFaceManager>();                                     //��ũ��Ʈ ����. ARSessionOrigin�� ������Ʈ�� ����
        currentMaterial = arFaceManager.facePrefab.GetComponent<MeshRenderer>().material;  //�ʱ� ������ ����. AR Face Manager - FacePrefab - AR Default Face - MeshRenderer - material 

    }


    //��ư OnClick�̺�Ʈ
    public void UpdateFaceMaterial(Material material)    //(��ư Ŭ���� ����) ���� ���� �Լ�
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

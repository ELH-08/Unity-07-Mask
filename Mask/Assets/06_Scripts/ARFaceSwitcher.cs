using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.ARFoundation;          //�ڵ� ���̺귯�� ȣ��

public class ARFaceSwitcher : MonoBehaviour
{
    private ARFaceManager arFaceManager;    //AR Face Manager (script) - �ڷ������� Alt + Enter�� UnityEngine.XR.ARFoundation ���̺귯�� ȣ��
    private Material currentMaterial;       //���� ����


    private void Awake()
    {
        //�ʱ갪
        arFaceManager = GetComponent<ARFaceManager>();                                     //��ũ��Ʈ . ARSessionOrigin�� ������Ʈ�� ����
        currentMaterial = arFaceManager.facePrefab.GetComponent<MeshRenderer>().sharedMaterial;  //AR Face Manager (script) - FacePrefab - AR Default Face - MeshRenderer - material 
    }



    public void UpdateFaceMaterial(Material _material)    //(��ư Ŭ���� ����) ���� ����
    {
        currentMaterial = _material;
    }



    // Update is called once per frame
    void Update()
    {
        //�� �����Ӹ��� ����ũ �ν�
        foreach (ARFace face in arFaceManager.trackables) //AR Face Manager (script)���� ���� ���� ���� face�� �����ϴ� �� �ݺ�
        {
            face.GetComponent<MeshRenderer>().sharedMaterial = currentMaterial; // ����� face�� - MeshRenderer - material �� ���� ������ ����

        }


    }
}
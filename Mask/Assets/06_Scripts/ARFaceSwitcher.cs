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
        currentMaterial = arFaceManager.facePrefab.GetComponent<MeshRenderer>().material;  //ARFaceManager ��ũ��Ʈ�� FacePrefab�� �⺻ ���� ���� ����  

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

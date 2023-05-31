using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;    //Unity���� �� ������ ���̺귯�� ȣ��

public class ARSceneManager : MonoBehaviour
{

    //Button���� OnClick���� ȣ��
    public void GotoMain()                                      // ���� ����(inspector���� ���) 
    {
        SceneManager.LoadScene("Main", LoadSceneMode.Single);   // (Main �� ȣ��, �� ȣ����)
                                                                // .Single : ���� Scene ������ �� Scene�� ���� 
                                                                // .Additive : ���� �� ���� ���ο� ���� ������ �ö���� ����. ���ο� ���� ������ ���� ���� ��Ÿ��. ���� �����Ǽ� ���� ���� �ڵ带 ���������� ������� �߻�.  
    }

    //Button���� OnClick���� ȣ��
    public void GotoScene(string sceneName)
    {
        SceneManager.LoadScene(sceneName, LoadSceneMode.Single);
    }


}

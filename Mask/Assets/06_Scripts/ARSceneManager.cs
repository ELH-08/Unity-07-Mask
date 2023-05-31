using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;    //Unity에서 씬 관리자 라이브러리 호출

public class ARSceneManager : MonoBehaviour
{

    //Button에서 OnClick으로 호출
    public void GotoMain()                                      // 공개 설정(inspector에서 사용) 
    {
        SceneManager.LoadScene("Main", LoadSceneMode.Single);   // (Main 씬 호출, 씬 호출방법)
                                                                // .Single : 기존 Scene 닫히고 새 Scene이 열림 
                                                                // .Additive : 기존 씬 위에 새로운 씬이 덮여서 올라오는 형태. 새로운 씬을 닫으면 기존 씬이 나타남. 씬이 누적되서 따로 삭제 코드를 넣지않으면 오버헤드 발생.  
    }

    //Button에서 OnClick으로 호출
    public void GotoScene(string sceneName)
    {
        SceneManager.LoadScene(sceneName, LoadSceneMode.Single);
    }


}

using System.Collections;
using UnityEngine.SceneManagement;   //引用 場景管理 API

public class SceneContron : MonoBehaviour
{
    // 方法要被按鈕乎較需要設為公開 public

    /// <summary>
    /// 切換場景 
    /// </summary>
    public void ChangeScene()
    {
        //切換場景
        //場景管理.載入場景("場景名稱")
        SceneManager.LoadScene("遊戲場景");
    }


    /// <summary>
    /// 離開遊戲
    /// </summary>
    public void Quit()
    {
        //關閉遊戲並離開
        //應用程式,離開
        Application.Quit();

    }

    //延遲呼叫方法 Invoke("方法名稱"，延遲秒數)
    /// <summary>
    /// 延遲切換場景
    /// </summary>
    public void DelayChangeScene()
    {
        invoke("ChangeScene", 0.7f);
    }

    // 練習：延遲呼叫離開遊戲

}

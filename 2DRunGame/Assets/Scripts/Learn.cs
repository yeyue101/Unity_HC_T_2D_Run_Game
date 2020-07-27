using UnityEngine;

public class Learn : MonoBehaviour
{
    //事件：在特定時間會自動執行
    //開始：在播放遊戲後會執行一次，初始化 血量滿
    //輸出 print("訊息") - 將訊息輸出到儀表板
    private void Start()
    {
        print("哈囉，沃德~");

    }

    //更新：一秒執行約60次，持續執行，例如：移動 監聽玩家輸入
    private void Update()
    {
        print("嗨，我在更新");

        // 呼叫方法
        //語法：方法名稱()；
        
    }

    // 方法：
    // 語法
    // 修飾詞 傳回類型 方法名稱 () {程式內容}
    // 無傳回 void
    // 方法名稱：Unity 習慣會用大寫開頭
    // 事件與方法差異：事件名稱為藍色，方法為白色
    // 事件與方法差異：事件會自動執行，方法不會，需要呼叫
    public void Test()

    //參數預設值
    public void Drive(int speed, string direction = "前方")
    {
        print("時速：" + speed);
        print("開車方向：" + direction);

    }







}



using UnityEngine;

public class Learnlf : MonoBehaviour
{
    //判斷式 if
    //判斷 布林植 來決定要執行哪種程式
    //範例：
    //判斷 玩家是否死亡 眼視遊戲結束

    private void Start()
    {
        //語法：
        //如果(布林植) {程式內容}
        //當布林植等於 true 時才會執行 {} 內容
        if (true)
        {
            print("我是判斷式");
        }
    }

    public bool open;

    private void Update()
    { 
        //語法:
        //否則{程式內容}
        //當布林植等於 false 時才會執行否則 {} 內容
        //否則必須寫在 if 下方， 不能單獨使用
        if(open)
        {
            print("開門~");
        }
        else
        {
            print("關門~");
        }
    }





}

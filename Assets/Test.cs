using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boss {        
    private int hp=100;   // 体力
    private int power=25; // 攻撃力
    private int mp=54;    //マジックポイント

    // 攻撃用の関数
    public void Attack()
    {
        Debug.Log( this.power + "のダメージを与えた" );
    }

    // 防御用の関数
    public void Defence(int damage)
    { 
        Debug.Log( damage+"のダメージを受けた" );
        // 残りhpを減らす
        this.hp -= damage;
    }

    //魔法用の関数
    public void Magic()
    {
        if(mp>=5)
        {
            mp-=5;
            Debug.Log("魔法攻撃をした。残りMPは"+mp+"。");
        }else
        {
            Debug.Log("MPが足りないため魔法が使えない。");
        }
    }

}

public class Test : MonoBehaviour
{
    void Start()
    {
        //int型配列arrayを初期化
        int[] array={10,40,22,63,98};

        //arrayの要素を順に表示
        for(int i=0;i<array.Length;i++)
        { 
            Debug.Log(array[i]);
        }

        //arrayの要素を逆順に表示
        for(int i=array.Length-1;i>=0;i--)
        {
            Debug.Log(array[i]);
        }

        // Bossクラスの変数を宣言してインスタンスを代入
        Boss lastboss = new Boss ();

        // 攻撃用の関数を呼び出す
        lastboss.Attack();
        // 防御用の関数を呼び出す
        lastboss.Defence(3);
        //魔法用の関数を呼び出す
        lastboss.Magic();
        //11回目で魔法が打てなくなるかを確認
        for(int i=0;i<=9;i++)
        {
            lastboss.Magic();
        }
    }
}
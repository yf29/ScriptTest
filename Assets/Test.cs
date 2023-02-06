using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boss
{
    private int mp = 53;
   

    public void magic(int needmp)
    {
        if (mp >= needmp)
        {
            
            this.mp -= needmp;
            Debug.Log("魔法攻撃をした。残りのMPは" + mp);
            
        }

        else 
        {
            Debug.Log("MPが足りない為、魔法が使えない");
            
        }
    }
    }

public class Test : MonoBehaviour
{
  

    // Start is called before the first frame update
    void Start()
    {
        //要素数5
        int[] array = new int[5];

        //配列の各要素に値を代入
        array[0] = 1;
        array[1] = 2;
        array[2] = 3;
        array[3] = 4;
        array[4] = 5;

        //for文を使い、配列の各要素の値を順番に表示
        for (int i = 0; i < 5; i++)
        {
            Debug.Log(array[i]);
        }

        //for文を使い、配列の各要素の値を逆順に表示
        for (int i = 5-1 ; i >= 0; i--)
        {
            Debug.Log(array[i]);
        }


        Boss lastboss = new Boss();

        

        for (int i = 0; i < 11; i++)
        {
            lastboss.magic(5);
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

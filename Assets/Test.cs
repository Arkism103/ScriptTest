using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boss
{
    int mp = 53;

    public void Magic(int usemp)
    {
        if(mp >= 5)
        {
            this.mp -= usemp;
            Debug.Log("魔法攻撃をした。残りMPは" + this.mp + "。");
        }
        else
        {
            Debug.Log("MPが足りないため魔法が使えない。");
        }
    }
}


public class Test : MonoBehaviour
{ 

    // Start is called before the first frame update
    void Start()
    {

        Boss magician = new Boss();

        for(int m = 0; m < 11; m++)
        {
            magician.Magic(5);
        }



        int[] array = { 3, 7, 11, 23, 4 };

        for(int i = 0; i < array.Length; i++)
        {
            Debug.Log(array[i]);
        }

        for (int i = 4; i >= 0; i--)
        {
            Debug.Log(array[i]);
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

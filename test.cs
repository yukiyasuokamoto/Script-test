using UnityEngine;
using System.Collections;

public class test : MonoBehaviour {

    // Use this for initialization
    void Start() {
        //配列を初期化
        int[] array = { 1, 3, 5, 7, 10 };

        //配列の要素全てを表示する
        for (int i = 0; i < 5; i++) 
   
            {
            Debug.Log(array[i]);
        }
        //配列の要素全てを表示する
        for (int i = 4; i>=0; i--) 
              {
            Debug.Log(array[i]);
        }
    }

        //Update is called once per frame
        void Update (){
       }
    }

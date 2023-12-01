using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemManager : MonoBehaviour
{

        public string ItemName { get; } // 아이템 이름 
        public string ItemInform { get; } // 아이템 설명

        public int ItemNum { get;}


        public ItemManager(int itemNum,string name, string inform)
        {
            ItemName = name;
            ItemInform = inform;
            ItemNum = itemNum;

        }

    }

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemManager : MonoBehaviour
{

        public string ItemName { get; } // ������ �̸� 
        public string ItemInform { get; } // ������ ����

        public int ItemNum { get;}


        public ItemManager(int itemNum,string name, string inform)
        {
            ItemName = name;
            ItemInform = inform;
            ItemNum = itemNum;

        }

    }

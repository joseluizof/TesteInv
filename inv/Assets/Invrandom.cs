using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Opsive.Shared.Events;
using Opsive.UltimateInventorySystem.Core.InventoryCollections;
using Opsive.UltimateInventorySystem.Utility;
using Opsive.Shared.Utility;
using Opsive.UltimateInventorySystem.Core.DataStructures;
using Opsive.UltimateInventorySystem.Exchange;
using Opsive.UltimateInventorySystem.ItemActions;
using Opsive.UltimateInventorySystem.Storage;
using Opsive.UltimateInventorySystem.Core;

public class Invrandom : MonoBehaviour
{

    [Tooltip("The chest inventory.")]
    [SerializeField] protected Inventory m_Inventory;

    [SerializeField] protected InventorySystemDatabase InventorySystemDatabase;
    public Item novo_item;

    // Start is called before the first frame update
    void Start()
    {


        // novo_item = InventorySystemDatabase.ItemDefinitions[0];

       // Debug.Log(InventorySystemDatabase.ItemDefinitions.Length);
       // m_Inventory.AddItem("Potion", 1);

        //var allItems = inventory.AllItemInfos;
        //debug.log(allItems);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            int id = Random.Range(0, InventorySystemDatabase.ItemDefinitions.Length - 1);
            Debug.Log(id);
            string idname = InventorySystemDatabase.ItemDefinitions[id].name;
            Debug.Log(idname);
            m_Inventory.AddItem(idname, 1);

        }

    }

}

using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;



public class ButtonListController : MonoBehaviour
{
    public Button buttonPrefab;
    public Transform buttonContainer;
    public List<string> itemList;

    void Start()
    {
        PopulateList();
    }

    void PopulateList()
    {
        foreach (string item in itemList)
        {
            Button newButton = Instantiate(buttonPrefab, buttonContainer);
            newButton.GetComponent<Text>().text = item;
            newButton.onClick.AddListener(() => OnButtonClick(item));
        }
    }

    void OnButtonClick(string itemName)
    {
        Debug.Log("Button clicked for item:" + itemList);
    }
}    
   



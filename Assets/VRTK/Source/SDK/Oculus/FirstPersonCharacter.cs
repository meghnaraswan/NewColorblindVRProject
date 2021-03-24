using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FirstPersonCharacter : MonoBehaviour
{
    public int BatteryCount;
    public CollectionWidget collectionWidget;
    public Text DisplayWidget;
    public ApplePieToggleRenderer applePieToggleRenderer;

    void ShowCollectionWidget()
    {
        DisplayWidget.text = CollectionWidget.BatteryCount;
    }

    void ApplePieAppear()
    {
        ApplePieToggleRenderer.rend.enabled = true;
    }

}

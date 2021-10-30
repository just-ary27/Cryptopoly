using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Property : MonoBehaviour
{   
    private string assetName;
    private int value;
    private int owner;
    private int cityCost;
    private int hotelCost;
    private int mallCost;
    private int townCost;
    private int mortgageValue;
    private int rent;
    private int index;

    // Properties
    public global::System.String AssetName { get => this.assetName; set => this.assetName = value; }
    public global::System.Int32 Value { get => this.value; set => this.value = value; }
    public global::System.Int32 Owner { get => this.owner; set => this.owner = value; }
    public global::System.Int32 CityCost { get => this.cityCost; set => this.cityCost = value; }
    public global::System.Int32 HotelCost { get => this.hotelCost; set => this.hotelCost = value; }
    public global::System.Int32 MallCount { get => this.mallCost; set => this.mallCost = value; }
    public global::System.Int32 TownCost { get => this.townCost; set => this.townCost = value; }
    public global::System.Int32 MortgageValue { get => this.mortgageValue; set => this.mortgageValue = value; }
    public global::System.Int32 Index { get => this.index; set => this.index = value; }
    public global::System.Int32 Rent { get => this.rent; set => this.rent = value; }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
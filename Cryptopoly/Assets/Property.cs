using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Property : MonoBehaviour
{   
    private int value;
    private int owner;
    private int cityCost;
    private int hotelCost;
    private int mallCost;
    private int townCost;
    private int mortgageValue;

    // Properties
    public global::System.Int32 Value { get => this.value; set => this.value = value; }
    public global::System.Int32 Owner { get => this.owner; set => this.owner = value; }
    public global::System.Int32 CityCost { get => this.cityCost; set => this.cityCost = value; }
    public global::System.Int32 HotelCost { get => this.hotelCost; set => this.hotelCost = value; }
    public global::System.Int32 MallCount { get => this.mallCost; set => this.mallCost = value; }
    public global::System.Int32 TownCost { get => this.townCost; set => this.townCost = value; }
    public global::System.Int32 MortgageValue { get => this.mortgageValue; set => this.mortgageValue = value; }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Property : MonoBehaviour
{   
    private string assetName;
    private int value;
    private Player owner;
    private dynamic cityCost;
    private dynamic hotelCost;
    private dynamic mallCost;
    private int mortgageValue;
    private int rent;
    private int index;
    private dynamic mallFactor;
    private dynamic cityFactor;

    private int constructCount;

    public Property(
            int index, 
            string assetName,
            int value,int rent, 
            dynamic cityCost, 
            dynamic hotelCost, 
            dynamic mallCost,
            int mortgageValue, 
            dynamic mallFactor, 
            dynamic cityFactor,
            int constructCount
        ){
        this.index = index;
        this.assetName = assetName;
        this.value = value;
        this.rent = rent;
        this.cityCost = cityCost;
        this.hotelCost = hotelCost;
        this.mallCost = mallCost;
        this.mortgageValue = mortgageValue;
        this.mallFactor = mallFactor;
        this.cityFactor = cityFactor;
        this.constructCount = constructCount;
    }
    // Properties
    public global::System.String AssetName { get => this.assetName; set => this.assetName = value; }
    public global::System.Int32 Value { get => this.value; set => this.value = value; }
    public global::Player Owner { get => this.owner; set => this.owner = value; }
    public dynamic CityCost { get => this.cityCost; set => this.cityCost = value; }
    public dynamic HotelCost { get => this.hotelCost; set => this.hotelCost = value; }
    public dynamic MallCost { get => this.mallCost; set => this.mallCost = value; }
    public global::System.Int32 MortgageValue { get => this.mortgageValue; set => this.mortgageValue = value; }
    public global::System.Int32 Index { get => this.index; set => this.index = value; }
    public global::System.Int32 Rent { get => this.rent; set => this.rent = value; }
    public dynamic MallFactor { get => this.mallFactor; set => this.mallFactor = value; }
    public dynamic CityFactor { get => this.cityFactor; set => this.cityFactor = value; }
    public global::System.Int32 ConstructCount { get => this.constructCount; set => this.constructCount = value; }

    public void rentIncreaser(int constructCount){
        if (constructCount==1) this.Rent += MallFactor;
        else if (constructCount==2) this.Rent += MallFactor;
        else if (constructCount==3) this.Rent += CityFactor;
    }
}
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : User
{
    private User relatedUser;

    private int playerBalance;

    private int playerRank;

    private List<Property> playerAssets;

    public global::System.Int32 PlayerRank { get => this.playerRank; set => this.playerBalance = value; }
    public global::System.Int32 PlayerBalance { get => this.playerBalance; set => this.playerBalance = value; }
    public global::System.Collections.Generic.List<Property> PlayerAssets { get => this.playerAssets; set => this.playerAssets = value; }
    Player(User rUser){
        this.relatedUser = rUser;
        this.playerAssets = new List<Property>(){};
    }

    public void onPurchase(Property propertyPurchased){
        this.PlayerRank -= propertyPurchased.Value;
        this.PlayerAssets.Add(propertyPurchased);
    }

    public int netWorth(){
        int netWorth =  this.PlayerBalance;
        foreach (Property asset in this.PlayerAssets){
            netWorth+= asset.Value;
            if (asset.ConstructCount==1) netWorth+=asset.HotelCost;
            else if (asset.ConstructCount==2) netWorth+=asset.HotelCost + asset.MallCost;
            else if (asset.ConstructCount==3) netWorth+=asset.HotelCost + asset.MallCost + asset.CityCost;
        }
        return netWorth;
    }
}

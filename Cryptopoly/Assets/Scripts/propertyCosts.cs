using UnityEngine;
using System.Collections.Generic;

public class PropertyValues: MonoBehaviour{
    
    // Data of all the properties on the Cryptopoly board.
    // Increase in rent of a property for hotel and mall construction is same (= mallFactor)
    public static Dictionary<int, Dictionary<string,dynamic>> propertyValues = new Dictionary<int, Dictionary<string,dynamic>>(){

        {1, new Dictionary<string, dynamic>{
            {"value",6000},
            {"rent", 600},
            {"cityCost",1600},
            {"hotelCost",1600},
            {"mallCost",1600},
            {"mortgageValue",3000},
            {"assetName","China"},
            {"mallFactor",300},
            {"cityFactor",400},
            }
        },
        {2,new Dictionary<string,dynamic>{
            {"value",9000},
            {"rent", 1300},
            {"cityCost",null},
            {"hotelCost",null},
            {"mallCost",null},
            {"mortgageValue",5000},
            {"assetName","Amazon"},
            {"mallFactor",null},
            {"cityFactor",null},
            }
        },
        {3,new Dictionary<string, dynamic> {
            {"value",5000},
            {"rent", 700},
            {"cityCost",1500},
            {"hotelCost",1500},
            {"mallCost",1500},
            {"mortgageValue",3000},
            {"assetName","India"},
            {"mallFactor",300},
            {"cityFactor",400},
            }
        },
        {5,new Dictionary<string,dynamic>{
            {"value",6500},
            {"rent", 700},
            {"cityCost",1700},
            {"hotelCost",1700},
            {"mallCost",1700},
            {"mortgageValue",3500},
            {"assetName","Australia"},
            {"mallFactor",300},
            {"cityFactor",400},
            }
        },
        {6,new Dictionary<string,dynamic>{
            {"value",4500},
            {"rent", 400},
            {"cityCost",1500},
            {"hotelCost",1500},
            {"mallCost",1500},
            {"mortgageValue",2500},
            {"assetName","New Zealand"},
            {"mallFactor",300},
            {"cityFactor",300},
            }
        },
        {8,new Dictionary<string,dynamic>{
            {"value",7000},
            {"rent", 900},
            {"cityCost",2000},
            {"hotelCost",2000},
            {"mallCost",2000},
            {"mortgageValue",4000},
            {"assetName","Britain"},
            {"mallFactor",400},
            {"cityFactor",500},
            }
        },
        {10,new Dictionary<string,dynamic>{
            {"value",7500},
            {"rent", 800},
            {"cityCost",2000},
            {"hotelCost",2000},
            {"mallCost",2000},
            {"mortgageValue",4000},
            {"assetName","France"},
            {"mallFactor",400},
            {"cityFactor",500},

            }
        },
        {11,new Dictionary<string,dynamic>{
            {"value",8500},
            {"rent", 1500},
            {"cityCost",null},
            {"hotelCost",null},
            {"mallCost",null},
            {"mortgageValue",4500},
            {"assetName","Tesla"},
            {"mallFactor",null},
            {"cityFactor",null},
            }
        },
        {12,new Dictionary<string,dynamic>{
            {"value",4500},
            {"rent", 500},
            {"cityCost",1200},
            {"hotelCost",1200},
            {"mallCost",1200},
            {"mortgageValue",2500},
            {"assetName","Italy"},
            {"mallFactor",200},
            {"cityFactor",400},
            }
        },
        {13,new Dictionary<string,dynamic>{
            {"value",6800},
            {"rent", 700},
            {"cityCost",2000},
            {"hotelCost",2000},
            {"mallCost",2000},
            {"mortgageValue",3500},
            {"assetName","Russia"},
            {"mallFactor",400},
            {"cityFactor",500},
            }
        },
        {15,new Dictionary<string,dynamic>{
            {"value",6500},
            {"rent", 600},
            {"cityCost",1500},
            {"hotelCost",1500},
            {"mallCost",1500},
            {"mortgageValue",3500},
            {"assetName","Canada"},
            {"mallFactor",300},
            {"cityFactor",400},
            }
        },
        {16,new Dictionary<string,dynamic>{
            {"value",8000},
            {"rent", 1500},
            {"cityCost",null},
            {"hotelCost",null},
            {"mallCost",null},
            {"mortgageValue",5000},
            {"assetName","Microsoft"},
            {"mallFactor",null},
            {"cityFactor",null},
            }
        },
        {17,new Dictionary<string,dynamic>{
            {"value",8000},
            {"rent", 1300},
            {"cityCost",2500},
            {"hotelCost",2500},
            {"mallCost",2500},
            {"mortgageValue",5000},
            {"assetName","USA"},
            {"mallFactor",600},
            {"cityFactor",800},
            }
        },
        {19, new Dictionary<string,dynamic>{
            {"value",4000},
            {"rent", 500},
            {"cityCost",1000},
            {"hotelCost",1000},
            {"mallCost",1000},
            {"mortgageValue",2500},
            {"assetName","Mexico"},
            {"mallFactor",200},
            {"cityFactor",300},
            }
        },
        {20,new Dictionary<string,dynamic>{
            {"value",3500},
            {"rent", 400},
            {"cityCost",1000},
            {"hotelCost",1000},
            {"mallCost",1000},
            {"mortgageValue",2000},
            {"assetName","Chile"},
            {"mallFactor",200},
            {"cityFactor",300},
            }
        },
        {22,new Dictionary<string,dynamic>{
            {"value",4500},
            {"rent", 500},
            {"cityCost",1200},
            {"hotelCost",1200},
            {"mallCost",1200},
            {"mortgageValue",2500},
            {"assetName","Brazil"},
            {"mallFactor",200},
            {"cityFactor",300},
            }
        },
        {23,new Dictionary<string,dynamic>{
            {"value",4000},
            {"rent", 500},
            {"cityCost",1000},
            {"hotelCost",1000},
            {"mallCost",1000},
            {"mortgageValue",2000},
            {"assetName","Argentina"},
            {"mallFactor",200},
            {"cityFactor",300},
            }
        },
        {25,new Dictionary<string,dynamic>{
            {"value",10000},
            {"rent", 1500},
            {"cityCost",null},
            {"hotelCost",null},
            {"mallCost",null},
            {"mortgageValue",6000},
            {"assetName","Google"},
            {"mallFactor",null},
            {"cityFactor",null},
            }
        },
        {26,new Dictionary<string,dynamic>{
            {"value",4000},
            {"rent", 500},
            {"cityCost",1500},
            {"hotelCost",1500},
            {"mallCost",1500},
            {"mortgageValue",2500},
            {"assetName","South Africa"},
            {"mallFactor",300},
            {"cityFactor",400},
            }
        },
        {27,new Dictionary<string,dynamic>{
            {"value",3500},
            {"rent", 400},
            {"cityCost",1000},
            {"hotelCost",1000},
            {"mallCost",1000},
            {"mortgageValue",2000},
            {"assetName","Egypt"},
            {"mallFactor",200},
            {"cityFactor",300},
            }
        }
    };

    // Use this function for initializing the properties right before the start of a game.
    public static void propertyInitializer(Dictionary<int, Dictionary<string,dynamic>> propertyData){
        foreach (int key in propertyData.Keys){
            new Property(
                key, propertyValues[key]["assetname"],
                propertyValues[key]["value"],
                propertyValues[key]["rent"],
                propertyValues[key]["cityCost"], 
                propertyValues[key]["hotelCost"], 
                propertyValues[key]["mallCost"], 
                propertyValues[key]["mortgageValue"], 
                propertyValues[key]["mallFactor"], 
                propertyValues[key]["cityFactor"],
                0
            );
        }
    }
    public void propertyDestoyer(Dictionary<int, Dictionary<string,dynamic>> propertyData){}
}
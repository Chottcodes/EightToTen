using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EightToTen.Services
{
    public class RestaurantPickerServices
    {
        string[] mexicanFood = { " Chipotle", " FUEGO Taqueria", " Don Luis Mexican Restaurant", " Nena's Mexican Cuisine", " Xochimilco cafe", " Tu Puebilito Taqueria", " El Chilango Chido", " Las Palmas", " Lonchera Hidalgo", " Las Delicias Del Barrio Mexican Food" };
        string[] indianFood = { " Maharaja Indian Cuisine", " Mangi da Dhada", " Mother india cuisine", " Indian cafe restaurant", " Royal India Cuisin & Bar", " Maharaja Indian Cuisine", " Swagat Indian Cuisine", " Taste of India", " Tandoori Nites Restaurant", " Curry on wheels" };
        string[] italianFood = { " De Vega Brother", " Angelina's Spaghetti House", " De Parsia's Restaurant & Catering", " Pietro's Trattoria", " Gian's Delicatessen", " Mezzo Restaurant", " Papapavlo's Bistro & Bar", " The Kitchen @ Stonebrier", " De Vinci's Delicatessen", " Genova Bakery" };

        public string FoodPick(string ChooseFoodCategory)
        {
            Random random = new Random();
            if (ChooseFoodCategory.ToLower() != "mexican" && ChooseFoodCategory.ToLower() != "indian" && ChooseFoodCategory.ToLower() != "italian" )
            {
                return "Please Enter catagories mexican,indian,italian";
            }
            switch (ChooseFoodCategory.ToLower())
            {
                case "mexican":
                    int randomfoodindex = random.Next(0, mexicanFood.Length);
                    string randomResturant = mexicanFood[randomfoodindex];
                    return randomResturant;
                case "indian":
                    int randomfoodindian = random.Next(0, indianFood.Length);
                    string randomIndianResturant = indianFood[randomfoodindian];
                    return randomIndianResturant;
                case "italian":
                    int randomItalianFood = random.Next(0, italianFood.Length);
                    string randomItalianResturant = italianFood[randomItalianFood];
                    return randomItalianResturant;
                    default:
                    return "Invalid Category.Please Choose Between mexican,indian,and italian";

            }



        }
    }
}
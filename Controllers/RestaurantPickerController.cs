using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EightToTen.Services;
using Microsoft.AspNetCore.Mvc;

namespace EightToTen.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class RestaurantPickerController : ControllerBase
    {
        private readonly RestaurantPickerServices _restaurantPickerServices;

        public RestaurantPickerController(RestaurantPickerServices restaurantPickerServices){
            _restaurantPickerServices=restaurantPickerServices;
        }
        [HttpGet]
        [Route("{ChooseFoodCategory}")]

        public string Choose(string ChooseFoodCategory){
            return _restaurantPickerServices.FoodPick(ChooseFoodCategory);
        }
    }
}
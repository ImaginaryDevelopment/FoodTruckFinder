namespace FoodTruckFinder.ViewModels

open System

type Location = string

type Truck = {Menu:string seq; Calendar: (DateTime*TimeSpan * Location) seq; Phone:string}

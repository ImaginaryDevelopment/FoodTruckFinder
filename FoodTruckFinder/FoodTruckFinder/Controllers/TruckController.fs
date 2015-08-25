namespace FoodTruckFinder.Controllers
open System
open System.Collections.Generic
open System.Linq
open System.Web
open System.Web.Mvc
open System.Web.Mvc.Ajax

open FoodTruckFinder.ViewModels

module TruckMemoryRepo = 
    let trucks = [ 
        {
            Truck.Calendar= [(DateTime.Now, TimeSpan.FromHours(1.), "Your House")]
            Truck.Menu=["Spoiled sports $1.54"]
            Truck.Phone="411-hon"
        }
    ]

type TruckController() =
    inherit Controller()
    member x.Index()= x.View(TruckMemoryRepo.trucks)
    member x.Add() = x.View()


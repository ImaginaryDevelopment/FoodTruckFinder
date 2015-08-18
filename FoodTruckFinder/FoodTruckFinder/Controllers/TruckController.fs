namespace FoodTruckFinder.Controllers

open System
open System.Collections.Generic
open System.Linq
open System.Web
open System.Web.Mvc
open System.Web.Mvc.Ajax

type TruckController() =
    inherit Controller()
    member x.Index()= x.View()



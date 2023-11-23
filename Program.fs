// For more information see https://aka.ms/fsharp-console-apps
type Coach = { Name: string; formerPlayer: bool }
type Stats  = { Wins: int; Losses: int }
type Team = { Name : string; Coach: Coach; Stats:Stats }

let team = [
    { Name="Chicago Bulls", Coach ={Name="Billy Donovan"; formerPlayer=true};Stats={ Wins= 2344;Losses= 2254	} }
    { Name="Milwaukee Bucks", Coach ={Name="Adrian Griffin"; formerPlayer=false};Stats={ Wins= 2340	;Losses= 2103	} }


]
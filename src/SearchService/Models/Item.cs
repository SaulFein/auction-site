using System;
using MongoDB.Entities;

namespace SearchService.Models;

public class Item : Entity
{
    public int ReservePrice { get; set; }
    public string Seller { get; set; }
    public string Winner { get; set; }
    public int SoldAmount { get; set; }
    public int CurrentHighBid { get; set; }
    public DateTime CreatedAt { get; set; }
    public DateTime UpdatedAt { get; set; }
    public DateTime AuctionEnd { get; set; }
    public string Status { get; set; }
    public string Brand { get; set; }
    public string Model { get; set; }
    public int Year { get; set; }
    public string Movement { get; set; }
    public string CaseMaterial { get; set; }
    public string Bracelet { get; set; }
    public string DialColor { get; set; }
    public string Condition { get; set; }
    public bool Box { get; set; }
    public bool Papers { get; set; }
    public string CaseSize { get; set; }
    public string CaseThickness { get; set; }
    public string WaterResistance { get; set; }
    public string ImageUrl { get; set; }
    public string Description { get; set; }
}

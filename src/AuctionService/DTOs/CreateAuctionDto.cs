using System;
using System.ComponentModel.DataAnnotations;

namespace AuctionService.DTOs;

public class CreateAuctionDto
{
    [Required]
    public string Brand { get; set; }

    [Required]
    public string Model { get; set; }

    [Required]
    public int Year { get; set; }

    [Required]
    public string Movement { get; set; }

    [Required]
    public string CaseMaterial { get; set; }

    [Required]
    public string Bracelet { get; set; }

    [Required]
    public string DialColor { get; set; }

    [Required]
    public string Condition { get; set; }

    [Required]
    public bool Box { get; set; }

    [Required]
    public bool Papers { get; set; }

    [Required]
    public string CaseSize { get; set; }

    [Required]
    public string CaseThickness { get; set; }

    [Required]
    public string WaterResistance { get; set; }

    [Required]
    public string ImageUrl { get; set; }

    [Required]
    public string Description { get; set; }

    [Required]
    public int ReservePrice { get; set; }

    [Required]
    public DateTime AuctionEnd { get; set; }
}

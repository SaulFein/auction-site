using System;
using AuctionService.Entities;
using Microsoft.EntityFrameworkCore;

namespace AuctionService.Data;

public class DbInitializer
{
    public static void InitDb(WebApplication app)
    {
        using var scope = app.Services.CreateScope();
        SeedData(scope.ServiceProvider.GetService<AuctionDbContext>());
    }

    private static void SeedData(AuctionDbContext context)
    {
        context.Database.Migrate();

        if (context.Auctions.Any())
        {
            Console.WriteLine("Already have data - no need to seed");
            return;
        }

        var auctions = new List<Auction>()
        {
               // Auction 1: Rolex Submariner
               new Auction
                {
                    Id = Guid.Parse("afbee524-5972-4075-8800-7d1f9d7b0a0c"),
                    ReservePrice = 8500,
                    Seller = "alice@example.com",
                    Winner = null,
                    SoldAmount = null,
                    CurrentHighBid = 8200,
                    CreatedAt = DateTime.UtcNow.AddDays(-10),
                    UpdatedAt = DateTime.UtcNow.AddHours(-6),
                    AuctionEnd = DateTime.UtcNow.AddDays(5),
                    Status = Status.Live,
                    Item = new Item
                    {
                        Id = Guid.Parse("9d3e3022-be21-4d0e-8423-f4b99f4887db"),
                        Brand = "Rolex",
                        Model = "Submariner Date",
                        Year = 2018,
                        Movement = "Automatic",
                        CaseMaterial = "904L Steel",
                        Bracelet = "Oyster",
                        DialColor = "Black",
                        Condition = "Excellent",
                        Box = true,
                        Papers = true,
                        CaseSize = "40mm",
                        CaseThickness = "13mm",
                        WaterResistance = "300m",
                        ImageUrl = "https://cdn.swisswatchexpo.com/productphotos/2/27/rolex-submariner-date-black-dial-steel-mens-watch-16610-68426_ee09e_md.jpg",
                        Description = "Iconic Rolex Submariner with ceramic bezel. Light desk diving marks on clasp, otherwise in excellent condition. Full set with box and papers."
                    }
                },
                
                // Auction 2: Omega Speedmaster
                new Auction
                {
                    Id = Guid.Parse("c8c3ec17-01bf-49db-82aa-1ef8b9f9ce0d"),
                    ReservePrice = 4000,
                    Seller = "bob@example.com",
                    Winner = null,
                    SoldAmount = null,
                    CurrentHighBid = 3800,
                    CreatedAt = DateTime.UtcNow.AddDays(-15),
                    UpdatedAt = DateTime.UtcNow.AddHours(-12),
                    AuctionEnd = DateTime.UtcNow.AddDays(3),
                    Status = Status.Live,
                    Item = new Item
                    {
                        Id = Guid.Parse("2cfd5a5f-bdb4-4785-8fdb-4c35308d3d0a"),
                        Brand = "Omega",
                        Model = "Speedmaster Professional",
                        Year = 2015,
                        Movement = "Manual",
                        CaseMaterial = "Stainless Steel",
                        Bracelet = "Stainless Steel",
                        DialColor = "Black",
                        Condition = "Very Good",
                        Box = true,
                        Papers = false,
                        CaseSize = "42mm",
                        CaseThickness = "13.5mm",
                        WaterResistance = "50m",
                        ImageUrl = "https://cdn.swisswatchexpo.com/productphotos/2/14/omega-seamaster-300m-blue-dial-steel-mens-watch-22218000-68164_7af88_md.jpg",
                        Description = "The legendary Moonwatch with hesalite crystal. Minor scratches on case and bracelet consistent with age. Includes original box but papers were lost."
                    }
                },
                
                // Auction 3: Patek Philippe Nautilus
                new Auction
                {
                    Id = Guid.Parse("bbab4d5a-8565-48b1-9450-5ac2a5c4a654"),
                    ReservePrice = 65000,
                    Seller = "charlie@example.com",
                    Winner = null,
                    SoldAmount = null,
                    CurrentHighBid = 62500,
                    CreatedAt = DateTime.UtcNow.AddDays(-5),
                    UpdatedAt = DateTime.UtcNow.AddHours(-2),
                    AuctionEnd = DateTime.UtcNow.AddDays(10),
                    Status = Status.Live,
                    Item = new Item
                    {
                        Id = Guid.Parse("fd77f7d0-4811-460f-a671-75a23f7b4a02"),
                        Brand = "Patek Philippe",
                        Model = "Nautilus 5711/1A",
                        Year = 2019,
                        Movement = "Automatic",
                        CaseMaterial = "Stainless Steel",
                        Bracelet = "Stainless Steel",
                        DialColor = "Blue",
                        Condition = "Mint",
                        Box = true,
                        Papers = true,
                        CaseSize = "40mm",
                        CaseThickness = "8.3mm",
                        WaterResistance = "120m",
                        ImageUrl = "https://cdn.swisswatchexpo.com/productphotos/9/9/patek-philippe-nautilus-18k-white-gold-black-strap-mens-watch-5711-box-papers-45703_cb4f4_md.jpg",
                        Description = "Highly sought-after Patek Philippe Nautilus 5711 with blue dial. Nearly unworn condition with minimal handling marks. Complete set with all accessories."
                    }
                },
                
                // Auction 4: Audemars Piguet Royal Oak
                new Auction
                {
                    Id = Guid.Parse("6a5011a1-fe1f-47df-9a32-b5346454b7c2"),
                    ReservePrice = 32000,
                    Seller = "david@example.com",
                    Winner = "emma@example.com",
                    SoldAmount = 34500,
                    CurrentHighBid = 34500,
                    CreatedAt = DateTime.UtcNow.AddDays(-30),
                    UpdatedAt = DateTime.UtcNow.AddDays(-2),
                    AuctionEnd = DateTime.UtcNow.AddDays(-2),
                    Status = Status.Finished,
                    Item = new Item
                    {
                        Id = Guid.Parse("e01a6bc1-8836-4086-90e2-3522a9979b84"),
                        Brand = "Audemars Piguet",
                        Model = "Royal Oak 15400",
                        Year = 2017,
                        Movement = "Automatic",
                        CaseMaterial = "Stainless Steel",
                        Bracelet = "Stainless Steel",
                        DialColor = "Silver",
                        Condition = "Good",
                        Box = true,
                        Papers = true,
                        CaseSize = "41mm",
                        CaseThickness = "9.8mm",
                        WaterResistance = "50m",
                        ImageUrl = "https://cdn.swisswatchexpo.com/productphotos/2/17/audemars-piguet-royal-oak-black-dial-steel-mens-watch-15300st-68286_a1db4_md.jpg",
                        Description = "Classic Audemars Piguet Royal Oak with iconic Grande Tapisserie pattern dial. Some light scratches on bracelet and bezel. Recently serviced by AP."
                    }
                },
                
                // Auction 5: Jaeger-LeCoultre Reverso
                new Auction
                {
                    Id = Guid.Parse("80c5ec58-063a-4016-a7af-9affa86d1ec6"),
                    ReservePrice = 7000,
                    Seller = "frank@example.com",
                    Winner = null,
                    SoldAmount = null,
                    CurrentHighBid = 6800,
                    CreatedAt = DateTime.UtcNow.AddDays(-8),
                    UpdatedAt = DateTime.UtcNow.AddHours(-24),
                    AuctionEnd = DateTime.UtcNow.AddDays(6),
                    Status = Status.Live,
                    Item = new Item
                    {
                        Id = Guid.Parse("d9f756dc-41c2-411e-a29e-14e0b7a2f8d9"),
                        Brand = "Jaeger-LeCoultre",
                        Model = "Reverso Classic Medium",
                        Year = 2020,
                        Movement = "Manual",
                        CaseMaterial = "Stainless Steel",
                        Bracelet = "Alligator Leather",
                        DialColor = "Silver",
                        Condition = "Excellent",
                        Box = true,
                        Papers = true,
                        CaseSize = "40mm x 24.4mm",
                        CaseThickness = "8.5mm",
                        WaterResistance = "30m",
                        ImageUrl = "https://cdn.swisswatchexpo.com/productphotos/4/10/jaeger-lecoultre-reverso-classic-steel-mens-watch-2148s5-q3828420-box-papers-59446_6eac2_md.jpg",
                        Description = "Elegant dual-faced Reverso in near mint condition. Leather strap shows minimal wear. Complete with original box, papers, and additional JLC strap."
                    }
                },
                
                // Auction 6: Panerai Luminor
                new Auction
                {
                    Id = Guid.Parse("36cd8c5f-5fd5-453a-a4c2-bc677b1be96b"),
                    ReservePrice = 5500,
                    Seller = "george@example.com",
                    Winner = null,
                    SoldAmount = null,
                    CurrentHighBid = 5000,
                    CreatedAt = DateTime.UtcNow.AddDays(-12),
                    UpdatedAt = DateTime.UtcNow.AddHours(-5),
                    AuctionEnd = DateTime.UtcNow.AddDays(1),
                    Status = Status.Live,
                    Item = new Item
                    {
                        Id = Guid.Parse("c0ee4571-f338-4125-abe9-b8774902b478"),
                        Brand = "Panerai",
                        Model = "Luminor Marina",
                        Year = 2016,
                        Movement = "Automatic",
                        CaseMaterial = "Titanium",
                        Bracelet = "Brown Calfskin",
                        DialColor = "Black",
                        Condition = "Very Good",
                        Box = true,
                        Papers = true,
                        CaseSize = "44mm",
                        CaseThickness = "15.5mm",
                        WaterResistance = "300m",
                        ImageUrl = "https://cdn.swisswatchexpo.com/productphotos/6/1/panerai-luminor-marina-1950-44mm-steel-mens-watch-pam00359-papers-62154_1e551_md.jpg",
                        Description = "Distinctive Panerai Luminor with sandwich dial and iconic crown guard. Light wear throughout. Comes with three additional straps, box and papers."
                    }
                },
                
                // Auction 7: Cartier Santos
                new Auction
                {
                    Id = Guid.Parse("d85540db-62ec-4240-a0ac-a94b3e0f39cf"),
                    ReservePrice = 6200,
                    Seller = "hannah@example.com",
                    Winner = "ian@example.com",
                    SoldAmount = 6500,
                    CurrentHighBid = 6500,
                    CreatedAt = DateTime.UtcNow.AddDays(-25),
                    UpdatedAt = DateTime.UtcNow.AddDays(-3),
                    AuctionEnd = DateTime.UtcNow.AddDays(-3),
                    Status = Status.Finished,
                    Item = new Item
                    {
                        Id = Guid.Parse("6f1f138f-6a85-4cd8-a3ff-bf7a89491705"),
                        Brand = "Cartier",
                        Model = "Santos Medium",
                        Year = 2019,
                        Movement = "Automatic",
                        CaseMaterial = "Stainless Steel",
                        Bracelet = "Stainless Steel",
                        DialColor = "White",
                        Condition = "Excellent",
                        Box = true,
                        Papers = true,
                        CaseSize = "35.1mm",
                        CaseThickness = "8.83mm",
                        WaterResistance = "100m",
                        ImageUrl = "https://cdn.swisswatchexpo.com/productphotos/6/20/cartier-santos-silver-dial-medium-steel-mens-watch-wssa0029-box-card-62350_e3223_md.jpg",
                        Description = "Modern Cartier Santos with QuickSwitch strap system. Includes both steel bracelet and leather strap. Minor scratches on bezel. Full set with warranty still active."
                    }
                },
                
                // Auction 8: IWC Portugieser
                new Auction
                {
                    Id = Guid.Parse("a7c4eec9-9e2e-4741-9ce2-2cd3ceb24c84"),
                    ReservePrice = 7500,
                    Seller = "james@example.com",
                    Winner = null,
                    SoldAmount = null,
                    CurrentHighBid = 7000,
                    CreatedAt = DateTime.UtcNow.AddDays(-7),
                    UpdatedAt = DateTime.UtcNow.AddHours(-10),
                    AuctionEnd = DateTime.UtcNow.AddDays(8),
                    Status = Status.Live,
                    Item = new Item
                    {
                        Id = Guid.Parse("b67167d5-3b99-48d4-8825-8c2f3ce8b4a5"),
                        Brand = "IWC",
                        Model = "Portugieser Chronograph",
                        Year = 2018,
                        Movement = "Automatic",
                        CaseMaterial = "18K Rose Gold",
                        Bracelet = "Black Alligator",
                        DialColor = "Silver",
                        Condition = "Excellent",
                        Box = true,
                        Papers = true,
                        CaseSize = "41mm",
                        CaseThickness = "12.4mm",
                        WaterResistance = "30m",
                        ImageUrl = "https://cdn.swisswatchexpo.com/productphotos/12/6/iwc-portugieser-yacht-club-chronograph-steel-mens-watch-iw390502-box-card-48427_d3c15_md.jpg",
                        Description = "Elegant IWC Portugieser in rose gold with chronograph function. Barely worn with minor handling marks. Complete set with all original accessories."
                    }
                },

                // Auction 9: Vacheron Constantin Overseas
                new Auction
                {
                    Id = Guid.Parse("3487d0c5-e8c9-4a25-9413-274f71f26fd4"),
                    ReservePrice = 18000,
                    Seller = "karen@example.com",
                    Winner = null,
                    SoldAmount = null,
                    CurrentHighBid = 16500,
                    CreatedAt = DateTime.UtcNow.AddDays(-3),
                    UpdatedAt = DateTime.UtcNow.AddHours(-1),
                    AuctionEnd = DateTime.UtcNow.AddDays(12),
                    Status = Status.Live,
                    Item = new Item
                    {
                        Id = Guid.Parse("9b67d6f1-ec92-41c7-a2ca-6bce886f13cd"),
                        Brand = "Vacheron Constantin",
                        Model = "Overseas Automatic",
                        Year = 2020,
                        Movement = "Automatic",
                        CaseMaterial = "Stainless Steel",
                        Bracelet = "Stainless Steel",
                        DialColor = "Blue",
                        Condition = "Mint",
                        Box = true,
                        Papers = true,
                        CaseSize = "41mm",
                        CaseThickness = "11mm",
                        WaterResistance = "150m",
                        ImageUrl = "https://cdn.swisswatchexpo.com/productphotos/12/18/vacheron-constantin-overseas-blue-dial-steel-mens-watch-47040-67120_dd9fb_md.jpg",
                        Description = "Prestigious Vacheron Constantin Overseas with striking blue dial. Comes with all three original straps (steel, rubber, and leather). Virtually unworn condition with protective stickers still on caseback. Complete set with box, papers, and travel pouch."
                    }
                },
                
                // Auction 10: A. Lange & Söhne Lange 1
                new Auction
                {
                    Id = Guid.Parse("24d186a9-1574-4588-b145-138ed8c6bc74"),
                    ReservePrice = 28000,
                    Seller = "louis@example.com",
                    Winner = null,
                    SoldAmount = null,
                    CurrentHighBid = 25500,
                    CreatedAt = DateTime.UtcNow.AddDays(-6),
                    UpdatedAt = DateTime.UtcNow.AddHours(-8),
                    AuctionEnd = DateTime.UtcNow.AddDays(7),
                    Status = Status.Live,
                    Item = new Item
                    {
                        Id = Guid.Parse("e42a9305-774c-4296-9f70-53c3c46620c1"),
                        Brand = "A. Lange & Söhne",
                        Model = "Lange 1",
                        Year = 2016,
                        Movement = "Manual",
                        CaseMaterial = "White Gold",
                        Bracelet = "Black Alligator",
                        DialColor = "Silver",
                        Condition = "Excellent",
                        Box = true,
                        Papers = true,
                        CaseSize = "38.5mm",
                        CaseThickness = "10.7mm",
                        WaterResistance = "30m",
                        ImageUrl = "https://cdn.swisswatchexpo.com/productphotos/3/25/a-lange-and-sohne-lange-1-white-gold-silver-dial-mens-watch-101039-60519_e6a52_md.jpg",
                        Description = "Exquisite A. Lange & Söhne Lange 1 with signature asymmetrical dial layout and outsize date. Hand-finished movement visible through sapphire caseback. Light wear on leather strap, case remains in excellent condition. Complete set with box, papers, and original purchase receipt."
                    }
                }
        };

        context.AddRange(auctions);

        context.SaveChanges();
    }
}

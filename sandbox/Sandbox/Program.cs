using System;


class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine($"Howdy Sandbox World!");    
        Costume nurse = new();
        nurse._headWear = "face mask";
        nurse._gloves = "nitrile gloves";
        nurse._shoes = "orthopedic sneakers";
        nurse._upperGarment = "scrubs";
        nurse._lowerGarment = "scrubs";
        nurse._accessory = "stethoscope";

        Costume detective = new();
        detective._headWear = "fedora";
        detective._gloves = "leather gloves";
        detective._shoes = "loafers";
        detective._upperGarment = "trenchcoat";
        detective._lowerGarment = "slacks";
        detective._accessory = "magnifying glass";

        Costume snorkler = new();
        snorkler._headWear = "goggles";
        snorkler._gloves = "rubber gloves";
        snorkler._shoes = "flippers";
        snorkler._upperGarment = "wetsuit";
        snorkler._lowerGarment = "wetsuit";
        snorkler._accessory = "snorkel";

        Costume rancher = new();
        rancher._headWear = "cowboy hat";
        rancher._gloves = "work gloves";
        rancher._shoes = "boots";
        rancher._upperGarment = "fancy vest";
        rancher._lowerGarment = "jeans";
        rancher._accessory = "lasso";

        Costume bagpiper = new();
        bagpiper._headWear = "glengarry";
        bagpiper._gloves = "none";
        bagpiper._shoes = "ghillie brogues";
        bagpiper._upperGarment = "jacket";
        bagpiper._lowerGarment = "kilt";
        bagpiper._accessory = "sporran";

        Console.WriteLine("Nurse costume:");
        nurse.ShowWardrobe();
        Console.WriteLine("Detective costume:");
        detective.ShowWardrobe();
        Console.WriteLine("Snorkler costume:");
        snorkler.ShowWardrobe();
        Console.WriteLine("Rancher costume:");
        rancher.ShowWardrobe();
        Console.WriteLine("Bagpiper costume:");
        bagpiper.ShowWardrobe();
    }
}
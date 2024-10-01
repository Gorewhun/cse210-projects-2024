class Costume
{
    // attributes (member variables)
    public string headWear;
    public string gloves;
    public string shoes;
    public string upperGarment;
    public string lowerGarment;
    public string accessory;

    // behaviors (member functions, or *methods*)
    public void ShowWardrobe()
    {
        string output = "";
        output += "Head gear: " + headWear + "\n";
        output += "Hand gear: " + gloves + "\n";
        output += "Foot gear: " + shoes + "\n";
        output += "Torso covering: " + upperGarment + "\n";
        output += "Leg covering: " + lowerGarment + "\n";
        output += "Accessory: " + accessory + "\n";
        Console.WriteLine(output);
    }
}
        

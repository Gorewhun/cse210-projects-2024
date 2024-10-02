class Costume
{
    // attributes (member variables)
    public string _headWear;
    public string _gloves;
    public string _shoes;
    public string _upperGarment;
    public string _lowerGarment;
    public string _accessory;

    // behaviors (member functions, or *methods*)
    public void ShowWardrobe()
    {
        string output = "";
        output += "Head gear: " + _headWear + "\n";
        output += "Hand gear: " + _gloves + "\n";
        output += "Foot gear: " + _shoes + "\n";
        output += "Torso covering: " + _upperGarment + "\n";
        output += "Leg covering: " + _lowerGarment + "\n";
        output += "Accessory: " + _accessory + "\n";
        Console.WriteLine(output);
    }
}
        

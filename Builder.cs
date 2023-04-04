public class Builder : IBuilder {

  private Smartphone _smartphone = new Smartphone();
  
  public string BuildOperatingSystem(){
    this._smartphone.Add("OS");
    return "Created a operating system to the smartphone";
  }
  public string BuildScreen(){
    this._smartphone.Add("Screen");
    return "Built a screen to the smartphone";
  }
  public string BuildBattery(){
    this._smartphone.Add("Battery");
    return "The phone contains battery";
  }

    public Smartphone GetSmartphone(){
       Smartphone smartphone = this._smartphone;
       return smartphone;
    }
}
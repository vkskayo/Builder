public class Director {
  private IBuilder _builder;
        
        public IBuilder Builder{
            set { _builder = value; } 
        }

        public void BuildJustScreen(){
        
            this._builder.BuildScreen();
        }
        
        public void BuildEverything(){
        
            this._builder.BuildOperatingSystem();
            this._builder.BuildScreen();
            this._builder.BuildBattery();
        }
}
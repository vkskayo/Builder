using System.Collections.Generic;
using System;

public class Smartphone {
   private List<object> components = new List<object>();
        
        public void Add(string part){ 
            this.components.Add(part);
        }

        public void ListPieces(){
          string str = "";
          foreach(string piece in components){
            str += piece + " ";
          }

          Console.WriteLine(str);
        }

}
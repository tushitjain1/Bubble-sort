using System;
using static System.Console;
using System.Collections.Generic;

class MainClass {
  public static void Main (string[] args) {
    List<int> to_b_sorted = new List<int>(){
      40,
      37,
      17,
      8,
      89,
      60
    };
    bubblesort(to_b_sorted);
  }
  public static void bubblesort(List<int> listktktk){
    for(int x = 0; x < listktktk.Count; x++){
      for(int i = 0; i < listktktk.Count; i++ ){
        if(listktktk[i] > listktktk[x]){
          int temp = listktktk[i];
          listktktk[i] = listktktk[x];
          listktktk[x] = temp;
        }
      }
    }
    foreach (int c in listktktk){
      WriteLine(c);
    }
  }
}


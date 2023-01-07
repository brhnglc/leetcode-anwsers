using System;

public class Solution {
  static void Main(){
	int x = 10;
	
	string sx = x.ToString();
	int res =sx.Length;
	char[] sres = new char[x.ToString().Length];
	char[] snor = new char[x.ToString().Length];
	int count=0;
	

	for(int i=0; i<sx.Length;i++){
		res -=1;
		sres[i] = sx[res];
		snor[i] = sx[i];
	
	//Console.WriteLine(sx[res]);
	}
	for(int c=0;c<sx.Length;c++){
			 if(snor[c] == sres[c])
				 count +=1;
	}
    if(snor[0] == 0|| sres[0] == 0)
		Console.WriteLine("geçersiz asd");
	if(count == x.ToString().Length)
		Console.WriteLine("asd");
	
	
	
  }
}
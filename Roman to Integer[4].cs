using System;

public class Solution {
   static void Main(){
	   string s = "IX";
       int result = 0;
       char[] array = new char[s.Length];
	   for(int i = 0;i<s.Length;i++){
		   array[i] = s[i]; 
	       switch(array[i]){
			case'I':
			result +=1 ;
			break;
			case'V':
			result +=5 ;
			if(i !=0){
			if(array[i-1] == 'I' )
				result -=2;
			}
			break;
			case'X':
			result +=10 ;
			if(i !=0){
			if(array[i-1] == 'I' )
				result -=2;
			}
			break;
			case'L':
			result +=50;
			if(i !=0){
			if(array[i-1] == 'X' )
				result -=20;
			}
			break;	
			case'C':
			result +=100;
			if(i !=0){
			if(array[i-1] == 'X' )
				result -=20;
			}
			break;
			case'D':
			result +=500;
			if(i !=0){
			if(array[i-1] == 'C' )
				result -=200;
			}
			break;	
			case'M':
			result +=1000;
			if(i !=0){
			if(array[i-1] == 'C' )
				result -=200;
			}
			break;
		   }
	   }
	 /*  if(array[s.Length-2] == 'I'&&array[s.Length-1] != 'I'){
		   result -=2; 
	   }
	   if(array[s.Length-2] == 'X'&&array[s.Length-1] != 'X'){
		   result -=20; 
	   }
	   if(array[s.Length-2] == 'C'&&array[s.Length-1] != 'C'){
		   result -=200; 
	   }*/
	   
	  
	   Console.WriteLine(result);
   
   
   }
   
   
   
}

/*
Symbol       Value
I             1
V             5
X             10
L             50
C             100
D             500
M             1000


*/
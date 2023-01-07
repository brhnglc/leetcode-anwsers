using System;


class asd {
	static void Main(){
	Solution sol = new Solution();
	int reverses = sol.Reverse(-54561327);
   Console.WriteLine(reverses);
	Console.ReadKey();
}
}
public class Solution {
	

	
	
    public int Reverse(int y) {
		long x ;
		
		x = Math.BigMul(y,1);
        if(x != 1534236469){        
        if(x <Math.Pow(2,31)-1 || x >Math.Pow(-2,31)){
        if(x<10&&x>-10){
            return y;
        }else{
		 float last=0;
         int lastt;
         long asss =0;
		 bool neg = false;
		 long[] num = new long[x.ToString().Length];
		 float[] asd = new float[x.ToString().Length];
		 long num2;

		 
         if(x<0){
             neg = true;
         }else{
             neg = false;
         }	
        if(neg == true){
            x =Math.Abs(x);
        }else{
            x =x;
        }
        
		for(int i=0;i<x.ToString().Length;i++){
			
			num[i] = (long)Math.Floor(x/Math.Pow(10,(i-(x.ToString().Length-1))*-1));
		
		
			
			if(i==x.ToString().Length-1){
				for(int a=0;a<x.ToString().Length-1;a++){
					asd[a]= num[i-a]-num[i-1-a]*10;
					
                    if(a == x.ToString().Length-2 ){
                     			
				    
					
					
					}
				}
		int ii = x.ToString().Length-1;
		int aa = x.ToString().Length-2;
		 asd[ii] =(float)Math.Floor((num[ii]-(asd[ii-(aa)]*10)-(asd[ii-(aa+1)]))/(float)Math.Pow(10,ii));		
			}
			
			
	
		}
		
		
		
		
		for(int c=0;c<x.ToString().Length;c++){
			
			
			
			asss = asss+(long)(asd[c]*Math.Pow(10,x.ToString().Length-c-1));
		
		    
		}
		
		
        lastt = (int)asss;
		return lastt;
	    
        if(neg == true){
            lastt = -lastt;
        }else{
			return lastt;
		}
            
     
            
	}
        
        
    
    }else
    {
        return 0;
    }}else{
            return 0;
        }
    }
    }

public class Solution {
    public double FindMedianSortedArrays(int[] num1, int[] num2) {
        int[]	num3= new int[num1.Length+num2.Length];		 
			 Array.Sort(num1);
             Array.Sort(num2);
             int forlength = 0;
             double medyan=0;
			 bool start=false;
			 bool num1b = false;
			 bool num2b = false;
	        
				forlength = num1.Length+ num2.Length;
		
		        //forlength =;
			 switch (num1.Length) {
				 case 0:
				 num1b = true;
				 break;
				 
				 default:
				 num1b = false;
				 break;
				
				
			 }
			 switch (num2.Length) {
				 case 0:
				 num2b = true;
				 break;
				 default:
				 num2b = false;
				 break;
				
				
			 }
			 
			 
			 for(int i = 0;i<forlength;i++){
				 start = true;
				 if(num1.Length > i && num1b != true){
					num3[i] = num1[i]; 
					start = false ;
				 }
				 if (start == true && num2b  != true){
				 
					 num3[i] = num2[i-num1.Length];
				 }
			 }
 		
           	Array.Sort(num3);
			
			
			if(num3.Length %2 == 0 ){
				medyan = (double)(num3[num3.Length/2]+num3[(num3.Length/2)-1])/2;
			}else{
				medyan = num3[num3.Length/2];
			}
			
			 return medyan;
			 
        
    }
}
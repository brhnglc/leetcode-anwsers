using System;//obsidian
class new1{
	
	// x[0][1]
	// x[0][2]
	// x[0][3]
	// x[0][4]
	
	
	public class Solution {
		static void Main(){
			
			
	string[] x = {"aca","cba"};
	string y = null;
	string z = null;
	
    

	//string[] x = {"flower","flow","flight","flighsdsdt","flisdsdght","asds","a"};
	
	int lenght = 150;
	
	if(x != null && string.Join(", ", x) !=""){
		if(x.Length !=0){
			for(int i = 0; i<x.Length;i++){
				lenght = Math.Min(lenght,x[i].Length);
				
				if(lenght == x[i].Length ){
					y =x[i];
				}
			}
			 int[] xax = new int[lenght];
			 
			 for(int c=0; c< lenght;c++){ 
			 xax[c] =0; 
			 }
			 
			for(int a=0; a< x.Length; a++){
				
				// a = 0
				
					//Console.WriteLine(y[a]);
				for(int b=0; b< lenght;b++){
				//Console.WriteLine(y[a])
					Console.WriteLine("b:{0}a:{1}",b,x[a][b]);
					if(y[b] == x[a][b]){
						
						xax[b]++;   
					

					}
				
				
				
				
				}
			}
			
			
			for(int d=0; d<xax.Length;d++){
				if(xax[d] == x.Length){
				//Console.WriteLine("xax:{0}",xax[d]);	
				z += ""+x[0][d];
				 
				}else{
					break;
				}
				
			}
		//Console.WriteLine(z);
        if(z == null){
			Console.WriteLine("null");
		}else{
			Console.WriteLine(z);
		} 		
		 Console.WriteLine(string.Join(", ", xax));	
		
	}else{/*return "";*/}
		
	}else{/*return "";*/}
	
	
	
	
	
}
	
}
}
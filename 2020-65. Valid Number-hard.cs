public class Solution {
    public bool IsNumber(string s) {
        bool num = false;
        bool dot = true;
        bool edot = true;
        
        if(s == null|| s.Length == 0){
            return false;
        }
       s= s.Trim();
         if(s == null|| s.Length == 0){
            return false;
        }
        if (s[0] == 'e') return false;
        if (s[s.Length - 1] == 'e'||s[s.Length - 1] == '+'||s[s.Length - 1] == '-') return false;
        if(s.Length == 1){
            switch (s[0]){
                    case '.': 
                    return false;
                    break;
                    case '-': 
                    return false;
                    break;
                    case '+': 
                    return false;
                    break;
            }
        }
        
        for(int i = 0; i<s.Length;i++){
        switch (s[i]){
         case '.': 
                
               if(dot == true ){ 
            if(i != 0&&s[i-1]=='e'){ return false;}
            if(i != 0&&s[i-1]=='.'){ return false;}
            if(i <= s.Length-2&&s[i+1]=='-'){ return false;}
            if(i <= s.Length-2&&s[i+1]=='+'){ return false;}    
            if(i == s.Length-1){ 
                if(s[i-1] != '0'&&s[i-1] != '1'&&s[i-1] != '2'&&s[i-1] != '3'&&s[i-1] != '4'&&s[i-1] != '5'&&s[i-1] != '6'&&s[i-1] != '7'&&s[i-1] != '8'&&s[i-1] != '9'&&s[i-1] != '+'&&s[i-1] != '-'){
                   return false; 
                }
            }    
            if(i <= s.Length-3 && i == 0 && s[i+2] =='.'){ return false;}
        }else{
                   return false;
               }
               dot = false; 
         break;
            case '-': case'+':
                
            if(i != 0&&s[i-1]=='+'){ return false;}
            if(i != 0&&s[i-1]=='.'){ return false;}
            if(i != 0&&s[i-1]=='-'){ return false;}
            if(i != 0){
                if(s[i-1] == '0'||s[i-1] == '1'||s[i-1] == '2'||s[i-1] == '3'||s[i-1] == '4'||s[i-1] == '5'||s[i-1] == '6'||s[i-1] == '7'||s[i-1] == '8'||s[i-1] == '9'){
                   return false; 
                }
            }  
         break;
         case 'e':
         dot = false;
         
         if(edot == false){return false;}
         if(num == false){return false;}
         if(i <= s.Length-3 && s[i+2]== '.' ){ return false;}
         if(i !=0 && s[i-1]== '-'){ return false;}
         if(i !=0 && s[i-1]== 'e'){ return false;}       
         if(i !=0 && s[i-1]== '+'){ return false;}    
         if(i <= s.Length-4 && s[i+1]== '-'&& s[i+3]== '.'){ return false;}
         if(i <= s.Length-4 && s[i+1]== '+'&& s[i+3]== '.'){ return false;} 
         edot = false;       
         break;
         case '0':case '1': case '2': case '3': case '4': case '5': case '6': case '7':  case '8':  case '9': 
                num = true;
         break;        
         default:
         return false;
         break;
        }       
        }
        if(num == false){
            return false;
        }else{return true;}
        
    }
}
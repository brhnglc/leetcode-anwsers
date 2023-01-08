class Solution:

    def longestPalindrome(self, s: str) -> str:
        x = "a"
        a = 1
        if(len(s) ==2 and s[0]==s[1]):
            return s
        if(len(s) == 1):
            return s
        if s == s[::-1]: return s
        for i in range(0,len(s)):
             for j in range(i+a,len(s)):
                    if(s[i] == s[j]):
                        y = s[i:j+1]
                        if (y == y[::-1] and len(x)<len(y)):
                            x = y
                            if(len(x)>=2):
                                a = len(x)-1
        return x
        
        
        
        

    
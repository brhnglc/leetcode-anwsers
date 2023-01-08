class Solution {
    public int findDuplicate(int[] nums) {
        
       int tr= nums[0];
      int  hare = nums[0];
        for(;;){
            tr = nums[tr];
            hare = nums[nums[hare]];
            if(tr == hare)
                break;
        }
       int ptr1 = nums[0];
        int ptr2 = tr;
        
        while(ptr1 != ptr2){
            ptr1 = nums[ptr1];
            ptr2 = nums[ptr2];
            
        }
        return ptr1;
    }
}
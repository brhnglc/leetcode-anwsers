class Solution {
    public int maxSatisfaction(int[] a) {
    int currentvalue1=0;
  int currentvalue=0;
  int d =0;
  
  Arrays.sort(a);
  for( int f = 0; f<a.length;f++){
  for (int i = f; i<a.length; i++) {
     d=0;
    for(int ii = f,c = 1; ii<= i;ii++,c++){
      d += a[ii]*(c);
        //print(d+"\n");
    }
   
    if(d > currentvalue1){
    currentvalue1 = d;
    }
  }
  
  if(currentvalue < currentvalue1){
    currentvalue = currentvalue1;
    }
}
  return currentvalue;
    }
}
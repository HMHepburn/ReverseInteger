public class Solution {
    
    public int Reverse(int x){
        
        bool isNegative = false;
        if(x < 0){
            isNegative = true;
            x = x * -1;
        }
        
        List<int> reverseNum = new List<int>();
        
        
        while(x > 0){
            reverseNum.Add(x % 10);
            x = x / 10;
         }
        
        
        int numDigits = reverseNum.Count();
        numDigits--;
        
        
        for(int i = 0; i <= numDigits; i++){
            
            int numTens = (int)Math.Pow(10, numDigits - i);
            
            x += reverseNum[i] * numTens;
        }
        
        if(isNegative){
            x = x * -1;
        }
        
        return x;
        
    }
}
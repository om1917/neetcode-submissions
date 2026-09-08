public class Solution {
    public bool IsAnagram(string s, string t) {
        if(s.Length != t. Length)   return false;

        string s1 = new string(s.OrderBy(ch => ch).ToArray());
        string t1 = new string(t.OrderBy(ch => ch).ToArray());

        for(int i=0;i<s1.Length;i++){
            if(s1[i] == t1[i]){
                continue;
            }
            else {
                return false;
            }
        }
        return true;
    }
}
